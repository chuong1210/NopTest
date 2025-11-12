using AppWeb;
using AppWeb.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace api_be.Infrastructure.DB
{
    public class SupermarketDbContext : DbContext, ISupermarketDbContext
    {

        public SupermarketDbContext(
            DbContextOptions options
            )
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

   


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new UserConfiguration());


            base.OnModelCreating(modelBuilder);
            // Áp dụng cho toàn bộ entity có kiểu decimal
            foreach (var property in modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SupermarketDbContext).Assembly);

            //modelBuilder.ApplyConfiguration(new BaseEntityConfiguration<Role> ());

        }

   

    }
}
