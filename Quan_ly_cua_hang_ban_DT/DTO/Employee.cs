using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DTO
{
   public  class Employee
    {

        private string MaNV;
        public string maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
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
        private string SoCMT;
        public string soCMT
        {
            get { return SoCMT; }
            set { SoCMT = value; }
        }

        public Employee(string maNV, string name, string soCMT, int soDT )
        {
            this.maNV = maNV;
            this.name = name;
            this.soDT = soDT;
            this.soCMT = soCMT;
        }
        public Employee(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.Name = row["Name"].ToString();

            this.SoDT = (int)Convert.ToDouble(row["SoDT"].ToString());
            this.SoCMT = row["SoCMT"].ToString();
        }

    }
}

