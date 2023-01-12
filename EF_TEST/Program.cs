using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using EF_TEST;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public class DBData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "번호")]
    public int NumberID { get; set; }

    [StringLength(255)]
    [Required(ErrorMessage = "입력하시오")]
    [Column(TypeName = "NVarChar(255)")]
    public string Type { get; set; }

    [StringLength(255)]
    public string Area { get; set; }

    public DateTime FileCreateDate { get; set; }

    [StringLength(255)]
    public string FilePath { get; set; }

    [StringLength(100)]
    public string UserID { get; set; }

}


public class DBTESTContext : DbContext
{
    string strDataBase = "SatelliteData";          //Database
    string strIP = "127.0.0.1";         //Ip
    string strPort = "1433";            //Port
    string strID = "ParkSangHoon";              //ID
    string strPW = "tjb4048796";
    public DbSet<SatelliteData> myTable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer($@"Data Source=LAPTOP-PG7BFL9M;User ID=ParkSangHoon;Password={strPW};Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<SatelliteData>().ToTable("SatelliteData");
    }
}

class Program
{
    static async Task Main(string[] args)
    {

        using (var db = new DBTESTContext())
        {


            db.myTable.Add(new SatelliteData
            {
                NumberID = 2,
                SatelliteArea = "Korea",
                SatelliteType = "KO",
                FilePath = @"C\FilePath\jdfds.jpg",
                //FileCreateDate = DateTime.Now,
                UserID = "HONG"
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
        //var option = new DbContextOptionsBuilder<SateliteDbContext>()
        //            .UseInMemoryDatabase(databaseName: $"SatelliteData{Guid.NewGuid()}").Options;
        //var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
        //var factory = serviceProvider.GetService<ILoggerFactory>();

        //using (var context = new SateliteDbContext(option))
        //{
        //    context.Database.EnsureCreated(); //데이터 베이스가 만들어져 있는지 확인
        //                                      //[A] Arrange :1 번 데이터를 아래 항목으로 저장
        //    var repository = new SatelliteRepository(context, factory);
        //    var model = new SatelliteData { NumberID = 2, FilePath = @"C\SaveFIle\1.jpg", SatelliteArea = "Korea", UserID = "ParkSangHoon", SatelliteType = "IR" };

        //    //[B] Act : AddAnsync() 메서드 테스트
        //    await repository.AddAsync(model);
        //}

        //using (var context = new SateliteDbContext(option))
        //{
        //    context.Database.EnsureCreated();
        //    var repository = new SatelliteRepository(context, factory);
        //    var allData = await repository.GetAllAsync();
        //    Console.WriteLine("Complete");
        //}
        Console.WriteLine("Complete");
        Console.ReadLine();
    }
}
