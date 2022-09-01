using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_ly_cua_hang_ban_DT.DTO;


namespace Quan_ly_cua_hang_ban_DT.DAO
{
   public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set{ EmployeeDAO.instance = value; }
        }
        private EmployeeDAO() { }

    
    
    public List<Employee> getlistEmployee()
    {
        List<Employee> list = new List<Employee>();
        string query = "SELECT *FROM Nhanvien ";
        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        foreach (DataRow item in data.Rows)
        {
            Employee employee = new Employee(item);
            list.Add(employee);

        }
        return list;
    }
    public bool InsertEmployee(string MaNV, string name, int SoDT, string SoCMT)

    {
        string query = string.Format("INSERT dbo.Nhanvien(MaNV, Name, SoDT, SoCMT ) VALUES ({0} , N'{1}',{2}, {3} )", MaNV, name, SoDT,SoCMT);
        int result = DataProvider.Instance.ExecuteNonQuery(query);
        return result > 0;
    }
    public List<Employee> getlistEmployeebyMaNV(string MaNV)
    {
        List<Employee> list = new List<Employee>();
        string query = "SELECT* FROM Nhanvien WHERE MaNV = " + MaNV;
        DataTable data = DataProvider.Instance.ExecuteQuery(query);


        foreach (DataRow item in data.Rows)
        {

                Employee employee = new Employee(item);
                list.Add(employee);
         
        }

        return list;
    }
    public bool UpdateEmployee(string Name, int SoDT, string SoCMT, string MaNV)

    {
        string query = string.Format("UPDATE dbo.Nhanvien SET Name = N'{0}' , SoDT = {1} , SoCMT = {2} WHERE MaNV= {3}", Name, SoDT, SoCMT, MaNV);
        int result = DataProvider.Instance.ExecuteNonQuery(query);
        return result > 0;

    }

    public bool DeleteEmployee(string MaNV)

    {
        string query = string.Format("DELETE Nhanvien   WHERE MaNV= {0}", MaNV);
        int result = DataProvider.Instance.ExecuteNonQuery(query);
        return result > 0;

    }
    public List<Employee> SearchEmployeebyName(string Name)
    {
        List<Employee> list = new List<Employee>();
        string query = string.Format("SELECT *FROM Nhanvien WHERE Name like N'%{0}%'", Name);
        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        foreach (DataRow item in data.Rows)
        {
                Employee employee = new Employee(item);
                list.Add(employee);
        }
        return list;
    }

}
}




   


