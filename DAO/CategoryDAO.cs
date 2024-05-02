using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CategoryDAO : DataProvider
    {
        public List<Category> GetData()
        {
            Connect();
            List<Category> list = new List<Category>();
            string sql = "SELECT * FROM LoaiSP";
            try
            {
                SqlDataReader dr = ExecuteNonQuery(sql);
                int id = 0;
                string name = string.Empty;

                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    name = dr.GetString(1);

                    list.Add(new Category(id, name));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }

            return list;
        }
    }
}
