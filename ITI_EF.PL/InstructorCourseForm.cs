using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.EF.DAL.Models;
using ITI.EF.DAL;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkLab2.Context;

namespace ITI_EF.PL
{
    public partial class InstructorCourseForm : Form
    {
        private readonly ITIDbContext _dbContext;
        private readonly InstructorCourseRepository _instructorCourseRepo;
        private readonly GenericRepository<Instructor> _instructorRepo;
        private readonly GenericRepository<Course> _courseRepo;
        public InstructorCourseForm()
        {
            _dbContext = new ITIDbContext();
            _instructorCourseRepo = new InstructorCourseRepository(_dbContext);
            _instructorRepo = new GenericRepository<Instructor>(_dbContext);
            _courseRepo = new GenericRepository<Course>(_dbContext);
            InitializeComponent();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var instructorCourses = await _instructorCourseRepo.GetAll();
            instructorCourseGrid.DataSource = instructorCourses;

            var instructors = await _instructorRepo.GetAll();
            instructorCompo.DataSource = instructors;
            instructorCompo.DisplayMember = "Ins_Name";
            instructorCompo.ValueMember = "Ins_Id";

            var courses = await _courseRepo.GetAll();
            courseCompo.DataSource = courses;
            courseCompo.DisplayMember = "Crs_Name";
            courseCompo.ValueMember = "Crs_Id";
        }

        private async void GridView()
        {
            var instructorCourses = await _instructorCourseRepo.GetAll();
            instructorCourseGrid.DataSource = instructorCourses;
        }

        private void Clear()
        {
            evalLbl.Clear();
            instructorCompo.SelectedIndex = -1;
            courseCompo.SelectedIndex = -1;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var instructorCourse = new InstructorCourse
            {
                Ins_Id = (int)instructorCompo.SelectedValue,
                Crs_Id = (int)courseCompo.SelectedValue,
                Evaluation = evalLbl.Text
            };

            await _instructorCourseRepo.Add(instructorCourse);
            GridView();
            Clear();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deptCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var instructorId = (int)instructorCompo.SelectedValue;
            var courseId = (int)courseCompo.SelectedValue;
            var InsCourse = await _instructorCourseRepo.GetByInsCourse(instructorId, courseId);

            if (InsCourse != null)
            {
                InsCourse.Evaluation = evalLbl.Text;
                await _instructorCourseRepo.Update(InsCourse);
                GridView();
                Clear();
            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var insId = (int)instructorCompo.SelectedValue;
            var courseId = (int)courseCompo.SelectedValue;
            await _instructorCourseRepo.DeleteComposite(insId, courseId);
            GridView();
            Clear();
        }
    }
}
