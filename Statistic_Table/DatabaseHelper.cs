using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Statistic_Table
{
    internal class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper()
        {
            // ✅ الاتصال الصحيح بناءً على معلوماتك
            _connectionString = @"Data Source=DESKTOP-CQ982I6\SQLEXPRESS;
                                  Initial Catalog=StatisticsMis;
                                  User ID=Statistics;
                                  Password=597640;
                                  TrustServerCertificate=True;
                                  Encrypt=False;
                                  Pooling=False;
                                  MultipleActiveResultSets=False;
                                  Application Name=StatisticsSystem;";
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الاستعلام:\n{query}\n\nالخطأ: {ex.Message}", ex);
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الأمر:\n{query}\n\nالخطأ: {ex.Message}", ex);
            }
        }
    }
}