using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Models;

namespace 영상뷰어.Services.DataBase
{
    public class UserDataDbContext : DbContext
    {
        public UserDataDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string connectionString = ConfigurationManager.ConnectionStrings
                //    ["ConnectionString"].ConnectionString;
                //string connectionString = "Data Source=LAPTOP-PG7BFL9M;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                string connectionString = "Server=127.0.0.1; Database=SateliteApp; uid=ParkSangHoon; pwd=tjb4048796;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 테이블의 DateTime 컬럼은 자동으로 GetData() 제약 빌더를 부여하기
            modelBuilder.Entity<UserData>().Property(m => m.JoinDatetime).HasDefaultValueSql("GetDate()");
        }

        public DbSet<UserData> UserDatas { get; set; }
    }
}
