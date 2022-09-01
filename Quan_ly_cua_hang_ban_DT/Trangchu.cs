using System;
using Quan_ly_cua_hang_ban_DT.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_ly_cua_hang_ban_DT.DTO;


namespace Quan_ly_cua_hang_ban_DT
{
    public partial class Trangchu : Form
    {


        BindingSource Customerlist = new BindingSource();
        BindingSource Billlist = new BindingSource();
        BindingSource Billinfolist = new BindingSource();
        
        public Trangchu()
        {
            InitializeComponent();

            load();

        }
        List<Customer> SearchCustomerbyName(string Name)
        {
            List<Customer> listCustomer = CustomerDAO.Instance.SearchCustomerbyName(Name);
            return listCustomer;
        }
        void load()
        {
            dataCustomer.DataSource = Customerlist;
            LoadlistCustomer();
            AddCustomerBinding();
            dtgthd.DataSource = Billlist;
            LoadlistBill();
            AddBillBinding();
            dtgvchitiethoadon.DataSource = Billinfolist;
            LoadlistBillinfo();
            AddBillinfoBinding();
            LoadIDEmployee();
            LoadIDProduct();





        }
        void LoadlistCustomer()
        {
            Customerlist.DataSource = CustomerDAO.Instance.getlistCustomer();
            List<Customer> listCustomers = CustomerDAO.Instance.getlistCustomer();
            comboxKhanhhanghd.DataSource = listCustomers;
            comboxKhanhhanghd.DisplayMember = "MaKH";




        }
        void AddCustomerBinding()
        {
            textMaKh.DataBindings.Add(new Binding("Text", dataCustomer.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            textNameKh.DataBindings.Add(new Binding("Text", dataCustomer.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textSdtKh.DataBindings.Add(new Binding("Text", dataCustomer.DataSource, "SoDT", true, DataSourceUpdateMode.Never));



        }
        void LoadIDProduct()
        {
            List<Product> listProduct = ProductDAO.Instance.getlistproduct();
            cbmHanghoa.DataSource = listProduct;
            cbmHanghoa.DisplayMember = "Name";
        }
        void LoadIDEmployee()
        {
            List<Employee> listEmployee = EmployeeDAO.Instance.getlistEmployee();
            cbmNVlap.DataSource = listEmployee;
            cbmNVlap.DisplayMember = "MaNV";

        }
        void LoadlistBill()
        {
            Billlist.DataSource = BillDAO.Instance.getlistBill();
            
            
        }
        void AddBillBinding()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dtgthd.DataSource, "MaHD", true, DataSourceUpdateMode.Never));

            cbmNVlap.DataBindings.Add(new Binding("Text", dtgthd.DataSource, "Nguoilap", true, DataSourceUpdateMode.Never));
            comboxKhanhhanghd.DataBindings.Add(new Binding("Text", dtgthd.DataSource, "Nguoimua", true, DataSourceUpdateMode.Never));
           
        }
        void LoadlistBillinfo()
        {
            Billinfolist.DataSource = BillinfoDAO.Instance.getlistBillinfo();

        }
        void AddBillinfoBinding()
        {
            cbmHanghoa.DataBindings.Add(new Binding("Text", dtgvchitiethoadon.DataSource, "Sanpham", true, DataSourceUpdateMode.Never));
            txtmoney.DataBindings.Add(new Binding("Text", dtgvchitiethoadon.DataSource, "Dongia", true, DataSourceUpdateMode.Never));
            soluong.DataBindings.Add(new Binding("Text", dtgvchitiethoadon.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
            txtThanhtien.DataBindings.Add(new Binding("Text", dtgvchitiethoadon.DataSource, "Thanhtien", true, DataSourceUpdateMode.Never));


        }
        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            string Name = textNameKh.Text;
            string MaKh = textMaKh.Text;
            int SoDT = (int)Convert.ToInt32(textSdtKh.Text);

            if (CustomerDAO.Instance.InsertCustomer( MaKh, Name,  SoDT))
            {
                MessageBox.Show("Thêm khách hàng thành công !");
                LoadlistCustomer();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng  !");

            }
        }

        private void dataEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowNV_Click(object sender, EventArgs e)
        {
            LoadlistCustomer();
        }

        private void btnFixKh_Click(object sender, EventArgs e)
        {

            string Name = textNameKh.Text;
            string MaKh = textMaKh.Text;
            int SoDT = (int)Convert.ToInt32(textSdtKh.Text);

            if (CustomerDAO.Instance.UpdateCustomer( Name, SoDT , MaKh))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công !");
                LoadlistCustomer();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin khách hàng !");

            }

        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {

            string MaKh = textMaKh.Text;
            

            if (CustomerDAO.Instance.DeleteCustomer(MaKh))
            {
                MessageBox.Show("Xóa khách hàng thành công !");
                LoadlistCustomer();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khách hàng  !");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            Customerlist.DataSource = SearchCustomerbyName(txtFIndKH.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textSdtKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dtgthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Addhd_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;
            
            string nguoilap = cbmNVlap.Text;
            string nguoimua =comboxKhanhhanghd.Text;
            string maHoadon = txtMaHD.Text;
            string sanpham = cbmHanghoa.Text;
            int Dongia = (int)Convert.ToInt32(txtmoney.Text);
            int Soluong= (int)Convert.ToInt32(soluong.Text);
            int Thanhtien = (int)Convert.ToInt32(txtThanhtien.Text);





            if (BillDAO.Instance.InsertBill(MaHD, nguoilap, nguoimua) && BillinfoDAO.Instance.InsertBillinfo(maHoadon, sanpham, Soluong,Dongia, Thanhtien)) 
            {
                MessageBox.Show("Thêm Hóa đơn thành công !");
                LoadlistBill();
                LoadlistBillinfo();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm hóa đơn  !");

            }
        }

        private void FixHD_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;

            string nguoilap = cbmNVlap.Text;
            string nguoimua = comboxKhanhhanghd.Text;
            string maHoadon = txtMaHD.Text;
            string sanpham = cbmHanghoa.Text;
            int Dongia = (int)Convert.ToInt32(txtmoney.Text);
            int Soluong = (int)Convert.ToInt32(soluong.Text);
            int Thanhtien = (int)Convert.ToInt32(txtThanhtien.Text);





            if (BillDAO.Instance.UpdateBill(nguoilap , nguoimua , MaHD) && BillinfoDAO.Instance.UpdateBillinfo(sanpham , Soluong , Dongia, Thanhtien,maHoadon))
            {
                MessageBox.Show("Sửa Hóa đơn thành công !");
                LoadlistBill();
                LoadlistBillinfo();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa hóa đơn  !");

            }
        }

        private void btxINhd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công ! ");
        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;

            
            string maHoadon = txtMaHD.Text;
            




            if (BillDAO.Instance.DeleteBill(MaHD) && BillinfoDAO.Instance.DeleteBillinfo( maHoadon))
            {
                MessageBox.Show("Xóa hóa đơn thành công !");
                LoadlistBill();
                LoadlistBillinfo();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa hóa đơn  !");

            }

        }
    }
}
