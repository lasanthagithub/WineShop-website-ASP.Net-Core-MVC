using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WineShop.Models;

namespace WineShop.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Let entity framework know, these classes needs to be converted to db tables
        public DbSet<Winery> Winery { get; set; }
        public DbSet<Wine> Wine { get; set; }

        // Note: Property names for collections are typically plural
        // Following codes to override the default behavior by specifying 
        // singular table names in the DbContext.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wine>().ToTable("Wine");
            modelBuilder.Entity<Winery>().ToTable("Winery");

        }

        // Followings are other posibilities/methods

        //using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
        //public class ApplicationDbContext : IdentityDbContext
        //{
        //    protected override void OnModelCreating(ModelBuilder builder)
        //    {
        //        base.OnModelCreating(builder);
        //    }

        //    // Let entity framework know, these classes needs to be converted to db tables
        //    public DbSet<Winery> Winery { get; set; }
        //    public DbSet<Wine> Wine { get; set; }
        //}


        //public class MyContext : IdentityDbContext
        //{
        //    public MyContext()
        //        : base("DefaultConnection")
        //    {
        //    }
        //    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //    public DbSet<Answer> Answers { get; set; }

        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);
        //        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    }
        //}


        //public class SakilaDbContextFactory
        //{
        //    public static SakilaDbContext Create(string connectionString)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<SakilaDbContext>();
        //        optionsBuilder.UseMySQL(connectionString);
        //        var sakilaDbContext = new SakilaDbContext(optionsBuilder.Options);
        //        return sakilaDbContext;
        //    }
        //}
    }
}
