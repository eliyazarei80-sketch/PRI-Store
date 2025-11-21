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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent(); //تنظیمات اولیه فرم (مثل تصاویر و متن ها ) رو از طراحی لود میکنه
        }

        private void about_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // وقتی فرم لود میشه ، پنجره به حالت تمام صفحه در میاد
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //یه نمونه جدید از فرم لاگین (فرم 1 ) میسازه
            f1.Show(); //اونو نمایش میده
            this.Hide(); //این فرم ( درباره ما ) رو مخفی میکنه تا به صفحه لاگین برگردیم
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
