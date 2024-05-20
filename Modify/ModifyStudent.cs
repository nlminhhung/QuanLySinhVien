using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien;

namespace QuanLySinhVien.Modify
{
    class ModifyStudent
    {
        public static DataTable getAllSinhVien()
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_getAllStudent", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static void insertSinhVien(Student sv)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_insertStudent", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", sv.TenSV);
                command.Parameters.AddWithValue("@StudentID", sv.MSSV);
                command.Parameters.AddWithValue("@DateOfBirth", sv.NgaySinh);
                command.Parameters.AddWithValue("@Address", sv.DiaChi);

                command.ExecuteNonQuery();
            }
        }

        public static void deleteSinhVien(string mssv)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_deleteStudent", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", mssv);
                command.ExecuteNonQuery();
            }
        }

        public static void updateSinhVien(Student sv)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("pr_updateStudent", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", sv.TenSV);
                command.Parameters.AddWithValue("@StudentID", sv.MSSV);
                command.Parameters.AddWithValue("@dateOfBirth", sv.NgaySinh);
                command.Parameters.AddWithValue("@Address", sv.DiaChi);
                command.ExecuteNonQuery();
            }
        }
    }
}
