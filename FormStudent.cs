﻿using QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySinhVien
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    bangSinhVien.DataSource = Modify.getAllSinhVien();

        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {
            bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
        }

        private void bangSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = bangSinhVien.Rows[e.RowIndex];

                tb_mssv.Text = row.Cells[0].Value.ToString();
                tb_tenSV.Text = row.Cells[1].Value.ToString();
                tb_diachi.Text = row.Cells[2].Value.ToString();
                date_ngaysinh.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please click into row of student");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tenSV.Text;
                DateTime ngaySinh = date_ngaysinh.Value;
                string diaChi = tb_diachi.Text;

                if (mssv.Trim() == "") { MessageBox.Show("ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (diaChi.Trim() == "") { MessageBox.Show("Address is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.insertSinhVien(sv);
                //MessageBox.Show("Them thanh cong!");
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
                MessageBox.Show( "Add student successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show ("ID has been used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you want to delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return;
            // xoa theo check box
            try
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in bangSinhVien.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["checkedBox"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    Modify.ModifyStudent.deleteSinhVien(row.Cells[0].Value.ToString());
                }

                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
                MessageBox.Show( "Delete student successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show( "Can not find student to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you want to edit?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return;
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tenSV.Text;
                DateTime ngaySinh = date_ngaysinh.Value;
                string diaChi = tb_diachi.Text;
                if (mssv.Trim() == "") { MessageBox.Show("ID is required!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (diaChi.Trim() == "") { MessageBox.Show("Address is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.updateSinhVien(sv);
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
                MessageBox.Show( "Edit student successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show( "Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
