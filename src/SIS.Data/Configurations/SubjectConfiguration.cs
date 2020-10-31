using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
