using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class StudentDetailConfiguration : IEntityTypeConfiguration<StudentDetail>
    {
        public void Configure(EntityTypeBuilder<StudentDetail> builder)
        {
            //builder.Property(m => m.Name).IsRequired();


        }
    }
}
