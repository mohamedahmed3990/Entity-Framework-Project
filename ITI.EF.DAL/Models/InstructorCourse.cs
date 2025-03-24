using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class InstructorCourse
    {
        public int Ins_Id { get; set; }
        public int Crs_Id { get; set; }

        public string? Evaluation { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Course Course { get; set; }

    }
}
