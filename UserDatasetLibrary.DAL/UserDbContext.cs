using Microsoft.EntityFrameworkCore;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL
{
    public sealed class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<FotoEntity> Fotos { get; set; }
       
    }
}
