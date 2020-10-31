using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public ClassConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
