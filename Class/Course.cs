using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Course
    {
        private string courseName;
        private string courseID;
        private int year;
        private string teacherID;


        public Course() { }
        public Course(string CourseName, string CourseID, int Year, string TeacherID)
        {
            courseName = CourseName;
            courseID = CourseID;
            year = Year;
            teacherID = TeacherID;
        }


        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseID { get => courseID; set => courseID = value; }
        public int Year { get => year; set => year = value; }
        public string TeacherID {  get => teacherID; set => teacherID = value; }

    }
}
