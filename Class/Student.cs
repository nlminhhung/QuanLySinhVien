using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    class Student
    {
        private string name;
        private string studentID;
        private DateTime dateOfBirth;
        private string address;
        public Student() { }
        public Student(string TenSV, string MSSV, string DiaChi, DateTime NgaySinh)
        {
            name = TenSV;
            studentID = MSSV;
            dateOfBirth = NgaySinh;
            address = DiaChi;
        }


        public string TenSV { get => name; set => name = value; }
        public string MSSV { get => studentID; set => studentID = value; }
        public DateTime NgaySinh { get => dateOfBirth; set => dateOfBirth = value; }
        public string DiaChi { get => address; set => address = value; }
    }
}
