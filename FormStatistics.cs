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
            dataGridView1.DataSource = Modify.ModifyStatistics.getAverageScore();
        }
    }
}
