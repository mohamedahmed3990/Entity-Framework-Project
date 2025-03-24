using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class StudentCourse
    {
        public int St_Id { get; set; }
        public int Crs_Id { get; set; }
        public int Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
