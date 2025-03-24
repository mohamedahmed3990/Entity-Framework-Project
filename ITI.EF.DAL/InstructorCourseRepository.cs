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
    public class InstructorCourseRepository : GenericRepository<InstructorCourse>
    {
        public InstructorCourseRepository(ITIDbContext dbContext):base(dbContext)
        {
            
        }

        public async Task<InstructorCourse?> GetByInsCourse(int insId, int courseId)
        {
            return await _dbContext.InstructorCourses.FirstOrDefaultAsync(ic => ic.Ins_Id == insId && ic.Crs_Id == courseId);
        }

        public async Task DeleteComposite(int insId, int courseId)
        {
            var insCrs = await _dbContext.InstructorCourses.FirstOrDefaultAsync(ic => ic.Ins_Id == insId && ic.Crs_Id == courseId);

            if (insCrs != null)
            {
                _dbContext.InstructorCourses.Remove(insCrs);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
