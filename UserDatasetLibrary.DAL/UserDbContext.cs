using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL
{
    public sealed class UserDbContext : IdentityDbContext<UsersEntity, IdentityRole<Guid>, Guid>
    {
        /*
        public class GuidDataContext :
        IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
        {
        }*/
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<FotoEntity> Fotos { get; set; }
        //public DbSet<UsersEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}

