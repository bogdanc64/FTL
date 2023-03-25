using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Traveloo.Api.Core.Controllers;

namespace Traveloo.Sql.Library
{
    public class DbContext : IdentityDbContext
    {
        //Db Sets
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //Local connection string as default
        public string ConnectionString = "Server=.;Database=SmartyHomeDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=true;TrustServerCertificate=True;";

        //Empty constructor required for running "dotnet ef" commands locally
        public DbContext() { }

        public DbContext(DbContextOptions<DbContext> options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            if (!options.IsConfigured)
                _ = options.UseSqlServer(ConnectionString);
        }

    }
}
