using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using EF_TEST;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;




public class VideoContext : DbContext
{
    public DbSet<SatelliteData> myTable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SatelliteData>().ToTable("SatelliteData");
    }
}

public class MssqlDatabase2
{
    private DbConnection connection;
    public void Connect()
    {
        connection = new SqlConnection(@"Server = (localdb)\\mssqllocaldb; Database = SatelliteApp; Trusted_Connection = True;");
        connection.Open();
    }

    public void Disconnect()
    {
        connection.Close();
    }

    public DbDataReader ExcuteSql(string sql)
    {
        DbCommand command = new SqlCommand(sql, (SqlConnection)connection);
        return command.ExecuteReader();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //var db2 = new MssqlDatabase2();
        //db2.Connect();
        //db2.ExcuteSql(@"INSERT INTO dbo.SatelliteData(NumberID, SatelliteType, SatelliteArea, FileCreateDate, FilePath, UserID)"
        //                + @"VALUES (1, 'HD', 'Kitchen', '2020-01-01 10:00:00', 'C:\Files\image.jpg', 'John Smith')");

        using (var db = new VideoContext())
        {
            db.myTable.Add(new SatelliteData
            {
                NumberID = 0,
                SatelliteArea = "Korea",
                SatelliteType = "IKR",
                FilePath = @"C\FilePath\jdfds.jpg",
                FileCreateDate = DateTime.Now,
                UserID = "PARK SANG HOON"
            });
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                {
                    // Log the innermost exception message
                    Console.WriteLine(ex.InnerException.InnerException.Message);
                }
                else
                {
                    // Log the exception message
                    Console.WriteLine(ex.Message);
                }
            }
        }
        Console.WriteLine("Complete");
        Console.ReadLine();
    }
}
