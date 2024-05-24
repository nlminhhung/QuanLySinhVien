using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Class
{
    internal class Teacher
    {
        private string teacherID;
        private string name;
        private string address;

        public Teacher(string Name, string TeacherID, string Address)
        {
            name = Name;
            teacherID = TeacherID;
            address = Address;
        }

        public string Name { get => name; set => name = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string Address { get => address; set => address = value; }
    }
}
