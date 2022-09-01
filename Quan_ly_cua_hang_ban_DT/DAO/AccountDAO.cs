using Quan_ly_cua_hang_ban_DT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Quan_ly_cua_hang_ban_DT.DAO
{
  public  class AccountDAO
    {
        private static AccountDAO instance; // Ctrl + R + E
string Pass, string Newpass) 
        {
            
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string Username, string PassWord)
        {
            
            string query = "USP_DangNhaap @UserName , @PassWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Username, PassWord });
            return result.Rows.Count > 0;
        }
       public Account GetAccountbyUsername(string Username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName = N'" + Username + "'");
            foreach( DataRow item in data.Rows)
            {
                return new Account(item);

            }
            return null;
        }
       public bool UpdateAccount(string Username, string DisplayName, 
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @UserName , @DisplayName , @PassWord , @newPassWord", new object[] { Username, DisplayName, Pass, Newpass });
            return result > 0;
        }
       

        
    }
}
