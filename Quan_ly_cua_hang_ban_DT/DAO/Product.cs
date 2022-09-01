using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_ly_cua_hang_ban_DT.DTO;

namespace Quan_ly_cua_hang_ban_DT.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }
        private ProductDAO() { }
        public List<Product> getlistproduct()
        {
            List<Product> list = new List<Product>();
            string query = "SELECT* FROM Sanpham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);

            }
            return list;
        }
        public bool InsertProduct(int MaSP, string Name, int Price)

        {
            string query = string.Format("INSERT dbo.Sanpham(MaSP, Name, Price ) VALUES ({0} , N'{1}',{2} )", MaSP, Name, Price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Product> getlistproductbyID(int MaSP)
        {
            List<Product> list = new List<Product>();
            string query = "SELECT* FROM Sanpham WHERE MaSP = " + MaSP;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);

            }
            return list;
        }
        public bool UpdateProduct( string Name, int Price, int MaSP)

        {
            string query = string.Format( "UPDATE dbo.Sanpham SET Name = N'{0}' , Price = {1} WHERE MaSP = {2}", Name, Price,MaSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool DeleteProduct( int MaSP)

        {
            string query = string.Format("DELETE Sanpham WHERE MaSP = {0}", MaSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public List<Product> SearchProductbyname(string name)
        {
            List<Product> list = new List<Product>();
            string query = string.Format("SELECT* FROM Sanpham WHERE Name like N'%{0}%'" , name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);

            }
            return list;
        }

        


      



    }
}












