using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkLab2.Configurations
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Ins_Id);
            builder.Property(i => i.Ins_Name)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(i => i.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(i => i.Ins_Degree)
                .IsRequired(false)
                .HasColumnType("varchar(50)");
        }
    }
}
