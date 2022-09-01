using Quan_ly_cua_hang_ban_DT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quan_ly_cua_hang_ban_DT.DTO;

namespace Quan_ly_cua_hang_ban_DT
{
    public partial class Accountprofile : Form
    {



        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount); }
        }

        public Accountprofile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;

        }
        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.displayname;


        }
        void UpdateAccount()
        {

            string displayname = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newpassword = txtnewPassword.Text;
            string renewpassword = txtRenewpassword.Text;
            string Username = txtUsername.Text;
            if (!newpassword.Equals(renewpassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu  đúng với mật khẩu mới ! ");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(Username,displayname,password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu ! ");
                }
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
