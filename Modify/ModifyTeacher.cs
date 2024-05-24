using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.Class;

namespace QuanLySinhVien.Modify
{
    class ModifyTeacher
    {
        public static DataTable getAllTeacher()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAllTeacher", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static void insertTeacher(Teacher teacher)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_insertTeacher", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", teacher.Name);
                command.Parameters.AddWithValue("@TeacherID", teacher.TeacherID);
                command.Parameters.AddWithValue("@Address", teacher.Address);
                command.ExecuteNonQuery();
            }
        }

        public static void deleteTeacher(string teacherID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_deleteTeacher", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TeacherID", teacherID);
                command.ExecuteNonQuery();
            }
        }

        public static void updateTeacher(Teacher teacher)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_updateTeacher", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", teacher.Name);
                command.Parameters.AddWithValue("@TeacherID", teacher.TeacherID);
                command.Parameters.AddWithValue("@Address", teacher.Address);
                command.ExecuteNonQuery();
            }
        }

    }
}
