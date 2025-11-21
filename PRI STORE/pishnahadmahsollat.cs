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
    public partial class pishnahadmahsollat : Form
    {
        public pishnahadmahsollat()
        {
            InitializeComponent(); // تنظیمات اولیه فرم ( مثل تصاویر و پنل ها ) رو از طراحی لود میکنه
        }
        private string userinfo; // متغیری برای ذخیره اطلاعات کاربر مثل نام کاربری 
        public pishnahadmahsollat(string info)
        {
            InitializeComponent(); // تنظیمات اولیه فرم رو لود میکنه
            userinfo = info; // اطلاعات کاربر رو از ورودی ذخیره میکنه
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Silver; // وقتی موس روی تصویر میاد ، رنگ پنل 1 به نقره ای تغییر میکنه
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control; // وقتی موس از تصویر دور میشه ، رنگ پنل 1 به حالت پیش فرض برمیگرده
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.DeepPink; // وقتی موس روی تصویر میاد ، رنگ پنل 2 به صورتی تیره تغییر میکنه
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control; // وقتی موس از تصویر دور میشه ، رنگ پنل 2 به حالت پیش فرض برمیگرده
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Crimson; // وقتی موس روی تصویر میاد ، رنگ پنل 3 به سرخ تیره تغییر میکنه
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control; // وقتی موس از تصویر دور میشه ، رنگ پنل 3 به حالت پیش فرض برمیگرده
        }

        private void pishnahadmahsollat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // فرم رو به حالت تمام صفحه در میاره
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close(); // فرم رو میبنده
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            koot k = new koot(); // یه نمونه از فرم koot میسازه
            k.Show(); // اونو نمایش میده
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mantoo m = new mantoo(); // یه نمونه از فرم mantoo میسازه
            m.Show(); // اونو نمایش میده
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hoodii h = new hoodii(); // یه نمونه از فرم hoodii میسازه
            h.Show(); // اونو نمایش میده
        }
    }
}
