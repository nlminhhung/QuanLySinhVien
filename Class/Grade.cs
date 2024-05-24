using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Grade
    {
        private string studentID;
        private string courseID;
        private float points;
        private char gradeLetter;

        public Grade() { }
        public Grade(string StudentID, string CourseID, float Points)
        {
            studentID = StudentID;
            courseID = CourseID;
            points = Points;
            gradeLetter = ClassifyGradeByLetter(Points);
        }

        private char ClassifyGradeByLetter(float points)
        {
            if (points >= 0 && points <= 25)
            {
                return 'D';
            }
            else if (points >= 26 && points <= 50)
            {
                return 'C';
            }
            else if (points >= 51 && points <= 75)
            {
                return 'B';
            }
            else if (points >= 76 && points <= 100)
            {
                return 'A';
            }
            else
            {
                throw new ArgumentOutOfRangeException("Points must be between 0 and 100.");
            }
        }


        public string StudentID { get => studentID; set => studentID = value; }
        public string CourseID { get => courseID; set => courseID = value; }
        public float Points { get => points; set => points = value; }
        public char GradeLetter { get => gradeLetter; }
    }
}
