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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formStatistics = new FormStatistics();
            formStatistics.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formScore = new FormScore();
            formScore.ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunA2AverageBtn_Click(object sender, EventArgs e)
        {
            Form formStatistics = new FormStatistics();
            formStatistics.ShowDialog();
        }

        private void c_Click(object sender, EventArgs e)
        {
            Form formScore = new FormScore();
            formScore.ShowDialog();
        }

        private void GunaExitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }

}
