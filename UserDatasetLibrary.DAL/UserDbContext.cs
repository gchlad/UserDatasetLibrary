using Microsoft.EntityFrameworkCore;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL
{
    public sealed class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<FotoEntity> Fotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: figure out why configurations do not apply
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
