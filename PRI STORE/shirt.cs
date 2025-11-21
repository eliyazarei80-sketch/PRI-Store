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
    public partial class shirt : Form
    {
        public shirt()
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
            linkLabel1.Links.Add(0, 6, "https://torob.com/p/9011e6da-6ba0-4741-9f6b-85fccf71e10b/%D8%AA%DB%8C%D8%B4%D8%B1%D8%AA-%D8%A8%D8%A7%D9%84%D9%86%D8%B3%DB%8C%D8%A7%DA%AF%D8%A7/"); // لینک جدید رو به 6 کاراکتر اول "توضیحات" متصل می‌کنه

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
        private string userinfo; // متغیری برای ذخیره اطلاعات کاربر مثل نام کاربری
        public shirt(Product p, string info)
        {
            InitializeComponent(); // تنظیمات اولیه فرم رو لود می‌کنه
            product = p; // اطلاعات محصول رو از ورودی ذخیره می‌کنه
            userinfo = info; // اطلاعات کاربر رو از ورودی ذخیره می‌کنه
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void shirt_Load(object sender, EventArgs e)
        {

        }
        private void panel2_Click(object sender, EventArgs e)    // رویداد کلیک برای پنل 2 رو تعریف می‌کنه که با کلیک کاربر اجرا می‌شه
        {
            string productName = "تیشرت بالنسیاگا";             // متغیری به اسم productName تعریف می‌کنه و مقدارش رو به "تیشرت بالنسیاگا" (نام محصول) تنظیم می‌کنه

            // بررسی می‌کنه که کاربر وارد سیستم شده باشه یا نه
            if (string.IsNullOrEmpty(Program.UserSession.GetUsername()) || string.IsNullOrEmpty(Program.UserSession.GetPassword()))    // شرطی که چک می‌کنه نام کاربری یا رمز عبور خالی نباشه
            {
                MessageBox.Show("خطا", "!لطفاً ابتدا وارد شوید", MessageBoxButtons.OK, MessageBoxIcon.Error);    // اگه نام کاربری یا رمز عبور خالی باشه، پیغام خطای "لطفاً ابتدا وارد شوید" نمایش می‌ده
                return;                                                                                         // اجرای متد رو متوقف می‌کنه و از ادامه اجرای کد جلوگیری می‌کنه
            }

            // سفارش رو با ترکیب اطلاعات کاربر و نام محصول می‌سازه
            string order = Program.UserSession.GetUsername() + "+" + Program.UserSession.GetPassword() + "+" + productName;    // یه رشته به اسم order می‌سازه که شامل نام کاربری، رمز عبور و نام محصول با جداکننده + هست
            string ordersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.txt");                              // مسیر فایل orders.txt رو با ترکیب دایرکتوری جاری برنامه و نام فایل می‌سازه
            try                                                                                                               // بلاک try برای مدیریت خطاهای احتمالی شروع می‌شه
            {
                File.AppendAllText(ordersFile, order + "\n");                                                                   // متن سفارش رو به انتهای فایل orders.txt اضافه می‌کنه و خط جدید (\n) اضافه می‌کنه
                MessageBox.Show(productName + " موفقیت", "!با موفقیت خریداری شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  // پیغام موفقیت با نمایش نام محصول و متن "با موفقیت خریداری شد" نشون می‌ده
            }
            catch (Exception ex)                                                                                              // اگه خطایی توی بلاک try رخ بده، این بخش اجرا می‌شه
            {
                MessageBox.Show("خطا", "خطا در ذخیره سفارش: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);          // پیغام خطا با جزئیات خطا (ex.Message) نمایش می‌ده
                return;
            }
        }
    }
}

