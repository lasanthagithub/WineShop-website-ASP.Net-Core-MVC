using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace WineShop.Models
{

    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        // Let entity framework know, these classes needs to be converted to db tables
        public DbSet<Winery> Winery { get; set; }
        public DbSet<Wine> Wine { get; set; }
    }


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




    //public class DatabaseAccess : DbContext
    //{
    //    public SakilaDbContext(DbContextOptions<SakilaDbContext> options)
    //        : base(options)
    //    {

    //    }

    //    public DbSet<Film> Film { get; set; }

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
