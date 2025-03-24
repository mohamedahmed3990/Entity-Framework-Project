using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkLab2.Context;
using ITI.EF.DAL.Models;
using ITI.EF.DAL;
using Microsoft.EntityFrameworkCore;

namespace ITI_EF.PL
{
    public partial class StudentCourseForm : Form
    {
        private readonly ITIDbContext _dbContext;
        private readonly StudentCourseRepository _studentCourseRepo;
        private readonly GenericRepository<Student> _studentRepo;
        private readonly GenericRepository<Course> _courseRepo;
        public StudentCourseForm()
        {
            _dbContext = new ITIDbContext();
            _studentCourseRepo = new StudentCourseRepository(_dbContext);
            _studentRepo = new GenericRepository<Student>(_dbContext);
            _courseRepo = new GenericRepository<Course>(_dbContext);
            InitializeComponent();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var studentCourses = await _studentCourseRepo.GetAll();
            studentCourseGrid.DataSource = studentCourses;

            var students = await _studentRepo.GetAll();
            studentCompo.DataSource = students;
            studentCompo.DisplayMember = "St_Fname";
            studentCompo.ValueMember = "St_Id";

            var courses = await _courseRepo.GetAll();
            courseCompo.DataSource = courses;
            courseCompo.DisplayMember = "Crs_Name";
            courseCompo.ValueMember = "Crs_Id";
        }



        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var studentId = (int)studentCompo.SelectedValue;
            var courseId = (int)courseCompo.SelectedValue;
            var studentCourse = await _studentCourseRepo.GetByStudentAndCourseAsync(studentId, courseId);

            if (studentCourse != null)
            {
                studentCourse.Grade = int.Parse(gradeLbl.Text);
                await _studentCourseRepo.Update(studentCourse);
                GridView();
                Clear();
            }
        }

        private async void GridView()
        {
            var studentCourses = await _studentCourseRepo.GetAll();
            studentCourseGrid.DataSource = studentCourses;
        }

        private void Clear()
        {
            gradeLbl.Clear();
            studentCompo.SelectedIndex = -1;
            courseCompo.SelectedIndex = -1;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var studentId = (int)studentCompo.SelectedValue;
            var courseId = (int)courseCompo.SelectedValue;
            await _studentCourseRepo.DeleteComposite(studentId, courseId);
            GridView();
            Clear();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var studentCourse = new StudentCourse
            {
                St_Id = (int)studentCompo.SelectedValue,
                Crs_Id = (int)courseCompo.SelectedValue,
                Grade = int.Parse(gradeLbl.Text)
            };

            await _studentCourseRepo.Add(studentCourse);
            GridView();
            Clear();
        }

        private void deptCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
