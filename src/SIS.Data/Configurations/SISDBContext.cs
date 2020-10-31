using Microsoft.EntityFrameworkCore;
using SIS.Entities;

namespace SIS.Data.Configurations
{
    public class SISDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SISDBContext(DbContextOptions<SISDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .ApplyConfiguration(new UserConfiguration());

            builder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}
