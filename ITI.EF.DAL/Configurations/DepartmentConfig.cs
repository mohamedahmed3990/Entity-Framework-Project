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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DeptId);
            builder.Property(d => d.DeptId)
                .UseIdentityColumn(10,10);

            builder.Property(d => d.DeptName)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(d => d.DeptDesc)
                .HasColumnType("varchar(100)")
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(d => d.DeptLocation)
                .IsRequired(false)
                .HasColumnType("varchar(50)");


            builder.HasOne(d => d.Instructor)
                .WithOne(i => i.ManageDepartment)
                .HasForeignKey<Department>(d => d.ManagerId)
                .IsRequired(false);
                
        }
    }
}
