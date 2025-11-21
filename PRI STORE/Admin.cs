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
using Microsoft.VisualBasic;
using System.IO;


namespace PRI_STORE
{
    public partial class Admin : Form 
    {
        private void LoadProducts()
        {
            dataGridView1.Rows.Clear(); // جدول رو خالی میکنه تا محصولات جدید لود شن
            string s = "products.txt"; // مسیر فایل محصولات رو مشخص میکنه
            if(File.Exists(s)) // چک میکنه که فایل وجود داشته باشه
            {
                string[] a = File.ReadAllLines(s); // همه ی خطوط فایل رو میخونه 
                for(int i=0;i<a.Length;i++)
                {
                    string[] parts = a[i].Split('+'); // خط رو با + جدا میکنه
                    if(parts.Length==4) // اگه خط ، 4 قسمت  (نام ، قیمت ، موجودی ، دسته بندی) داشته باشه
                    {
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3]); // اطلاعات رو به جدول اضافه میکنه
                    }
                }
            }
        }
        public Admin()
        {
            InitializeComponent(); // تنظیمات اولیه فرم ( مثل جدول و آیکون ها)رو از طراحی لود میکنه
            LoadProducts(); // محصولات رو موقع لود فرم توی جدول نمایش میده
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // فرم رو به حالت تمام صفحه در میاره
        }

        private void ویرایشمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.OrangeRed; // وقتی موس روی تصویر میاد،رنگ پنل 1 به نارنجی تیره تغییر میکنه
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control; // وقتی موس از تصویر دور میشه ، رنگ پنل 1 به حالت پیش فرض برمیگرده
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gold; // وقتی موس روی تصویر میاد، رنگ پنل 3 به طلایی تغییر میکنه
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control; //وقتی موس از تصویر دور میشه ، رنگ پنل 3 به حالت پیش فرض برمیگرده
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.Cyan; // وقتی موس روی تصویر میاد، رنگ پنل 4 به فیروزه ای تغییر میکنه
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;// وقتی موس از تصویر دور میشه رنگ پنل 4 به حالت پیش فرض برمیگرده
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.Crimson; //وقتی موس روی تصویر میاد ، رنگ پنل 5 به سرخ تیره تغییر میکنه
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control; //  وقتی موس از تصویر دور میشه ، رنگ پنل 5 به حالت پیش فرض برمیگرده
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.Silver; //وقتی موس روی تصویر میاد ، رنگ پنل 6 به نقره ای تغییر میکنه
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;  //  وقتی موس از تصویر دور میشه ، رنگ پنل 6 به حالت پیش فرض برمیگرده
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BackColor = Color.DarkOrange; //وقتی موس روی تصویر میاد ، رنگ پنل 7 به نارنجی تیره تغییر میکنه
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = SystemColors.Control;  //  وقتی موس از تصویر دور میشه ، رنگ پنل 7 به حالت پیش فرض برمیگرده
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.Lime; //وقتی موس روی تصویر میاد ، رنگ پنل 8 به سبزه لایم تغییر میکنه
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = SystemColors.Control; //  وقتی موس از تصویر دور میشه ، رنگ پنل 8 به حالت پیش فرض برمیگرده
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("تایید خروج", "آیا واقعا میخوای خارج شی؟", MessageBoxButtons.OKCancel); // از کازبر تایید میگیره

            if(dr==DialogResult.OK)
            {
                Application.Exit(); // اگه تایید بشه ، برنامه رو میبنده 
            }
        }

        private void نمایشپیشنهادهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pishnahadmahsollat p = new pishnahadmahsollat(); // یه نمونه از فرم پیشنهاد محصولات میسازه
            p.Show(); //فرم پیشنهاد محصولات رو نمایش میده
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); // یه نمونه از فرم لاگین (فرم 1 ) میسازه
            f1.Show(); // فرم لاگین رو نمایش میده
            this.Hide(); // این فرم (ادمین رو) مخفی میکنه 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            mahsollat m = new mahsollat(); // یه نمونه از فرم اضافه کردن محصول میسازه
            m.Show(); // فرم محصولات رو نمایش میده
            this.Hide(); //این فرم (ادمین رو ) مخفی میکنه
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddProductForm a = new AddProductForm(); // یه نمونه از فرم اضافه کردن محصول میسازه
            a.ShowDialog(); //فرم رو به صورت دیالوگ نمایش میده

            LoadProducts(); //بعد از بستن فرم،محصولات رو دوباره لود میکنه
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0) //چک میکنه که محصولی انتخاب شده باشه
            {
                MessageBox.Show("خطا", "!یک محصول انتخاب کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه انتخاب نشده ، پیغام خطا نشون میده
                return;
            }

            string name = dataGridView1.SelectedRows[0].Cells["NameColumn"].Value.ToString();        // نام محصول انتخاب‌شده از ستون "NameColumn" رو به صورت رشته می‌خونه
            string price = dataGridView1.SelectedRows[0].Cells["PriceColumn"].Value.ToString();     // قیمت محصول انتخاب‌شده از ستون "PriceColumn" رو به صورت رشته می‌خونه
            string stock = dataGridView1.SelectedRows[0].Cells["StockColumn"].Value.ToString();     // موجودی محصول انتخاب‌شده از ستون "StockColumn" رو به صورت رشته می‌خونه
            string category = dataGridView1.SelectedRows[0].Cells["CategoryColumn"].Value.ToString(); // دسته‌بندی محصول انتخاب‌شده از ستون "CategoryColumn" رو به صورت رشته می‌خونه

            EditProductForm Edit = new EditProductForm(name, price, stock, category);              // یه نمونه از فرم ویرایش محصول با اطلاعات خوانده‌شده می‌سازه
            Edit.ShowDialog();                                                                    // فرم ویرایش رو به صورت دیالوگ نمایش می‌ده تا ادمین تغییرات رو اعمال کنه
            LoadProducts();                                                                       // بعد از بستن فرم، محصولات رو دوباره از فایل لود می‌کنه و جدول رو به‌روزرسانی می‌کنه

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0) //چک میکنه که محصولی انتخاب شده باشه
            {
                MessageBox.Show("خطا", "!یک محصول انتخاب کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه انتخاب نشده ، پیغام خطا نشون میده
                return;
            }

            string name = dataGridView1.SelectedRows[0].Cells["NameColumn"].Value.ToString(); // نام محصول انتخاب شده رو میخونه

            string[] lines = File.ReadAllLines("products.txt"); //همه ی خطوط فایل محصولات رو میخونه

            List<string> newLines = new List<string>(); //لیستی برای خطوط جدید ایجاد میکنه

            for(int i=0;i<lines.Length;i++)
            {
                string[] parts = lines[i].Split('+'); // خط رو با '+'جدا میکنه 
                if(parts[0]!=name) //  اگه نام محصول با نام انتخاب شده متفاوت باشه
                {
                    newLines.Add(lines[i]); // خط رو به لیست جدید اضافه میکنه
                }

            }

            File.WriteAllLines("products.txt", newLines.ToArray()); // فایل رو با خطوط جدید ذخیره میکنه

            LoadProducts(); // محصولات رو دوباره لود میکنه

            MessageBox.Show("موفقیت", "!محصول حذف شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // پیغام موفقیت نشون میده
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SearchForm s = new SearchForm(); // یک نمونه از فرم جست و جو میسازه
            s.ShowDialog(); //فرم جست و جو رو به صورت دیالوگ نمایش میده
        }

        private void گزارشگیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karbaran k = new karbaran();    // یه نمونه جدید از فرم کاربران (karbaran) می‌سازه
            k.ShowDialog();                 // فرم کاربران رو به صورت دیالوگ نمایش می‌ده تا کاربر بتونه لیست کاربران رو ببینه یا ویرایش کنه
        }

        private void کالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm r = new ReportForm();    // یه نمونه جدید از فرم گزارش (ReportForm) می‌سازه
            r.ShowDialog();                     // فرم گزارش رو به صورت دیالوگ نمایش می‌ده تا کاربر بتونه گزارش‌ها رو ببینه یا تحلیل کنه
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
