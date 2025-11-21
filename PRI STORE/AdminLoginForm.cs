using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRI_STORE;

namespace PRI_STORE
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent(); //تنظیمات اولیه فرم (مثل باکس ها و پنل ها ) رو از طراحی لود میکنه
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();  //یک نمونه جدید از فرم یک (فرم لاگین ) میسازه
            f1.Show();      // فرم یک (فرم لاگین ) رو نمایش میده
            this.Hide(); //این فرم (لاگین ادمین ) رو مخفی میکنه تا به صفحه قبل (لاگین ) برگردیم
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.MediumPurple;   //وقتی موس روی تصویر میاد ، رنگ پنل 2 به بنفش متوسط تغییر میکنه
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 2 به حالت پیش فرض برمیگرده 
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            string correctUsername="iliya_zarei";   // نام کاربری درست برای ادمین
            string correctPassword = "ew.19921";    // رمز عبور درست برای ادمین

            string username = txtUsername.Text;     // نام کاربری وارد شده توسط کاربر رو میخونه
            string password = txtPassword.Text;     // رمز عبور وارد شده توسط کاربر رو میخونه

            if(username==correctUsername && password==correctPassword)
            {
                Program.UserSession.SetUserInfo(txtUsername.Text, txtPassword.Text);    // اطلاعات نام کاربری و رمز عبور رو توی سشن برنامه ذخیره می‌کنه تا در طول استفاده در دسترس باشه
                MessageBox.Show("ایلیا زارعی عزیز خوش آمدید", "ادمین وارد شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  // اگه اطلاعات درست باشه، پیام خوش آمد گویی نشون میده

                Admin a = new Admin();  // یه نمونه از فرم ادمین میسازه
                a.Show();  //فرم ادمین رو نمایش میده
                this.Hide();  // این فرم (لاگین ادمین ) رو مخفی میکنه
            }
            else
            {
                MessageBox.Show("خطا", "!نام کاربری یا رمز عبور اشتباه است", MessageBoxButtons.OK, MessageBoxIcon.Error);  // در غیر این صورت (اگه اطلاعات اشتباه باشه ) پیام خطا نشون میده
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
