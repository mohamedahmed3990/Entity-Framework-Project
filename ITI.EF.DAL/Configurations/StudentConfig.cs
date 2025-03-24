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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.St_Id);
            builder.Property(s => s.St_Id).UseIdentityColumn();

            builder.Property(s => s.St_Fname)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(s => s.St_Lname)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(s => s.St_Address)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DeptId); 

            builder.HasOne(s => s.St_Super)
                .WithMany(super => super.SupervisedStudents)
                .HasForeignKey(s => s.SuperId)
                .IsRequired(false);
            
                


        }
    }
}
