using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DTO
{
   public class Customer
    {
        private string MaKH;
        public string maKH
        {
            get { return MaKH; }
            set { MaKH = value; }

        }
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int SoDT;
        public int soDT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }
        public Customer(string maKh, string name , int Sodt)
        {
            this.maKH = maKh;
            this.Name = name;
            this.SoDT = Sodt;

        }
        public Customer( DataRow row)
        {
            this.maKH = row["MaKH"].ToString();
            this.Name = row["Name"].ToString();

            this.SoDT = (int)Convert.ToDouble(row["SoDT"].ToString());
        }

    }
}
