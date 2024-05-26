using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Modify
{
    class ModifyStatistics
    {
        public static DataTable getAverageScore()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAverageScore", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable getTotalStudentInCourse()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getTotalStudentInCourse", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable getTeacherTotalCourse()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getTeacherTotalCourse", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}
