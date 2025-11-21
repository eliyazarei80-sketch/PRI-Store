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
    public partial class EditProductForm : Form
    {
        public EditProductForm(string name,string price,string stock,string category)
        {
            InitializeComponent(); // تنظیمات اولیه فرم ( مثل فیلد های متنی و دکمه ) رو از طراحی لود میکنه
            oldName = name; //نام قبلی محصول رو ذخیره میکنه
            txtName.Text = name; //فیلد نام رو با نام اولیه پر میکنه
            txtPrice.Text = price; //فیلد قیمت رو با قیمت اولیه پر میکنه
            txtStock.Text = stock; //فیلد موجودی رو با موجودی پر میکنه
            txtCategory.Text = category; //فیلد دسته بندی رو با دسته بندی اولیه پر میکنه
        }

        private string oldName; //متغیری برای ذخیره نام قبلی محصول 
        private void button1_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text; //نام جدید محصول رو از فیلد متنی میخونه
            string newPrice = txtPrice.Text; //قیمت جدید محصول رو از فیلد متنی میخونه
            string newStock = txtStock.Text; //موجودی جدید محصول رو از فیلد متنی میخونه
            string newCategory = txtCategory.Text;//دسته بندی جدید محصول رو از فیلد متنی میخونه

            if(newName=="" || newPrice=="" || newStock=="" || newCategory=="")
            {
                MessageBox.Show("خطا", "!همه ی فیلدها را پر کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); //اگه فیلد ها خالی باشن، پیغام خطا نشون میده
                    return;
            }

            string[] a = File.ReadAllLines("products.txt"); //فایل محصولات رو میخونه
            for(int i=0;i<a.Length;i++)
            {
                string[] parts = a[i].Split('+'); //خط فعلی رو  به بخش ها ( با جدا کننده + ) تقسیم میکنه
                if(parts[0]==oldName)
                {
                    a[i] = newName + "+" + newPrice + "+" + newStock + "+" + newCategory; //اطلاعات جدید رو جایگزین میکنه
                    break; // از حلقه خارج میشه
                }
            }

            File.WriteAllLines("products.txt", a); //تغییرات رو توی فایل ذخیره میکنه

            this.Close(); // فرم رو میبنده
            MessageBox.Show("موفقیت", "!محصول ویرایش شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //پیغام موفقیت رو نمایش میده
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
