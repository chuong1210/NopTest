
using AppWeb.Model;
using Microsoft.EntityFrameworkCore;


namespace api_be.Infrastructure.DB
{
    public interface ISupermarketDbContext
    {
        DbSet<User> Users { get; }

      

    }
}
