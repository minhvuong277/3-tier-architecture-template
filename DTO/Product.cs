using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Donvitinh { get; set; }
        public double Dongia { get; set; }
        public int MaLoaiSP { get; set; }
        public string HinhSP { get; set; }

        public Product(string MaSP, string TenSP, string Donvitinh, double Dongia, int MaLoaiSP, string HinhSP)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.Donvitinh = Donvitinh;
            this.Dongia = Dongia;
            this.MaLoaiSP = MaLoaiSP;
            this.HinhSP = HinhSP;
        }
    }
}
