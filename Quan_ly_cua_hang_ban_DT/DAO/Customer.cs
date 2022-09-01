using Quan_ly_cua_hang_ban_DT.DTO;
using System.Collections.Generic;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }
        private CustomerDAO() { }
        public List<Customer> getlistCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM Khachhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);

            }
            return list;
        }
        public bool InsertCustomer(string MaKh, string name, int SoDT)

        {
            string query = string.Format("INSERT dbo.Khachhang(MaKH, Name, SoDT ) VALUES ({0} , N'{1}',{2} )", MaKh, name, SoDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Customer> getlistCustomerbyMaKH(int MaKH)
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT* FROM Khachhang WHERE MaKH = " + MaKH;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {

                Customer customer = new Customer(item);
                list.Add(customer);

            }

            return list;
        }
        public bool UpdateCustomer(string Name, int SoDT, string MaKh)

        {
            string query = string.Format("UPDATE dbo.Khachhang SET Name = N'{0}' , SoDT = {1} WHERE MaKH= {2}", Name, SoDT, MaKh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool DeleteCustomer(string MaKh)

        {
            string query = string.Format("DELETE Khachhang WHERE MaKH= {0}", MaKh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public List<Customer> SearchCustomerbyName(string Name)
        {
            List<Customer> list = new List<Customer>();
            string query = string.Format("SELECT *FROM Khanhhang WHERE Name like N'%{0}%'", Name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);

            }
            return list;
        }

    }
}


