using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_TEST
{
    public class SateliteDbContext : DbContext
    {
        ///PM> Install-Package Microsoft.EntityFrameworkCore
        ///PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer
        ///PM> Install-Package Microsoft.EntityFrameworkCore.Tools
        ///PM> Install-Package Microsoft.EntityFrameworkCore.InMemory
        ///PM> Install-Package System.ConfigurationManager
        ///PM> Install-Package Microsoft.Data.SqlClient
        ///PM> Install-Package Dul

        public SateliteDbContext()
        {

        }
        public SateliteDbContext(DbContextOptions<SateliteDbContext> options) 
            :base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //string connectionString = ConfigurationManager.ConnectionStrings
                //    ["ConnectionString"].ConnectionString;
                //string connectionString = @"Server = (localdb)\\mssqllocaldb; Database = SatelliteApp; Trusted_Connection = True;";
                string connectionString = $@"Data Source=LAPTOP-PG7BFL9M;User ID=ParkSangHoon;Password=tjb4048796;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        /// <summary>
        /// 만약 날자 모델이 있으며 그값이 자동으로 들어가도록 하자 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 테이블의 DateTime 컬럼은 자동으로 GetData() 제약 빌더를 부여하기
            modelBuilder.Entity<SatelliteData>().Property(m => m.FileCreateDate).HasDefaultValueSql("GetDate()");
        }
        //[!] 현제 모든 테이블의대한참조
        public DbSet<SatelliteData> SatelliteDatas { get; set; }
    }
}
