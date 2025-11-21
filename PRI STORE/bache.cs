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
    public partial class bache : Form
    {
        public bache()
        {
            InitializeComponent(); // تنظیمات اولیه فرم (مثل پنل‌ها و لینک) رو از طراحی لود می‌کنه
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close(); // فرم رو می‌بنده
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "توضیحات"; // متن لینک رو به "توضیحات" تغییر می‌ده
            linkLabel1.Links.Clear(); // لینک‌های قبلی رو پاک می‌کنه تا تداخل ایجاد نشه
            linkLabel1.Links.Add(0, 6, "https://bonnybaby.ir/"); // لینک جدید رو به 6 کاراکتر اول "توضیحات" متصل می‌کنه

            // باز کردن لینک توی مرورگر پیش‌فرض
            if (linkLabel1.Links[0].LinkData != null)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkLabel1.Links[0].LinkData.ToString(), // آدرس لینک رو به‌عنوان فایل مشخص می‌کنه
                    UseShellExecute = true // از سیستم برای اجرای لینک با برنامه پیش‌فرض (مرورگر) استفاده می‌کنه
                });
            }
        }

        private Product product; // متغیری برای ذخیره اطلاعات محصول
        private string userinfo; // متغیری برای ذخیره اطلاعات کاربر (اختیاری، فعلاً استفاده نمی‌شه)

        public bache(Product p, string info)
        {
            InitializeComponent(); // تنظیمات اولیه فرم رو لود می‌کنه
            product = p; // اطلاعات محصول رو از ورودی ذخیره می‌کنه
            userinfo = info; // اطلاعات کاربر رو از ورودی ذخیره می‌کنه (فعلاً استفاده نمی‌شه)
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            string productName = "تیشرت بچگانه";    // نام محصول مورد نظر (تیشرت بچگانه) رو به صورت ثابت تعریف می‌کنه

            // چک می‌کنه که کاربر وارد شده باشه
            if (string.IsNullOrEmpty(Program.UserSession.GetUsername()) || string.IsNullOrEmpty(Program.UserSession.GetPassword()))
            {
                MessageBox.Show("خطا", "!لطفاً ابتدا وارد شوید", MessageBoxButtons.OK, MessageBoxIcon.Error);    // اگه نام کاربری یا رمز عبور خالی باشه، پیغام خطا نشون می‌ده
                return;                                                                                         // اجرای متد رو متوقف می‌کنه
            }

            // سفارش رو با ترکیب اطلاعات می‌سازه
            string order = Program.UserSession.GetUsername() + "+" + Program.UserSession.GetPassword() + "+" + productName;    // سفارش رو با ترکیب نام کاربری، رمز عبور و نام محصول می‌سازه
            string ordersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.txt");                              // مسیر فایل orders.txt رو با استفاده از دایرکتوری جاری برنامه تعیین می‌کنه
            try
            {
                File.AppendAllText(ordersFile, order + "\n");                                                                   // سفارش رو به انتهای فایل orders.txt اضافه می‌کنه
                MessageBox.Show(productName + "موفقیت", "!با موفقیت خریداری شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  // پیغام موفقیت با نام محصول نشون می‌ده
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا", "خطا در ذخیره سفارش: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);          // اگه خطایی توی ذخیره‌سازی رخ بده، پیغام خطا با جزئیات نشون می‌ده
                return;                                                                                                         // اجرای متد رو متوقف می‌کنه
            }
            this.Close();                                                                                                       // فرم فعلی رو می‌بنده بعد از ثبت موفقیت‌آمیز سفارش
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bache_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
