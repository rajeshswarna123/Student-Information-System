using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS.Entities;

namespace SIS.Data.Configurations
{
    public class ClassCurriculumConfiguration : IEntityTypeConfiguration<ClassCurriculum>
    {
        public ClassCurriculumConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<ClassCurriculum> builder)
        {
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
