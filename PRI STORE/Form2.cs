using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_STORE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); //این متد تنظیمات اولیه فرم (مثل دکمه و متن ) رو از طراحی لود میکنه
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Red; //وقتی موس روی دکمه میاد، رنگ متن دکمه به قرمز تغییر میکنه(برای جذابیت) بیشتر
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //چون یک کلاس غیر استاتیک هست یک نمونه جدید از فرم اول (Form1) می سازه.
            f1.Show(); //فرم اول رو نمایش میده
            this.Hide(); // فرم 2 (فرمی که هستیم توش )رو مخفی میکنه تا به فرم بعدی بریم
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black; //وقتی موس از دکمه دور میشه ، رنگ متن دکمه به مشکی برمیگرده
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // وقتی فرم لود میشه ، پنجره به حالت تمام صفحه در میاد
        }
    }
}
