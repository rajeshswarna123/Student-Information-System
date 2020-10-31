using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Data.Configurations
{
    public class MarksConfiguration : IEntityTypeConfiguration<Marks>
    {
        public MarksConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Marks> builder)
        {
            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
