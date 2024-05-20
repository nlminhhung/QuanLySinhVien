using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Modify
{
    class ModifyCourse
    {
        public static DataTable getAllCourse()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAllCourse", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static void insertCourse(Course course)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_insertCourse", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CourseID", course.CourseID);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@StudyYear", course.Year);
                command.Parameters.AddWithValue("@TeacherID", course.TeacherID);

                command.ExecuteNonQuery();
            }
        }

        public static void deleteCourse(string courseID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_deleteCourse", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.ExecuteNonQuery();
            }
        }
        public static void updateCourse(Course course)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_updateCourse", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@courseID", course.CourseID);
                command.Parameters.AddWithValue("@name", course.CourseName);
                command.Parameters.AddWithValue("@year", course.Year);
                command.Parameters.AddWithValue("@teacherID", course.TeacherID);
                command.ExecuteNonQuery();
            }
        }
    }
}
