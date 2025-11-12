using AppWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppWeb
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            

            builder.HasKey(u => u.Id);
            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd(); 
      

            builder.Property(u => u.Name).HasMaxLength(255);
            builder.Property(u => u.Phone).HasMaxLength(255);

            builder.Property(u => u.Password).HasMaxLength(255);
            builder.Property(u => u.Email).HasMaxLength(255);
            builder.Property(u => u.Password).HasMaxLength(255);
            builder.Property(u => u.Avatar).HasMaxLength(255);





        }
    }
}
