using System.ComponentModel;
using System.Xml.Linq;
using EntityFrameworkLab2.Context;
using ITI.EF.DAL;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_EF.PL
{
    public partial class Form1 : Form
    {
        private readonly GenericRepository<Student> _studentRepo;
        private readonly GenericRepository<Department> _departmentRepo;
        private readonly ITIDbContext _dbContext;
        public Form1()
        {
            _dbContext = new ITIDbContext();
            _studentRepo = new GenericRepository<Student>(_dbContext);
            _departmentRepo = new GenericRepository<Department>(_dbContext);
            InitializeComponent();
        }



        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var students = await _studentRepo.GetAll();
            fillStud.DataSource = students;
            fillStud.DisplayMember = "St_Fname";
            fillStud.ValueMember = "St_Id";
            studGrid.DataSource = students;
            var departments = await _departmentRepo.GetAll();
            deptCompo.DataSource = departments;
            deptCompo.DisplayMember = "DeptName";
            deptCompo.ValueMember = "DeptId";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                St_Fname = fnameLbl.Text,
                St_Lname = lnameLbl.Text,
                St_Age = int.Parse(ageLbl.Text),
                St_Address = addLbl.Text,
                DeptId = (int)deptCompo.SelectedValue,
            };

            await _studentRepo.Add(student);
            GridView();
        }

        private async void GridView()
        {
            var students = await _studentRepo.GetAll();
            studGrid.DataSource = students;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fnameLbl.Clear();
            lnameLbl.Clear();
            ageLbl.Clear();
            addLbl.Clear();
            deptCompo.SelectedIndex = -1;
        }

        private void deptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm dpetForm = new DepartmentForm();
            dpetForm.ShowDialog();
            this.Show();
        }

        private async void fillStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fillStud.SelectedValue != null)
            {
                if (int.TryParse(fillStud.SelectedValue.ToString(), out int studentId))
                {
                    var student = await _studentRepo.GetById(studentId);

                    if (student != null)
                    {
                        idLbl.Text = student.St_Id.ToString();
                        fnameLbl.Text = student.St_Fname;
                        lnameLbl.Text = student.St_Lname;
                        ageLbl.Text = student.St_Age.ToString();
                        addLbl.Text = student.St_Address;
                        deptCompo.SelectedValue = student.DeptId;

                    }
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var studentId = int.Parse(idLbl.Text);
            var student = await _studentRepo.GetById(studentId);

            if (student != null)
            {
                student.St_Fname = fnameLbl.Text;
                student.St_Lname = lnameLbl.Text;
                student.St_Age = int.Parse(ageLbl.Text);
                student.St_Address = addLbl.Text;

                student.DeptId = (int)deptCompo.SelectedValue;
                await _studentRepo.Update(student);

                GridView();
            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var studentId = int.Parse(idLbl.Text);

            var student = await _studentRepo.GetById(studentId);

            await _studentRepo.Delete(studentId);
            GridView();

        }

        private void CrsBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            CourseForm dpetForm = new CourseForm();
            dpetForm.ShowDialog();
            this.Show();
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorForm dpetForm = new InstructorForm();
            dpetForm.ShowDialog();
            this.Show();
        }

        private void studCrsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCourseForm dpetForm = new StudentCourseForm();
            dpetForm.ShowDialog();
            this.Show();
        }

        private void insCrsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorCourseForm dpetForm = new InstructorCourseForm();
            dpetForm.ShowDialog();
            this.Show();
        }

        private void topicBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopicForm dpetForm = new TopicForm();
            dpetForm.ShowDialog();
            this.Show();
        }
    }
}
