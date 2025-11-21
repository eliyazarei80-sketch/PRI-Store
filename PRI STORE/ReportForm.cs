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

namespace PRI_STORE
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent(); //تنظیمات اولیه فرم ( مثل دکمه و متن باکس ) رو از طراحی لود میکنه
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtReport.Text = ""; // متن گزارش رو پاک میکنه تا گزارش جدید نمایش داده بشه

            if(!File.Exists("products.txt"))
            {
                txtReport.Text = "!فایل محصولات پیدا نشد"; // اگه فایل محصولات وجود نداشته باشه، پیغام خطا نشون میده
                return;
            }

            string[] lines = File.ReadAllLines("products.txt"); // خطوط فایل محصولات رو میخونه
            int totalProducts = 0; //متغیری برای شمارش کل محصولات
            int totalStock = 0; //متغیری برای محاسبه مجموع موجودی 
            int lowStockCount = 0; // متغیری برای شمارش محصولات با موجودی کم

            for(int i=0;i<lines.Length;i++)
            {
                string[] parts = lines[i].Split('+'); // خط فعلی رو به بخش ها (با جدا کننده ی +) تقسیم میکنه
                if(parts.Length==4)
                {
                    totalProducts++; // تعداد کل محصولات رو نمایش میده 
                    totalStock += int.Parse(parts[2]); // موجودی فعلی رو به مجموع موجودی اضافه میکنه
                    if(int.Parse(parts[2])<5)
                    {
                        lowStockCount++; //اگه موجودی کمتر از 5 باشه ، شمارنده ی محصولات با موجودی کم رو افزایش میده
                    }
                }
            }

            txtReport.Text += "تعداد کل محصولات: " + totalProducts + "\r\n"; // تعداد کل محصولات رو به گزارش اضافه میکنه
            txtReport.Text += "مجموع موجودی: " + totalStock + "\r\n"; // مجموع موجودی رو به گزارش اضافه میکنه
            txtReport.Text += "تعداد محصولات با موجودی کم: " + lowStockCount + "\r\n"; // تعداد محصولات با موجودی کم رو به گزارش اضافه میکنه

            if(totalProducts==0)
            {
                txtReport.Text = "!هیچ محصولی در فایل نیست"; //  اگه هیچ محصولی وجود نداشته باشه ، پیغام اطلاع رسانی نشون میده
            }
        }
    }
}
