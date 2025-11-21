using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //فایل رو بخونه
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_STORE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // تنظیمات اولیه فرم (مثل باکس‌ها و دکمه‌ها) رو از طراحی لود می‌کنه
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // فرم رو به حالت تمام صفحه در میاره
            txtUsername.Focus(); // فوکوس رو روی باکس نام کاربری می‌ذاره تا کاربر سریع شروع به تایپ کنه
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.DarkRed; // وقتی موس روی تصویر اول میاد، رنگ پنل 1 به قرمز تیره تغییر می‌کنه
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control; // وقتی موس از تصویر دور می‌شه، رنگ پنل به حالت پیش‌فرض برمی‌گرده
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.DarkBlue; // وقتی موس روی تصویر دوم میاد، رنگ پنل 2 به آبی تیره تغییر می‌کنه
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control; // رنگ پنل 2 به حالت پیش‌فرض برمی‌گرده
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gold; // وقتی موس روی تصویر سوم میاد، رنگ پنل 3 به طلایی تغییر می‌کنه
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control; // رنگ پنل 3 به حالت پیش‌فرض برمی‌گرده
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; // اگر چک‌باکس انتخاب بشه، رمز رو به صورت واضح (بدون ستاره) نشون می‌ده
            }
            else
            {
                txtPassword.PasswordChar = '*'; // در غیر این صورت (یعنی اگه چک‌باکس انتخاب نشده باشه) رمز با ستاره مخفی می‌شه
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_sabtenam sabt = new Form_sabtenam(); // یه نمونه از فرم ثبت‌نام می‌سازه
            sabt.Show(); // فرم ثبت‌نام رو نمایش می‌ده
            this.Hide(); // این فرم (لاگین) رو مخفی می‌کنه
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            about a = new about(); // یه نمونه از فرم درباره ما می‌سازه
            a.Show(); // فرم درباره ما رو نمایش می‌ده
            this.Hide(); // این فرم (لاگین) رو مخفی می‌کنه
        }

        private string userinfo;

        private void button2_Click(object sender, EventArgs e)
        {
            // چک می‌کنه که فیلدهای نام کاربری و رمز عبور خالی نباشن
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("خطا", "!لطفا نام کاربری و رمز عبور را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // پیام خطا نمایش می‌ده
                return;
            }

            // لیست کاربران رو از فایل لود می‌کنه
            List<User> users = FileManager.LoadUsers();

            bool found = false; // متغیری برای نشان دادن پیدا شدن کاربر
            for (int i = 0; i < users.Count; i++)
            {
                // چک می‌کنه که نام کاربری و رمز عبور با اطلاعات ذخیره‌شده مطابقت داره
                if (users[i].Username == txtUsername.Text && users[i].Password == txtPassword.Text)
                {
                    found = true;
                    break; // از حلقه خارج می‌شه چون کاربر پیدا شده
                }
            }

            if (found)
            {
                // اطلاعات کاربر رو توی سشن ذخیره می‌کنه
                Program.UserSession.SetUserInfo(txtUsername.Text, txtPassword.Text);

                MessageBox.Show("موفقیت", "!ورود با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // پیام موفقیت نمایش می‌ده
                mahsollat m = new mahsollat(); // یه نمونه از فرم محصولات می‌سازه
                m.Show(); // فرم محصولات رو نمایش می‌ده
                this.Hide(); // فرم فعلی (لاگین) رو مخفی می‌کنه
            }
            else
            {
                MessageBox.Show("خطا", "!نام کاربری یا رمز عبور اشتباه است", MessageBoxButtons.OK, MessageBoxIcon.Error); // پیام خطا نمایش می‌ده
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminLoginForm a = new AdminLoginForm(); // یک نمونه از فرم لاگین ادمین می‌سازه
            a.ShowDialog(); // فرم لاگین ادمین رو به صورت دیالوگ نمایش می‌ده
            this.Close(); // این فرم (لاگین) رو می‌بنده
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
