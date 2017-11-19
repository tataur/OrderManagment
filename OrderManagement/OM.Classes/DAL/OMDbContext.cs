using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OM.Classes.DAL
{
    public class OMDbContext : DbContext
    {
        public OMDbContext() : base("OrderManagement") { }

        public OMDbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
