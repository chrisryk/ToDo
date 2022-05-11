using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ToDo
{
    public partial class ToDo : Form
    {
        private ToDoEntities db;
        private IList<Tasks> tasks;
        private IList<Statuses> statuses;
        private string userTaskTitle;
        private string userDescription;
        private int userStatus;
        public ToDo()
        {
            InitializeComponent();
            db = new ToDoEntities();
        }
        private void ToDo_Load(object sender, EventArgs e)
        {
            GetData();
            cbStatusEdit.DisplayMember = "status";
            cbStatusEdit.ValueMember = "id";
            cbStatusEdit.DataSource = statuses;
        }
        private void GetData()
        {
            tasks = db.Tasks.ToList();
            statuses = db.Statuses.ToList();
        }
        private void btnShowTasks_Click(object sender, EventArgs e)
        {
            ShowTasks();
        }
        private void ShowTasks()
        {
            GetData();
            var data = from t in tasks
                       from s in statuses
                       where t.status_id == s.id
                       select new { ID = t.id, TITLE = t.task, DESCRIPTION = t.description, STATUS = s.status };

            gvTasks.DataSource = data.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            userTaskTitle = tbTitle.Text;
            userDescription = tbDesc.Text;
            userStatus = Convert.ToInt32(gbOptions.Controls.OfType<RadioButton>()
                                                           .FirstOrDefault(b => b.Checked).Tag);
            var result = MessageBox.Show($"Are you sure to add taks?\n" +
                $"{userTaskTitle} - {userDescription} - {gbOptions.Controls.OfType<RadioButton>().FirstOrDefault(b => b.Checked).Text}",
                "Confirm operation", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                SaveTask();
                ShowTasks();
            }
        }

        private void SaveTask()
        {
            Tasks task = new Tasks();
            task.task = userTaskTitle;
            task.description = userDescription;
            task.status_id = userStatus;

            db.Tasks.Add(task);
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTitle.Text = String.Empty;
            tbDesc.Text = String.Empty;
            var buttons = gbOptions.Controls.OfType<RadioButton>();
            foreach (var button in buttons)
            {
                button.Checked = false;
            }
            radioPending.Checked = true;
        }
    }
}
