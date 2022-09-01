using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_ly_cua_hang_ban_DT.DTO;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DAO
{
   public class BillinfoDAO
    {
        private static BillinfoDAO instance;
        public static BillinfoDAO Instance
        {
            get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }
            private set { BillinfoDAO.instance = value; }
        }
        private BillinfoDAO() { }
        public List<Billinfo> getlistBillinfo()
        {
            List<Billinfo> list = new List<Billinfo>();
            string query = " SELECT * FROM ChiTietHoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Billinfo billinfo = new Billinfo(item);
                list.Add(billinfo);

            }
            return list;
           
        }
        public bool InsertBillinfo( string maHoadon, string sanpham, int Soluong, int Dongia, int Thanhtien)

        {
            string query = string.Format("INSERT dbo.ChiTietHoaDon(MaHoadon,sanpham,Soluong,Dongia,Thanhtien) VALUES ( N'{0}', N'{1}', {2},{3},{4} )", maHoadon, sanpham,Soluong,Dongia,Thanhtien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateBillinfo( string sanpham, int Soluong,int Dongia, int Thanhtien, string maHoadon)

        {
            string query = string.Format("UPDATE dbo.ChiTietHoaDon SET sanpham = N'{0}' , Soluong = {1},Dongia = {2} Thanhtien = {3} WHERE MaHoadon= N'{4}'", sanpham,Soluong,Dongia,Thanhtien,maHoadon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteBillinfo(string MaHoadon)

        {
            string query = string.Format("DELETE ChiTietHoaDon WHERE MaHoadon ={0}", MaHoadon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

    }
}
