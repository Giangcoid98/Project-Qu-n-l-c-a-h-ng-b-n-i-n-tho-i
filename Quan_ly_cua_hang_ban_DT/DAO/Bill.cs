using Quan_ly_cua_hang_ban_DT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang_ban_DT.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public List<Bill> getlistBill()
        {
            List<Bill> list = new List<Bill>();
            string query = "SELECT Hd.MaHD, Hd.Datecheck , Nv.Name as Nguoilap , Kh.Name as Nguoimua FROM dbo.Hoadon Hd , dbo.Nhanvien Nv , dbo.Khachhang Kh WHERE Nv.MaNV = Hd.Nguoilap AND Kh.MaKH = Hd.Nguoimua";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                list.Add(bill);

            }
            return list;
        }
        public bool InsertBill(string MaHD,  string nguoilap, string nguoimua)

        {
            string query = string.Format("INSERT dbo.Hoadon(MaHD,Nguoilap,Nguoimua) VALUES ( N'{0}', N'{1}', N'{2}' )", MaHD, nguoilap, nguoimua);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateBill(string nguoilap, string nguoimua, string MaHD)

        {
            string query = string.Format("UPDATE dbo.Hoadon SET nguoilap = N'{0}' , nguoimua = N'{1}' WHERE MaHD= N'{2}'", nguoilap,nguoimua,MaHD) ;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteBill(string MaHD)

        {
            string query = string.Format("DELETE Hoadon WHERE MaHD= {0}", MaHD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }



    }
}
