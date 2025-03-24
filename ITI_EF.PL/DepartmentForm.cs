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
using ITI.EF.DAL;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_EF.PL
{
    public partial class DepartmentForm : Form
    {
        private readonly GenericRepository<Instructor> _instractorRepo;
        private readonly GenericRepository<Department> _departmentRepo;
        private readonly ITIDbContext _dbContext;
        public DepartmentForm()
        {
            _dbContext = new ITIDbContext();
            _instractorRepo = new GenericRepository<Instructor>(_dbContext);
            _departmentRepo = new GenericRepository<Department>(_dbContext);
            InitializeComponent();
        }

        private void deptCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var departments = await _departmentRepo.GetAll();
            deptGrid.DataSource = departments;
            deptCompo.DataSource = departments;
            deptCompo.DisplayMember = "DeptName";
            deptCompo.ValueMember = "DeptId";

            var instructor = await _instractorRepo.GetAll();
            managerCompo.DataSource = instructor;
            managerCompo.DisplayMember = "Ins_Name";
            managerCompo.ValueMember = "Ins_Id";


        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var department = new Department
            {
                DeptName = dnameLbl.Text,
                DeptDesc = ddescLbl.Text,
                DeptLocation = dlocLbl.Text,
                ManagerId = (int?)managerCompo.SelectedValue
            };

            await _departmentRepo.Add(department);

            GridView();
            Clear();


        }

        private void Clear()
        {
            dnameLbl.Clear();
            ddescLbl.Clear();
            dlocLbl.Clear();
            managerCompo.SelectedIndex = -1;
        }

        private async void GridView()
        {

            var departments = await _departmentRepo.GetAll();
            deptGrid.DataSource = departments;
        }

        private async void deptCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptCompo.SelectedValue != null)
            {
                if (int.TryParse(deptCompo.SelectedValue.ToString(), out int deptId))
                {
                    var department = await _departmentRepo.GetById(deptId);

                    if (department != null)
                    {
                        dIdLbl.Text = department.DeptId.ToString();
                        dnameLbl.Text = department.DeptName;
                        ddescLbl.Text = department.DeptDesc;
                        dlocLbl.Text = department.DeptLocation;
                    }
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var deptId = int.Parse(dIdLbl.Text);
            var department = await _departmentRepo.GetById(deptId);

            if (department != null)
            {
                department.DeptName = dnameLbl.Text;
                department.DeptDesc = ddescLbl.Text;
                department.DeptLocation = dlocLbl.Text;
                department.ManagerId = (int?)managerCompo.SelectedValue;

                await _departmentRepo.Update(department);

                GridView();
                Clear();

            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var deptId = int.Parse(dIdLbl.Text);

            await _departmentRepo.Delete(deptId);
            GridView();
            Clear();

        }
    }
}
