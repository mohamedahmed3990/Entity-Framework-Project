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
    internal class InstructorCourseConfig : IEntityTypeConfiguration<InstructorCourse>
    {
        public void Configure(EntityTypeBuilder<InstructorCourse> builder)
        {
            builder.HasKey(ic => new {ic.Ins_Id, ic.Crs_Id});

            builder.HasOne(ic => ic.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ic => ic.Crs_Id);

            builder.HasOne(ic => ic.Instructor)
                .WithMany(i => i.InstructorCourses)
                .HasForeignKey(ic => ic.Ins_Id);

            builder.Property(ic => ic.Evaluation).IsRequired(false);

        }
    }
}
