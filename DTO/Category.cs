using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Category
    {
        public int MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }

        public Category(int MaLoaiSP, string TenLoaiSP)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
        }
    }
}
