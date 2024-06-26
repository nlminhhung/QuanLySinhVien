﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormScore : Form
    {   
        int STUDENT_ROW_INDEX = -1;
        int COURSE_ROW_INDEX= -1;

        public FormScore()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modify.ModifyStudent.getAllSinhVien();
            dataGridView2.DataSource = Modify.ModifyCourse.getAllCourse();
            bandDiem.DataSource = Modify.ModifyGrade.getAllGrade();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cb_chosenStudent"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell chk = row.Cells["cb_chosenStudent"] as DataGridViewCheckBoxCell;
                        chk.Value = false;
                    }
                }

                DataGridViewCheckBoxCell clickedCheckBox = dataGridView1.Rows[e.RowIndex].Cells["cb_chosenStudent"] as DataGridViewCheckBoxCell;
                clickedCheckBox.Value = !Convert.ToBoolean(clickedCheckBox.Value);            
                STUDENT_ROW_INDEX = Convert.ToBoolean(clickedCheckBox.Value) ? e.RowIndex : -1;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["cb_chosenCourse"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell chk = row.Cells["cb_chosenCourse"] as DataGridViewCheckBoxCell;
                        chk.Value = false;
                    }
                }

                DataGridViewCheckBoxCell clickedCheckBox = dataGridView2.Rows[e.RowIndex].Cells["cb_chosenCourse"] as DataGridViewCheckBoxCell;
                clickedCheckBox.Value = !Convert.ToBoolean(clickedCheckBox.Value);
                COURSE_ROW_INDEX = Convert.ToBoolean(clickedCheckBox.Value) ? e.RowIndex : -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in bandDiem.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["gradeCol"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    string studentID = row.Cells[1].Value.ToString();
                    string courseID = row.Cells[2].Value.ToString();

                    Modify.ModifyGrade.deleteGrade(courseID, studentID );
                }
                bandDiem.DataSource = Modify.ModifyGrade.getAllGrade();
            }
            catch
            {
                MessageBox.Show("Student is not found for delete!");
                //MessageBox.Show(ex.Message);
            }
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formStudent = new FormStudent();
            formStudent.ShowDialog();
        }
        private void cOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCourse = new FormCourse();
            formCourse.ShowDialog();
        }

        private void rELOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void tEACHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTeacher = new FormTeacher();
            formTeacher.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_points_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                float points = float.Parse(tb_points.Text); // Get Points 
                DataGridViewRow studentRow = dataGridView1.Rows[STUDENT_ROW_INDEX];
                DataGridViewRow courseRow = dataGridView2.Rows[COURSE_ROW_INDEX];
                string studentID = studentRow.Cells[1].Value.ToString();
                string courseID = courseRow.Cells[1].Value.ToString();

                Grade grade = new Grade(studentID, courseID, points);
                Modify.ModifyGrade.insertGrade(grade);
                bandDiem.DataSource = Modify.ModifyGrade.getAllGrade();
                MessageBox.Show( "Add score successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show( $"{err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException err)
            {
                MessageBox.Show( $"{err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show( "Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return;
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in bandDiem.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["gradeCol"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    string studentID = row.Cells[1].Value.ToString();
                    string courseID = row.Cells[2].Value.ToString();

                    Modify.ModifyGrade.deleteGrade(courseID, studentID);
                }
                bandDiem.DataSource = Modify.ModifyGrade.getAllGrade();
                MessageBox.Show( "Delete score successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show( "Field is not found for delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cb_chosenStudent"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell chk = row.Cells["cb_chosenStudent"] as DataGridViewCheckBoxCell;
                        chk.Value = false;
                    }
                }

                DataGridViewCheckBoxCell clickedCheckBox = dataGridView1.Rows[e.RowIndex].Cells["cb_chosenStudent"] as DataGridViewCheckBoxCell;
                clickedCheckBox.Value = !Convert.ToBoolean(clickedCheckBox.Value);
                STUDENT_ROW_INDEX = Convert.ToBoolean(clickedCheckBox.Value) ? e.RowIndex : -1;
            }
        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tEACHERToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtnguna2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you want to edit?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return;
            try
            {
                 List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in bandDiem.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["gradeCol"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {

                    string studentID = row.Cells[1].Value.ToString();
                    string courseID = row.Cells[2].Value.ToString();
                    float points = float.Parse(tb_points.Text); // Get Points 
                    Char grading;
                    if (points >= 0 && points <= 25)
                    {
                        grading = 'D';
                    }
                    else if (points >= 26 && points <= 50)
                    {
                        grading = 'C';
                    }
                    else if (points >= 51 && points <= 75)
                    {
                        grading = 'B';
                    }
                    else if (points >= 76 && points <= 100)
                    {
                        grading = 'A';
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Points must be between 0 and 100.");
                    }

                    Modify.ModifyGrade.updateScore(courseID, studentID, points, grading);
                    

                }
                bandDiem.DataSource = Modify.ModifyGrade.getAllGrade();
                MessageBox.Show( "Edit score successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show( $"{err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show( "Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void bandDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }
    }
}
