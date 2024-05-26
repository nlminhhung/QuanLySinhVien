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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load_1(object sender, EventArgs e)
        {
            //this.studentTableAdapter.Fill(this.firstDBDataSet.Student);
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = Modify.ModifyStatistics.getAverageScore();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = Modify.ModifyStatistics.getAverageScore();
                    break;
                case 1:
                    dataGridView1.DataSource = Modify.ModifyStatistics.getTotalStudentInCourse();
                    break;
                case 2:
                    dataGridView1.DataSource = Modify.ModifyStatistics.getTeacherTotalCourse();
                    break;
            }
        }
    }
}
