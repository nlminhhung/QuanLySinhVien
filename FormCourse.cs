using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLySinhVien.firstDBDataSet1;

namespace QuanLySinhVien
{
    public partial class FormCourse : Form
    {
        int TEACHER_ROW_INDEX = -1;
        public FormCourse()
        {
            InitializeComponent();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firstDBDataSet1.Course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter1.Fill(this.firstDBDataSet1.Course);
            dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cb_chosenTeacher"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell chk = row.Cells["cb_chosenTeacher"] as DataGridViewCheckBoxCell;
                        chk.Value = false;
                    }
                }

                DataGridViewCheckBoxCell clickedCheckBox = dataGridView1.Rows[e.RowIndex].Cells["cb_chosenTeacher"] as DataGridViewCheckBoxCell;
                clickedCheckBox.Value = !Convert.ToBoolean(clickedCheckBox.Value);
                TEACHER_ROW_INDEX = e.RowIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int courseYear = int.Parse(tb_courseYear.Text); 
                string courseID = tb_courseID.Text;
                string courseName = tb_courseName.Text;

                if (courseID.Trim() == "") { 
                    MessageBox.Show("courseID is required!");
                    return; 
                }
                if (courseName.Trim() == "") { 
                    MessageBox.Show("courseName is required!"); 
                    return; 
                }
                if (courseYear.GetType() != typeof(int) || courseYear < 0)
                {
                    MessageBox.Show("courseYear is not valid");
                    return;
                }
                DataGridViewRow teacherRow = dataGridView1.Rows[TEACHER_ROW_INDEX];
                string teacherID = teacherRow.Cells[1].Value.ToString();       
                Course course = new Course(courseName, courseID, courseYear, teacherID);
                Modify.ModifyCourse.insertCourse(course);
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cb_chosenCourse"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    Modify.ModifyCourse.deleteCourse(row.Cells[1].Value.ToString());
                }
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Student is not found for delete!");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView2.Rows[e.RowIndex];
                tb_courseID.Text = row.Cells[1].Value.ToString();
                tb_courseName.Text = row.Cells[2].Value.ToString();
                tb_courseYear.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please choose student in viewboard to do this action");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string courseID = tb_courseID.Text;
                string courseName = tb_courseName.Text;
                string year = tb_courseYear.Text;
                int courseYear = int.Parse(year);
                DataGridViewRow teacherRow = dataGridView1.Rows[TEACHER_ROW_INDEX];
                string teacherID = teacherRow.Cells[1].Value.ToString();

                if (courseID.Trim() == "") { MessageBox.Show("courseID is required!"); return; }
                if (courseName.Trim() == "") { MessageBox.Show("courseName is required!"); return; }
                if (year.Trim() == "") { MessageBox.Show("year is required!"); return; }
                Course course = new Course(courseName, courseID, courseYear, teacherID);
                Modify.ModifyCourse.updateCourse(course);
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
                return;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int courseYear = int.Parse(tb_courseYear.Text);
                string courseID = tb_courseID.Text;
                string courseName = tb_courseName.Text;

                if (courseID.Trim() == "")
                {
                    MessageBox.Show("courseID is required!");
                    return;
                }
                if (courseName.Trim() == "")
                {
                    MessageBox.Show("courseName is required!");
                    return;
                }
                if (courseYear.GetType() != typeof(int) || courseYear < 0)
                {
                    MessageBox.Show("courseYear is not valid");
                    return;
                }
                DataGridViewRow teacherRow = dataGridView1.Rows[TEACHER_ROW_INDEX];
                string teacherID = teacherRow.Cells[1].Value.ToString();
                Course course = new Course(courseName, courseID, courseYear, teacherID);
                Modify.ModifyCourse.insertCourse(course);
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string courseID = tb_courseID.Text;
                string courseName = tb_courseName.Text;
                string year = tb_courseYear.Text;
                int courseYear = int.Parse(year);
                DataGridViewRow teacherRow = dataGridView1.Rows[TEACHER_ROW_INDEX];
                string teacherID = teacherRow.Cells[1].Value.ToString();

                if (courseID.Trim() == "") { MessageBox.Show("courseID is required!"); return; }
                if (courseName.Trim() == "") { MessageBox.Show("courseName is required!"); return; }
                if (year.Trim() == "") { MessageBox.Show("year is required!"); return; }
                Course course = new Course(courseName, courseID, courseYear, teacherID);
                Modify.ModifyCourse.updateCourse(course);
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
                return;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cb_chosenCourse"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    Modify.ModifyCourse.deleteCourse(row.Cells[1].Value.ToString());
                }
                dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Student is not found for delete!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
