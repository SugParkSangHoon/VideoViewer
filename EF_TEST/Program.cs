using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

//public class CameraData
//{
//    [Key]
//    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//    public int NumberID { get; set; }
//    [StringLength(50)]
//    public string CameraType { get; set; }
//    [StringLength(50)]
//    public string CameraArea { get; set; }

//    public DateTime FileCreateDate { get; set; }
//    [StringLength(255)]
//    public string FilePath { get; set; }
//    [StringLength(50)]
//    public string USERS { get; set; }
//}
//public class VideoContext : DbContext
//{
//    public DbSet<CameraData> myTable { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Data Source=LAPTOP-PG7BFL9M\\SQLEXPRESS01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<CameraData>().ToTable("CameraData");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        using (var db = new VideoContext())
//        {
//            db.myTable.Add(new CameraData
//            {
//                NumberID = 3,
//                CameraArea = "Korea",
//                CameraType = "IKR",
//                FilePath = @"C\FilePath\jdfds.jpg",
//                FileCreateDate = DateTime.Now,
//                USERS ="PARK SANG HOON"
//            });
//            try
//            {
//                db.SaveChanges();
//            }
//            catch (DbUpdateException ex)
//            {
//                if (ex.InnerException != null && ex.InnerException.InnerException != null)
//                {
//                    // Log the innermost exception message
//                    Console.WriteLine(ex.InnerException.InnerException.Message);
//                }
//                else
//                {
//                    // Log the exception message
//                    Console.WriteLine(ex.Message);
//                }
//            }
//        }
//        Console.WriteLine("Complete");
//        Console.ReadLine();
//    }
//}
public class Customer
{
#nullable enable
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
#nullable disable
    public ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime? OrderFulfilled { get; set; }
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
    public ICollection<ProductOrder> ProductOrders { get; set; }
}

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}

public class ProductOrder
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
}
public class ContosoPetsContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //셈플이기 때문에 여기에 connection string을 입력
        optionsBuilder.UseSqlServer("Data Source=LAPTOP-PG7BFL9M\\SQLEXPRESS01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
class Program
{
    static void Main(string[] args)
    {
        using ContosoPetsContext context = new ContosoPetsContext();

        Product squeakyBone = new Product()
        {
            Name = "Squeaky Dog Bone",
            Price = 4.99M
        };
        //레코드 추가 방법1
        context.Products.Add(squeakyBone);

        Product tennisBalls = new Product()
        {
            Name = "Tennis Ball 3-Pack",
            Price = 9.99M
        };
        //레코드 추가 방법2
        context.Add(tennisBalls);

        context.SaveChanges();
    }
}