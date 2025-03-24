using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public string DeptDesc{ get; set; }

        public string DeptLocation { get; set; }

        public int? ManagerId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}
