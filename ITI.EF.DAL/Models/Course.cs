using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class Course
    {
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }

        public int Crs_Duration { get; set; }

        public int? TopicId { get; set; }
        public Topic Topic { get; set; }

        public virtual ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();

        public virtual ICollection<InstructorCourse> CourseInstructors { get; set; } = new HashSet<InstructorCourse>();
    }
}
