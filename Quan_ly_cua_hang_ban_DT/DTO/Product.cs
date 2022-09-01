using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Quan_ly_cua_hang_ban_DT.DTO
{
 public  class Product
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string NAme;
        public string Name
        {
            get { return NAme; }
            set { NAme = value; }
        }
        private int PricE;
        public int price
        {
            get { return PricE; }
            set { PricE = value; }
        }
        public Product(int MaSP, string name, int Price)
        {
            this.ID = MaSP;
            this.Name = name;
            this.price = Price;

        }
        public Product(DataRow row)
        {
            this.ID = (int)Convert.ToDouble(row["MaSP"].ToString());
            this.Name = row["Name"].ToString();
           
            this.price = (int)Convert.ToDouble(row["Price"].ToString());
        }
        
    }
}
