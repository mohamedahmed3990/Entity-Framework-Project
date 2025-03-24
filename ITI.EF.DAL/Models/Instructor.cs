using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class Instructor
    {
        public int Ins_Id { get; set; }

        public string Ins_Name { get; set; }
        public string Ins_Degree { get; set; }
        public decimal Salary { get; set; }

        public virtual Department ManageDepartment { get; set; }

        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    }
}
