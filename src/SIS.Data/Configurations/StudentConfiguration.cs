using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS.Entities;

namespace SIS.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
