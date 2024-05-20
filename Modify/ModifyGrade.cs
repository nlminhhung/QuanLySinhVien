using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Modify
{
    class ModifyGrade
    {
        public static DataTable getAllGrade()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAllGrade", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static void insertGrade(Grade grade)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_insertGrade", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", grade.StudentID);
                command.Parameters.AddWithValue("@CourseID", grade.CourseID);
                command.Parameters.AddWithValue("@Points", grade.Points);
                command.Parameters.AddWithValue("@Grading", grade.GradeLetter);
                command.ExecuteNonQuery();
            }
        }

        public static void deleteGrade(string courseID, string studentID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_deleteGrade", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.ExecuteNonQuery();
            }
        }
    }
}
