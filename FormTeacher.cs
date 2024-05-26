using QuanLySinhVien.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'firstDBDataSet3.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter1.Fill(this.firstDBDataSet3.Teacher);
            //// TODO: This line of code loads data into the 'firstDBDataSet1.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter.Fill(this.firstDBDataSet1.Teacher);
            dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherID = tb_teacherID.Text;
                string name = tb_name.Text;
                string address = tb_address.Text;

                if (teacherID.Trim() == "") { MessageBox.Show("ID field is required!"); return; }
                if (name.Trim() == "") { MessageBox.Show("Name field is required!"); return; }
                if (address.Trim() == "") { MessageBox.Show("Address field is required!"); return; }
                Teacher teacher = new Teacher(name, teacherID, address);

                Modify.ModifyTeacher.insertTeacher(teacher);
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Teacher ID existed!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete by checkbox
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cb_chosenTeacher"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    Modify.ModifyTeacher.deleteTeacher(row.Cells[1].Value.ToString());
                }
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Can not find selected teacher!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherID = tb_teacherID.Text;
                string name = tb_name.Text;
                string address = tb_address.Text;
                if (teacherID.Trim() == "") { MessageBox.Show("ID field is required!"); return; }
                if (name.Trim() == "") { MessageBox.Show("Name field is required!"); return; }
                if (address.Trim() == "") { MessageBox.Show("Address field is required!!"); return; }
                Teacher teacher = new Teacher(name, teacherID, address);

                Modify.ModifyTeacher.updateTeacher(teacher);
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Can not find selected teacher!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];

                tb_teacherID.Text = row.Cells[1].Value.ToString();
                tb_name.Text = row.Cells[2].Value.ToString();
                tb_address.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please click on the cell");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherID = tb_teacherID.Text;
                string name = tb_name.Text;
                string address = tb_address.Text;

                if (teacherID.Trim() == "") { MessageBox.Show("ID field is required!"); return; }
                if (name.Trim() == "") { MessageBox.Show("Name field is required!"); return; }
                if (address.Trim() == "") { MessageBox.Show("Address field is required!"); return; }
                Teacher teacher = new Teacher(name, teacherID, address);

                Modify.ModifyTeacher.insertTeacher(teacher);
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Teacher ID existed!");
                return;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // delete by checkbox
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cb_chosenTeacher"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    Modify.ModifyTeacher.deleteTeacher(row.Cells[1].Value.ToString());
                }
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Can not find selected teacher!");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherID = tb_teacherID.Text;
                string name = tb_name.Text;
                string address = tb_address.Text;
                if (teacherID.Trim() == "") { MessageBox.Show("ID field is required!"); return; }
                if (name.Trim() == "") { MessageBox.Show("Name field is required!"); return; }
                if (address.Trim() == "") { MessageBox.Show("Address field is required!!"); return; }
                Teacher teacher = new Teacher(name, teacherID, address);

                Modify.ModifyTeacher.updateTeacher(teacher);
                dataGridView1.DataSource = Modify.ModifyTeacher.getAllTeacher();
            }
            catch
            {
                MessageBox.Show("Can not find selected teacher!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
