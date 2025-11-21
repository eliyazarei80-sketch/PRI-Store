using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PRI_STORE;

namespace PRI_STORE
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent(); //تنظیمات اولیه فرم  (مثل فیلد های متن و دکمه )رو از طراحی لود میکنه 
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; // نام محصول رو از فیلد متن میخونه
            string price = txtPrice.Text; // قیمت محصول رو از فیلد متن میخونه
            string stock = txtStock.Text; // موجودی محصول رو از فیلد متن میخونه
            string category = txtCategory.Text; // دسته بندی محصول رو از فیلد متن میخونه

            if(name=="" || price=="" || stock=="" || category=="")
            {
                MessageBox.Show("خطا", "!همه فیلدها را پرکنید", MessageBoxButtons.OK, MessageBoxIcon.Error); //اگه هر فیلد خالی باشه ، پیغام خطا نشون میده 
                return;
            }
            string newProduct = name + "+" + price + "+" + stock + "+" + category; //اطلاعات محصول رو با + به هم وصل میکنه
            File.AppendAllText("products.txt", newProduct + "\n"); //محصول جدید رو به فایل products.txt اضافه میکنه

            this.Close();

            MessageBox.Show("موفقیت", "!محصول اضافه شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //پیغام موفقیت نشون میده
                
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
