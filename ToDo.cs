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
        private Tasks taskToChange;
        private Operation operation;
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
            gvTasks.Columns[0].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            userTaskTitle = tbTitle.Text;
            userDescription = tbDesc.Text;
            userStatus = Convert.ToInt32(gbOptions.Controls.OfType<RadioButton>()
                                                           .FirstOrDefault(b => b.Checked).Tag);
            var userChoice = MessageBox.Show($"Are you sure to add taks?\n" +
                $"{userTaskTitle} - {userDescription} - {gbOptions.Controls.OfType<RadioButton>().FirstOrDefault(b => b.Checked).Text}",
                "Confirm operation", MessageBoxButtons.YesNo);
            
            if (userChoice == DialogResult.Yes)
            {
                SaveTask();
                ClearAddTextBoxes();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAddTextBoxes();
        }
        private void ClearAddTextBoxes()
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

        private void SetRowToEditDelete()
        {
            var dataToDChange = gvTasks.SelectedRows;

            if (dataToDChange.Count > 1)
            {
                switch (operation)
                {
                    case Operation.Edit:
                        MessageBox.Show("Select only one row to edit.", "Warning!");
                        break;
                    case Operation.Delete:
                        MessageBox.Show("Select only one row to delete.", "Warning!");
                        break;
                    default:
                        break;
                }
                
                ClearEditTextBoxes();
            }
            if (dataToDChange.Count < 1)
            {
                switch (operation)
                {
                    case Operation.Edit:
                        MessageBox.Show("Select one row to edit.", "Warning!");
                        break;
                    case Operation.Delete:
                        MessageBox.Show("Select one row to delete.", "Warning!");
                        break;
                    default:
                        break;
                }
                ClearEditTextBoxes();
            }
            else if (dataToDChange.Count == 1)
            {
                int dataId = Convert.ToInt32(dataToDChange[0].Cells["ID"].Value);
                taskToChange = db.Tasks.Where(t => t.id == dataId).FirstOrDefault();

                switch (operation)
                {
                    case Operation.Edit:
                        EditTask(taskToChange);
                        break;
                    case Operation.Delete:
                        DeleteTask(taskToChange);
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            operation = Operation.Delete;
            SetRowToEditDelete();
            operation = Operation.None;
        }

        private void DeleteTask(Tasks task)
        {
            var userChoice = MessageBox.Show("This operation will delete task, are you sure?", "Warning!", MessageBoxButtons.YesNo);
            
            if (userChoice == DialogResult.Yes)
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
                ShowTasks();
                MessageBox.Show("Task removed form list.", "Success!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            operation = Operation.Edit;
            SetRowToEditDelete();
            operation = Operation.None;
        }

        private void EditTask(Tasks task)
        {
            tbDescEdit.Text = task.description;
            tbTitleEdit.Text = task.task;
            var taskStatus = from t in tasks
                             join s in statuses
                             on t.status_id equals s.id
                             where s.id == task.status_id
                             select s.id;
            cbStatusEdit.SelectedValue = taskStatus.FirstOrDefault();
        }

        private void ClearEditTextBoxes()
        {
            tbDescEdit.Text = String.Empty;
            tbTitleEdit.Text = String.Empty;
            var defaultStatus = from s in statuses
                                where s.status.Contains("done")
                                select s.id;
            cbStatusEdit.SelectedValue = defaultStatus.FirstOrDefault();
        }

        private void btnClearEdit_Click(object sender, EventArgs e)
        {
            ClearEditTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            taskToChange.task = tbTitleEdit.Text;
            taskToChange.description = tbDescEdit.Text;
            taskToChange.status_id = (int)cbStatusEdit.SelectedValue;
            db.SaveChanges();
            ClearEditTextBoxes();
            ShowTasks();
        }
    }
}
