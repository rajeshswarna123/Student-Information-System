using Microsoft.EntityFrameworkCore;
using SIS.Entities;

namespace SIS.Data.Configurations
{
    public class SISDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassCurriculum> ClassCurricula { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }


        public SISDBContext(DbContextOptions<SISDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .ApplyConfiguration(new UserConfiguration());
            builder
                .ApplyConfiguration(new ClassConfiguration());
            builder
                .ApplyConfiguration(new ClassCurriculumConfiguration());
            builder
                .ApplyConfiguration(new MarksConfiguration());
            builder
                .ApplyConfiguration(new StudentConfiguration());
            builder
                .ApplyConfiguration(new SubjectConfiguration());

            builder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}
