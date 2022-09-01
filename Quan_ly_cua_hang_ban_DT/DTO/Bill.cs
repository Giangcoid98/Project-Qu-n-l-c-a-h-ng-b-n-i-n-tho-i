using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_ly_cua_hang_ban_DT.DTO
{
    public class Bill
    {
        public Bill(string maHD, DateTime? ngaylap, string nguoilap, string nguoimua)
        {
            this.maHD = maHD;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
            this.nguoimua = nguoimua;
        }
        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private DateTime? ngaylap;
        public DateTime? Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }

        }
        private string nguoilap;
        public string Nguoilap
        {
            get { return nguoilap; }
            set { nguoilap = value; }

        }
        private string nguoimua;
        public string Nguoimua
        {
            get { return nguoimua; }
            set { nguoimua = value; }

        }
        public Bill(DataRow row)
        {
            this.maHD = row["MaHD"].ToString();
            this.ngaylap = (DateTime?)row["Datecheck"];
            this.nguoilap = row["Nguoilap"].ToString();
            this.nguoimua = row["Nguoimua"].ToString();
        }

    }
}
