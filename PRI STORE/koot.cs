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
    public partial class koot : Form
    {
        public koot()
        {
            InitializeComponent(); // تنظیمات اولیه فرم ( مثل پنل ها و لینک ) رو از طراحی لود میکنه
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close(); // فرم رو میبنده
        }
        private Product product; // متغیری برای ذخیرهاطلاعات محصول
        private string userinfo; // متغیری برای ذخیره اطلاعات کاربر مثل نام کاربری
        public koot(Product p,string info)
        {
            InitializeComponent(); //تنظیمات اولیه فرم رو لود میکنه
            product = p; //اطلاعات محصول رو از ورودی ذخیره میکنه
            userinfo = info; //اطلاعات کاربر رو از ورودی ذخیره میکنه
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            string productName = "کت 20% تخفیف"; // نام محصول رو مشخص می‌کنه
                                                 // چک می‌کنه که کاربر وارد شده باشه
            if (string.IsNullOrEmpty(Program.UserSession.GetUsername()) || string.IsNullOrEmpty(Program.UserSession.GetPassword()))
            {
                MessageBox.Show("خطا", "!لطفاً ابتدا وارد شوید", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // سفارش رو با ترکیب اطلاعات نام کاربری، رمز عبور و نام محصول می‌سازه
            string order = Program.UserSession.GetUsername() + "+" + Program.UserSession.GetPassword() + "+" + productName;
            string ordersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.txt"); // مسیر فایل سفارش‌ها رو مشخص می‌کنه
            try
            {
                File.AppendAllText(ordersFile, order + "\n"); // سفارش رو به انتهای فایل orders.txt اضافه می‌کنه
                MessageBox.Show(productName + "موفقیت", "!با موفقیت خریداری شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // پیام موفقیت با نام محصول نمایش می‌ده
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا", "خطا در ذخیره سفارش: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); // خطای احتمالی رو نمایش می‌ده
                return;
            }
            this.Close(); // فرم رو می‌بنده
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void koot_Load(object sender, EventArgs e)
        {

        }
    }
}
