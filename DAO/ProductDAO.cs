using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ProductDAO : DataProvider
    {
        public List<Product> GetData()
        {
            Connect();
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM SanPham";
            try
            {
                SqlDataReader dr = ExecuteNonQuery(sql);
                string maSP, tenSP, donViTinh, hinhSP;
                double donGia;
                int maLoaiSP;

                while (dr.Read())
                {
                    maSP = dr.GetString(0);
                    tenSP = dr.GetString(1);
                    donViTinh = dr.GetString(2);
                    donGia = dr.GetDouble(3);
                    maLoaiSP = dr.GetInt32(4);
                    hinhSP = dr.GetString(5);

                    list.Add(new Product(maSP, tenSP, donViTinh, donGia, maLoaiSP, hinhSP));
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
