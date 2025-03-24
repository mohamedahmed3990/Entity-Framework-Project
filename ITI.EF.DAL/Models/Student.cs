using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class Student
    {
        public int St_Id { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_Address { get; set; }
        public int St_Age { get; set; }

        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

        public int? SuperId { get; set; }

        public virtual Student St_Super { get; set; }

        public virtual ICollection<Student> SupervisedStudents { get; set; } = new HashSet<Student>();

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();


    }
}
