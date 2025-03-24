using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkLab2.Context;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI.EF.DAL
{
    public class StudentCourseRepository : GenericRepository<StudentCourse>
    {

        public StudentCourseRepository(ITIDbContext dbContext):base(dbContext)
        {
        }

        public async Task<StudentCourse?> GetByStudentAndCourseAsync(int studentId, int courseId)
        {
            return await _dbContext.StudentCourses.FirstOrDefaultAsync(sc => sc.St_Id == studentId && sc.Crs_Id == courseId);
        }
        public async Task DeleteComposite(int studentId, int courseId)
        {
            var stCr =  await _dbContext.StudentCourses.FirstOrDefaultAsync(sc => sc.St_Id == studentId && sc.Crs_Id == courseId);

            if (stCr != null)
            {
                _dbContext.StudentCourses.Remove(stCr);
                await _dbContext.SaveChangesAsync();
            }
        }


    }
}
