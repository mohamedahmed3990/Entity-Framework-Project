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

namespace ITI_EF.PL
{
    public partial class InstructorForm : Form
    {
        private readonly ITIDbContext _dbContext;
        private readonly GenericRepository<Instructor> _instructorRepo;

        public InstructorForm()
        {
            _dbContext = new ITIDbContext();
            _instructorRepo = new GenericRepository<Instructor>(_dbContext);
            InitializeComponent();
        }




        private async void GridView()
        {
            var instructors = await _instructorRepo.GetAll();
            instructorGrid.DataSource = instructors;
        }

        private void Clear()
        {
            idLbl.Clear();
            nameLbl.Clear();
            degreeLbl.Clear();
            salaryLbl.Clear();
        }



        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var instructors = await _instructorRepo.GetAll();
            instructorGrid.DataSource = instructors;
            instructorCompo.DataSource = instructors;
            instructorCompo.DisplayMember = "Ins_Name";
            instructorCompo.ValueMember = "Ins_Id";

        }

        private async void instructorCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorCompo.SelectedValue != null)
            {
                if (int.TryParse(instructorCompo.SelectedValue.ToString(), out int insId))
                {
                    var instructor = await _instructorRepo.GetById(insId);

                    if (instructor != null)
                    {
                        idLbl.Text = instructor.Ins_Id.ToString();
                        nameLbl.Text = instructor.Ins_Name;
                        degreeLbl.Text = instructor.Ins_Degree;
                        salaryLbl.Text = instructor.Salary.ToString();
                    }
                }
            }
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor
            {
                Ins_Name = nameLbl.Text,
                Ins_Degree = degreeLbl.Text,
                Salary = decimal.Parse(salaryLbl.Text)
            };

            await _instructorRepo.Add(instructor);
            GridView();
            Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var insId = int.Parse(idLbl.Text);
            var instructor = await _instructorRepo.GetById(insId);

            if (instructor != null)
            {
                instructor.Ins_Name = nameLbl.Text;
                instructor.Ins_Degree = degreeLbl.Text;
                instructor.Salary = decimal.Parse(salaryLbl.Text);

                await _instructorRepo.Update(instructor);
                GridView();
                Clear();
            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var insId = int.Parse(idLbl.Text);
            await _instructorRepo.Delete(insId);
            GridView();
            Clear();
        }

        private void deptCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
