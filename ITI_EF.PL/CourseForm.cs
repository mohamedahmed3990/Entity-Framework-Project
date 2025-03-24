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
    public partial class CourseForm : Form
    {
        private ITIDbContext _dbContext;
        private GenericRepository<Course> _courseRepo;
        private GenericRepository<Topic> _topicRepo;

        public CourseForm()
        {
            _dbContext = new ITIDbContext();
            _courseRepo = new GenericRepository<Course>(_dbContext);
            _topicRepo = new GenericRepository<Topic>(_dbContext);
            InitializeComponent();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var courses = await _courseRepo.GetAll();
            courseGrid.DataSource = courses;
            courseCompo.DataSource = courses;
            courseCompo.DisplayMember = "Crs_Name";
            courseCompo.ValueMember = "Crs_Id";

            var topics = await _topicRepo.GetAll();
            topicCompo.DataSource = topics;
            topicCompo.DisplayMember = "TopicName";
            topicCompo.ValueMember = "Id";
        }

        private async void courseCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseCompo.SelectedValue != null)
            {
                if (int.TryParse(courseCompo.SelectedValue.ToString(), out int cid))
                {
                    var courses = await _courseRepo.GetById(cid);

                    if (courses != null)
                    {

                        cIdLbl.Text = courses.Crs_Id.ToString();
                        cnameLbl.Text = courses.Crs_Name;
                        durLbl.Text = courses.Crs_Duration.ToString();
                    }
                }
            }
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                Crs_Name = cnameLbl.Text,
                Crs_Duration = int.Parse(durLbl.Text),
                TopicId = (int?)topicCompo.SelectedValue
            };

            await _courseRepo.Add(course);

            GridView();
            Clear();
        }

        private void Clear()
        {
            cIdLbl.Clear();
            cnameLbl.Clear();
            durLbl.Clear();
            topicCompo.SelectedIndex = -1;
        }

        private async void GridView()
        {
            var course = await _courseRepo.GetAll();
            courseGrid.DataSource = course;
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var cid = int.Parse(cIdLbl.Text);
            var course = await _courseRepo.GetById(cid);

            if (course != null)
            {
                course.Crs_Name = cnameLbl.Text;
                course.Crs_Duration = int.Parse(durLbl.Text);
                course.TopicId = (int?)topicCompo.SelectedValue;

                await _courseRepo.Update(course);

                GridView();
                Clear();

            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var cid = int.Parse(cIdLbl.Text);

            await _courseRepo.Delete(cid);
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
    }
}
