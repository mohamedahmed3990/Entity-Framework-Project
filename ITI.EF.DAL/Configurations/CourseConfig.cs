using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITI.EF.DAL.Configurations
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Crs_Id);
            builder.Property(c => c.Crs_Id).UseIdentityColumn(100, 100);

            builder.Property(c => c.Crs_Name)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TopicId)
                .IsRequired(false);

            
        }
    }
}
