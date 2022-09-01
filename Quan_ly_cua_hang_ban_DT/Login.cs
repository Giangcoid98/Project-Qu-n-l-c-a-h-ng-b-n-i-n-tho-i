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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if ( login(Username, Password))
            {
                
                Account loginAccount = AccountDAO.Instance.GetAccountbyUsername(Username);
                TableManager t = new TableManager(loginAccount); 
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }

        }
        bool login(string Username, string PassWord) 
        {
            return AccountDAO.Instance.Login(Username, PassWord);
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txblogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình ?  ", "Thông báo !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
