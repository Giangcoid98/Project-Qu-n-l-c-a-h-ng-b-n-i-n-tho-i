using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DTO
{
  public  class Billinfo
    {
        public Billinfo(string maHoadon, string sanpham,  int Soluong, int Dongia, int Thanhtien )
        {
            this.maHoadon= maHoadon;
            this.sanpham = sanpham;
            this.Dongia = Dongia;
            this.Soluong = Soluong;
            this.Thanhtien = Thanhtien;
           
        }
        private string maHoadon;
        public string MaHoadon
        {
            get { return maHoadon; }
            set { maHoadon = value; }
        }
        private string sanpham;
        public string Sanpham
        {
            get { return sanpham; }
            set { sanpham = value; }

        }
        private int Dongia;
        public int dongia
        {
            get { return Dongia; }
            set { Dongia = value; }

        }
        private int Soluong;
        public int soluong
        {
            get { return Soluong; }
            set { Soluong = value; }

        }
        private int Thanhtien;
        public int thanhtien
        {
            get { return Thanhtien; }
            set { Thanhtien = value ; }

        }




        public Billinfo(DataRow row)
        {
            this.maHoadon = row["MaHoadon"].ToString();
            this.sanpham = row["Sanpham"].ToString();
            this.Soluong = (int)Convert.ToDouble(row["Soluong"].ToString());
            this.Dongia = (int)Convert.ToDouble(row["Dongia"].ToString());
            this.Thanhtien= (int)Convert.ToDouble(row["Thanhtien"].ToString());
        }

    }
}

    

