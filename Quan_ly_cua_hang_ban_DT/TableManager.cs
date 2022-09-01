using Quan_ly_cua_hang_ban_DT.DAO;
using Quan_ly_cua_hang_ban_DT.DTO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_ban_DT
{
    public partial class TableManager : Form

    {

        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }
       
       
        public TableManager(Account acc)
        {
            this.LoginAccount = acc;
          
            InitializeComponent();

            ChangeAccount();
        }
        #region Method

        
        void ChangeAccount ()
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.displayname + ")";
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accountprofile a = new Accountprofile(LoginAccount);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginAccount.type == 1)
            {

                Admin a = new Admin();
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập ! ");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Trangchu_Click(object sender, EventArgs e)
        {
            Trangchu u = new Trangchu();
            this.Hide();
            u.ShowDialog();
            this.Show();
        }
    }

}
