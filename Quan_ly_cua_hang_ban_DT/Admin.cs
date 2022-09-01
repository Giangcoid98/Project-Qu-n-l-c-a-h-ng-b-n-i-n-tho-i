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
    public partial class Admin : Form
    {
        BindingSource Productlist = new BindingSource();
        BindingSource Employeelist = new BindingSource();
        BindingSource Billlist = new BindingSource();
        BindingSource Billinfolist = new BindingSource();
        public Admin ()
        {
            InitializeComponent();
       

            load();


        }
        #region methods
         List<Product> SearchProductbyname(string name)
        {
            List<Product> listProduct = ProductDAO.Instance.SearchProductbyname(name);
            return listProduct;
        }
        List<Employee> SearchEmployeebyname(string name)
        {
            List<Employee> listemployees = EmployeeDAO.Instance.SearchEmployeebyName(name);
            return listemployees;
        }

        void load()
        {
            dataProduct.DataSource = Productlist;
            dataEmployee.DataSource = Employeelist;
            LoadlistProduct();
            AddProductBinding();
            LoadlistEmployee();
            AddEmployeeBinding();
            dataBill.DataSource = Billlist;
            LoadlistBill();
            dataBillinfo.DataSource = Billinfolist;
            LoadlistBillinfo();
        }


        void LoadlistBill()
        {
            Billlist.DataSource = BillDAO.Instance.getlistBill();
        }
        void LoadlistBillinfo()
        {
            Billinfolist.DataSource = BillinfoDAO.Instance.getlistBillinfo();
        }
        void LoadlistProduct()
        {
            Productlist.DataSource = ProductDAO.Instance.getlistproduct();

        }
        void AddProductBinding()
        {
            textMaSP.DataBindings.Add(new Binding("Text", dataProduct.DataSource, "ID",true , DataSourceUpdateMode.Never));
            textName.DataBindings.Add(new Binding("Text", dataProduct.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dataProduct.DataSource, "Price", true, DataSourceUpdateMode.Never));            
            
            

        }
        void LoadlistEmployee() 
        {
            Employeelist.DataSource = EmployeeDAO.Instance.getlistEmployee();
        }
        void AddEmployeeBinding() 
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dataEmployee.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            textNameNV.DataBindings.Add(new Binding("Text", dataEmployee.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textSodtNV.DataBindings.Add(new Binding("Text", dataEmployee.DataSource, "SoDT", true, DataSourceUpdateMode.Never));
            txtSocmtNV.DataBindings.Add(new Binding("Text", dataEmployee.DataSource, "SoCMT", true, DataSourceUpdateMode.Never));
            
        }


       
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployee_Click(object sender, EventArgs e)
        {

        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = textNameNV.Text;
            string MaNV = txtMaNV.Text;
            int SoDT = (int)Convert.ToInt32(textSodtNV.Text);
            string SoCMT = txtSocmtNV.Text;

            if (EmployeeDAO.Instance.InsertEmployee(MaNV,Name, SoDT, SoCMT))
            {
                MessageBox.Show("Thêm nhân viên thành công !");
                LoadlistEmployee();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên !");

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCT_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        void dataEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           






        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {

        }

        private void btnExitNV_Click(object sender, EventArgs e)
        {

        }

        private void btnShowNV_Click(object sender, EventArgs e)
        {
            LoadlistEmployee();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadlistProduct();

        }

        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            string Name = textName.Text;
            int MaSP = (int)Convert.ToInt32(textMaSP.Text);
            int Price = (int)nmPrice.Value;

            if (ProductDAO.Instance.InsertProduct(MaSP, Name, Price))
            {
                MessageBox.Show("Thêm sản phẩm thành công !");
                LoadlistProduct();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm !");

            }
           
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFixNV_Click(object sender, EventArgs e)
        {
            string Name = textNameNV.Text;
            string MaNV = txtMaNV.Text;
            int SoDT = (int)Convert.ToInt32(textSodtNV.Text);
            string SoCMT = txtSocmtNV.Text;

            if (EmployeeDAO.Instance.UpdateEmployee(Name, SoDT, SoCMT, MaNV))
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công !");
                LoadlistEmployee();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin nhân viên !");

            }
        }

        private void btnFixSP_Click(object sender, EventArgs e)
        {
            string Name = textName.Text;
            int MaSP = Convert.ToInt32(textMaSP.Text);
            int Price = (int)nmPrice.Value;

            if (ProductDAO.Instance.UpdateProduct( Name, Price,MaSP))
            {
                MessageBox.Show("Sửa  sản phẩm thành công !");
                LoadlistProduct();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sản  phẩm!");

            }

        }

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            string Name = textName.Text;
            int MaSP = Convert.ToInt32(textMaSP.Text);
            int Price = (int)nmPrice.Value;

            if (ProductDAO.Instance.DeleteProduct( MaSP))
            {
                MessageBox.Show("Xóa sản phẩm thành công !");
                LoadlistProduct();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sản phẩm !");

            }


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textMaSP_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
          Productlist.DataSource=  SearchProductbyname(txtSearchProductbyname.Text);
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            

            if (EmployeeDAO.Instance.DeleteEmployee( MaNV))
            {
                MessageBox.Show("Xóa thông tin nhân viên thành công !");
                LoadlistEmployee();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thông tin nhân viên !");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
            Employeelist.DataSource = SearchEmployeebyname(textfindNHANVIEN.Text);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dataBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

    
}