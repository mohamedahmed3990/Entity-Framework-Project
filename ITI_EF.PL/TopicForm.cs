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
    public partial class TopicForm : Form
    {
        private readonly GenericRepository<Topic> _topicRepo;
        private readonly ITIDbContext _dbContext;
        public TopicForm()
        {
            _dbContext = new ITIDbContext();
            _topicRepo = new GenericRepository<Topic>(_dbContext);
            InitializeComponent();
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            var topics = await _topicRepo.GetAll();
            topicGrid.DataSource = topics;
            topicCompo.DataSource = topics;
            topicCompo.DisplayMember = "TopicName";
            topicCompo.ValueMember = "Id";
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var topic = new Topic
            {
                TopicName = topicNameLbl.Text
            };

            await _topicRepo.Add(topic);
            GridView();
            Clear();
        }
        private async void GridView()
        {
            var topics = await _topicRepo.GetAll();
            topicGrid.DataSource = topics;
        }

        private void Clear()
        {
            tIdLbl.Clear();
            topicNameLbl.Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var topicId = int.Parse(tIdLbl.Text);
            var topics = await _topicRepo.GetById(topicId);

            if (topics != null)
            {
                topics.TopicName = topicNameLbl.Text;

                await _topicRepo.Update(topics);
                GridView();
                Clear();
            }
        }

        private async void delBtn_Click(object sender, EventArgs e)
        {
            var tid = int.Parse(tIdLbl.Text);
            await _topicRepo.Delete(tid);
            GridView();
            Clear();
        }

        private void deptCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void topicCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topicCompo.SelectedValue != null)
            {
                if (int.TryParse(topicCompo.SelectedValue.ToString(), out int tid))
                {
                    var topic = await _topicRepo.GetById(tid);

                    if (topic != null)
                    {
                        tIdLbl.Text = topic.Id.ToString();
                        topicNameLbl.Text = topic.TopicName;
                   
                    }
                }
            }
        }
    }
}
