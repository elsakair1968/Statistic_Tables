using StatisticsSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StatisticsSystem.Models;

namespace Statistic_Table
{
    internal class PartialProsecutionRepository
    {
            private DatabaseHelper _db;

            public PartialProsecutionRepository()
            {
                _db = new DatabaseHelper();
            }

            // جلب جميع البيانات
            public List<PartialProsecution> GetAll()
            {
                List<PartialProsecution> list = new List<PartialProsecution>();
                DataTable dt = _db.ExecuteQuery("SELECT ID, Code, Number, Name, None, Note FROM Prosecution_Partial_LBT");

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new PartialProsecution
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Code = Convert.ToInt32(row["Code"]),
                        Number = Convert.ToInt32(row["Number"]),
                        Name = row["Name"].ToString(),
                        IsActive = Convert.ToBoolean(row["None"]),
                        Note = row["Note"] == DBNull.Value ? null : (byte[])row["Note"]
                    });
                }
                return list;
            }

            // إضافة سجل جديد
            public int Add(PartialProsecution item)
            {
                string query = @"INSERT INTO Prosecution_Partial_LBT (Code, Number, Name, None, Note) 
                             VALUES (@Code, @Number, @Name, @None, @Note);
                             SELECT SCOPE_IDENTITY();";

                SqlParameter[] parameters = {
                new SqlParameter("@Code", item.Code),
                new SqlParameter("@Number", item.Number),
                new SqlParameter("@Name", item.Name ?? (object)DBNull.Value),
                new SqlParameter("@None", item.IsActive),
                new SqlParameter("@Note", item.Note ?? (object)DBNull.Value)
            };

                DataTable dt = _db.ExecuteQuery(query, parameters);
                return Convert.ToInt32(dt.Rows[0][0]);
            }

            // تحديث سجل
            public int Update(PartialProsecution item)
            {
                string query = @"UPDATE Prosecution_Partial_LBT SET 
                             Code = @Code, Number = @Number, Name = @Name, 
                             None = @None, Note = @Note
                             WHERE ID = @ID";

                SqlParameter[] parameters = {
                new SqlParameter("@ID", item.ID),
                new SqlParameter("@Code", item.Code),
                new SqlParameter("@Number", item.Number),
                new SqlParameter("@Name", item.Name ?? (object)DBNull.Value),
                new SqlParameter("@None", item.IsActive),
                new SqlParameter("@Note", item.Note ?? (object)DBNull.Value)
            };

                return _db.ExecuteNonQuery(query, parameters);
            }

            // حذف سجل
            public int Delete(int id)
            {
                string query = "DELETE FROM Prosecution_Partial_LBT WHERE ID = @ID";
                return _db.ExecuteNonQuery(query, new[] { new SqlParameter("@ID", id) });
            }

            // بحث
            public DataTable Search(string keyword)
            {
                string query = @"SELECT * FROM Prosecution_Partial_LBT 
                             WHERE Name LIKE @keyword OR Code LIKE @keyword OR Number LIKE @keyword";
                return _db.ExecuteQuery(query, new[] { new SqlParameter("@keyword", $"%{keyword}%") });
            }
    }
}