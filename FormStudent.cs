using QuanLySinhVien;
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

        private void button_them_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tenSV.Text;
                DateTime ngaySinh = date_ngaysinh.Value;
                string diaChi = tb_diachi.Text;

                if (mssv.Trim() == "") { MessageBox.Show("ID is required!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!"); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.insertSinhVien(sv);
                //MessageBox.Show("Them thanh cong!");
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
            }
            catch
            {
                MessageBox.Show("ID has been used!");
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
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
            }
            catch
            {
                MessageBox.Show("Can not find student to delete!");
                //MessageBox.Show(ex.Message);
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tenSV.Text;
                DateTime ngaySinh = date_ngaysinh.Value;
                string diaChi = tb_diachi.Text;
                if (mssv.Trim() == "") { MessageBox.Show("ID is required!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!"); return; }
                if (diaChi.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!"); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.updateSinhVien(sv);
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (mssv.Trim() == "") { MessageBox.Show("ID is required!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!"); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.insertSinhVien(sv);
                //MessageBox.Show("Them thanh cong!");
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
            }
            catch
            {
                MessageBox.Show("ID has been used!");
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
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
            }
            catch
            {
                MessageBox.Show("Can not find student to delete!");
                //MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tenSV.Text;
                DateTime ngaySinh = date_ngaysinh.Value;
                string diaChi = tb_diachi.Text;
                if (mssv.Trim() == "") { MessageBox.Show("ID is required!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Name is required!"); return; }
                if (diaChi.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Date of birth is not valid!"); return; }
                Student sv = new Student(tenSV, mssv, diaChi, ngaySinh);

                Modify.ModifyStudent.updateSinhVien(sv);
                bangSinhVien.DataSource = Modify.ModifyStudent.getAllSinhVien();
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
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
