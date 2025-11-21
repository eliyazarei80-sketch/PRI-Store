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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent(); //تنظیمات اولیه فرم ( مثل کمبو باکس و دکمه ) رو از طراحی رو لود میکنه
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ورزشی"); // گزینه ورزشی رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("لوازم آرایش"); // گزینه لوازم آرایش رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("لباس"); // گزینه لباس رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("خوراکی"); // گزینه خوراکی رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("گوشی"); // گزینه گوشی رو به کمبو باکس اضافه میکنه
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category = comboBox1.Text; // دسته بندی انتخابشده رو از کمبوباکس میخونه

            if(category=="دسته بندی")
            {
                MessageBox.Show("خطا", "!لطفا یک دسته بندی انتخاب کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه دسته بندی انتخاب نشده باشه، پیغام خطا نشون میده
                return;
            }

            string foundProducts = ""; // رشته ای برای ذخیره نام محصولات پیدا شده

            if(File.Exists("products.txt"))
            {
                string[] lines = File.ReadAllLines("products.txt"); // اول برسی میکنه فایل وجود داره ، بعد خطوط فایل محصولات رو میخونه
                for(int i=0;i<lines.Length;i++)
                {
                    string[] parts = lines[i].Split('+'); // خط فعلی رو به بخش ها ( با جدا کننده ی + ) تقسیم میکنه
                    if(parts[3]==category)
                    {
                        if(foundProducts=="")
                        {
                            foundProducts = parts[0]; // اگه اولین محصول باشه، نامش رو به رشته اضافه میکنه
                        }
                        else
                        {
                            foundProducts = foundProducts + "+" + parts[0]; // نام محصول رو با + به رشته ی قبلی اضافه میکنه
                        }
                    }
                        
                    
                }

            }
            if(foundProducts=="")
            {
                MessageBox.Show("نتیجه", "!محصولی در این دسته بندی پیدا نشد", MessageBoxButtons.OK, MessageBoxIcon.Error); //اگه محصولی پیدا نشه ، پیغام عدم وجود نشون میده
            }
            else
            {
                MessageBox.Show("محصولات:" + foundProducts, "نتیجه", MessageBoxButtons.OK); // لیست محصولات پیدا شده رو نمایش میده
            }
        }
    }
}
