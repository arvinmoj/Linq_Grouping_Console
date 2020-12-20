using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(connectionString: "Password=!1q2w3e!;Persist Security Info=True;User ID=SA; Initial Catalog = ReportDb; Data Source=185.141.105.156\\SQLSERVER");
        }

        public DbSet<Models.GetData> GetDatas { get; set; }
        
    }
}