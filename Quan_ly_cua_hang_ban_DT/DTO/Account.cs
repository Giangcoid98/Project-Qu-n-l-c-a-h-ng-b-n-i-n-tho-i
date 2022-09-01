using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DTO
{
  public  class Account
    {
        public Account(string Username, string DisplayName, int Type, string PassWord= null)
        {
            this.UserName = Username;
            this.Password = PassWord;
            this.type = Type;
            this.displayname = DisplayName;
        }
        public Account(DataRow row)
        {

            this.Username = row["UserName"].ToString();

            this.Password =row["PassWord"].ToString();
            this.type = (int)row["TYPE"];
            this.displayname = row["DisplayName"].ToString();
        }

        private string Username;
        public string UserName
        {
            get { return Username; }
            set { Username = value; }

        }
        private string DisplayName;
        public string displayname
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }
         
        private string PassWord;
        public string Password
        {
            get { return PassWord; }
            set { PassWord = value; }
        }
        private int Type;
        public int type
        {
            get { return Type; }
            set { Type = value; }
        }
    }
}
