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
   
    public partial class mahsollat : Form
    {
        public mahsollat()
        {
            InitializeComponent(); //تنظیمات اولیه فرم ( مثل تصاویر و باکس جست و جو ) رو از طراحی لود میکنه
        }
        private string userinfo; //متغیری برای ذخیره اطلاعات کاربر  مثل نام کاربری
        public mahsollat(string info)
        {
            InitializeComponent(); //تنظیمات اولیه فرم رو لود میکنه
            userinfo = info; // اطلاعات کاربر رو از ورودی ذخیره میکنه
        }
        private void mahsollat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // فرم رو به حالت تمام صفحه در میاره
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.IndianRed; //وقتی موس روی تصویر میاد، رنگ پنل 3 به قرمز هندی تغییر میکنه
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control; //وقتی موس از تصویر دور میشه، رنگ پنل 3 به حالت پیش فرض برمیگرده
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.MediumPurple; //وقتی موس روی تصویر میاد، رنگ پنل 4 به بنفش متوسط تغییر میکنه
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 4 به حالت پیش فرض برمیگرده
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.YellowGreen; //وقتی موس روی تصویر میاد، رنگ پنل 5 به سبز زرد تغییر میکنه
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 5 به حالت پیش فرض برمیگرده
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.Black; //وقتی موس روی تصویر میاد، رنگ پنل 6 به مشکی تغییر میکنه
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 6 به حالت پیش فرض برمیگرده
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BackColor = Color.DeepPink; //وقتی موس روی تصویر میاد، رنگ پنل 7 به صورتی تیره تغییر میکنه
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 7 به حالت پیش فرض برمیگرده
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.DimGray; //وقتی موس روی تصویر میاد، رنگ پنل 8 به خاکستری تیره تغییر میکنه
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 8 به حالت پیش فرض برمیگرده
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.DarkBlue; //وقتی موس روی تصویر میاد، رنگ پنل 9 به آبی تیره تغییر میکنه
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 9 به حالت پیش فرض برمیگرده
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Dastebandi d = new Dastebandi(); // یه نمونه از فرم دسته بندی میسازه
            d.Show(); //فرم دسته بندی رو نمایش میده
            this.Hide(); //این فرم (محصولات ) رو مخفی میکنه
         
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            panel11.BackColor = Color.Lime; //وقتی موس روی تصویر میاد، رنگ پنل 11 به سبز لایم تغییر میکنه
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = SystemColors.Control;  //وقتی موس از تصویر دور میشه، رنگ پنل 11 به حالت پیش فرض برمیگرده
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            barca b = new barca(); // یه نمونه از فرم barca میسازه
            b.Show(); // اون رو نمایش میده
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pishnahadmahsollat p = new pishnahadmahsollat();  //یه نمونه از فرم پیشنهاد محصولات میسازه
            p.Show(); // اونو نمایش میده
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shalvarzanane s = new shalvarzanane(); // یه نمونه از فرم شلوار زنانه میسازه
            s.Show(); // اونو نمایش میده
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bereng b = new bereng(); // یه نمونه از فرم برنج میسازه
            b.Show(); // اونو نمایش میده
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dastkesh d = new dastkesh(); // یه نمونه از فرم دستکش میسازه
            d.Show(); // اونو نمایش میده
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            iphone i = new iphone(); // یه نمونه از فرم آیفون میسازه
            i.Show(); // اونو نمایش میده
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            podresorat p = new podresorat(); // یه نمونه از فرم پودر صورت میسازه
            p.Show(); // اونو نمایش میده
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bache b = new bache(); // یه نمونه از فرم بچه میسازه
            b.Show(); // اونو نمایش میده
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text; //  متن وارد شده توی باکس سرچ رو میخونه
            


            if(search=="")
            {
                MessageBox.Show("خطا", "!لطفا چیزی برای جستجو وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه باکس خالی باشه ، پیغام خطا نشون میده
                return;
            }
            if(search=="توپ") // اگه سرچ کاربر برابر با "توپ" بود
            {
                toop t = new toop(); // فرم توپ رو میسازه
                t.Show(); // اونو نمایش میده
            }
            else if (search == "ست ورزشی مردانه") // در غیر این صورت اگر سرچ کاربر برابر "ست ورزشی مردانه "بود
            {
                setmardane s = new setmardane(); // فرم ست ورزشی مردانه رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "ست ورزشی زنانه") // در غیر این صورت اگر سرچ کاربر برابر "ست ورزشی زنانه "بود
            {
                setzanane s = new setzanane(); // فرم ست ورزشی زنانه رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "کفش ورزشی") // در غیر این صورت اگر سرچ کاربر برابر "کفش ورزشی "بود
            {
                kafsh k = new kafsh(); // فرم کفش ورزشی رو میسازه
                k.Show(); // اونو نمایش میده
            }
            else if (search == "پودر صورت") // در غیر این صورت اگر سرچ کاربر برابر "پودر صورت "بود
            {
                podresorat p = new podresorat(); // فرم پودر صورت رو میسازه
                p.Show(); // اونو نمایش میده
            }
            else if (search == "کرم") // در غیر این صورت اگر سرچ کاربر برابر "کرم "بود
            {
                kerem k = new kerem(); // فرم کرم رو میسازه
                k.Show(); // اونو نمایش میده
            }
            else if (search == "رژ") // در غیر این صورت اگر سرچ کاربر برابر "رژ "بود
            {
                roogh r = new roogh(); // فرم رژ رو میسازه
                r.Show(); // اونو نمایش میده
            }
            else if (search == "لاک") // در غیر این صورت اگر سرچ کاربر برابر "لاک "بود
            {
                laak l = new laak(); // فرم لاک رو میسازه
                l.Show(); // اونو نمایش میده
            }
            else if (search == "آیفون") // در غیر این صورت اگر سرچ کاربر برابر "آیفون "بود
            {
                iphone i = new iphone(); // فرم آیفون رو میسازه
                i.Show(); // اونو نمایش میده
            }
            else if (search == "شیامی" || search == "شیائومی") // در غیر این صورت اگر سرچ کاربر برابر "شیامی یا شیائومی "بود
            {
                siyomi s = new siyomi(); // فرم  رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "نوکیا") // در غیر این صورت اگر سرچ کاربر برابر "نوکیا "بود
            {
                nokia n = new nokia(); // فرم نوکیا رو میسازه
                n.Show(); // اونو نمایش میده
            }
            else if (search == "سامسونگ") // در غیر این صورت اگر سرچ کاربر برابر "سامسونگ "بود
            {
                sumsung s = new sumsung(); // فرم سامسونگ رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "برنج") // در غیر این صورت اگر سرچ کاربر برابر "برنج "بود
            {
                bereng b = new bereng(); // فرم برنج رو میسازه
                b.Show(); // اونو نمایش میده
            }
            else if (search == "پیتزا") // در غیر این صورت اگر سرچ کاربر برابر "پیتزا "بود
            {
                pizza p = new pizza(); // فرم پیتزا رو میسازه
                p.Show(); // اونو نمایش میده
            }
            else if (search == "نوشابه") // در غیر این صورت اگر سرچ کاربر برابر "نوشابه "بود
            {
                noshabe n = new noshabe(); // فرم نوشابه رو میسازه
                n.Show(); // اونو نمایش میده
            }
            else if (search == "رب") // در غیر این صورت اگر سرچ کاربر برابر "رب "بود
            {
                rob r = new rob(); // فرم رب رو میسازه
                r.Show(); // اونو نمایش میده
            }
            else if (search == "تیشرت") // در غیر این صورت اگر سرچ کاربر برابر "تیشرت "بود
            {
                shirt s = new shirt(); // فرم تیشرت رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "مانتو") // در غیر این صورت اگر سرچ کاربر برابر "مانتو "بود
            {
                manto m = new manto(); // فرم مانتو رو میسازه
                m.Show(); // اونو نمایش میده
            }
            else if (search == "کفش پاشنه بلند") // در غیر این صورت اگر سرچ کاربر برابر "کفش پاشنه بلند "بود
            {
                pashneboland p = new pashneboland(); // فرم کفش پاشنه بلند رو میسازه
                p.Show(); // اونو نمایش میده
            }
            else if (search == "پیراهن") // در غیر این صورت اگر سرچ کاربر برابر "پیراهن "بود
            {
                pirhan p = new pirhan(); // فرم پیراهن رو میسازه
                p.Show(); // اونو نمایش میده
            }
            else if (search == "کت" || search == "کت شلوار") // در غیر این صورت اگر سرچ کاربر برابر "کت یا کت شلوار "بود
            {
                koot k = new koot(); // فرم  رو میسازه
                k.Show(); // اونو نمایش میده
            }
            else if (search == "هودی") // در غیر این صورت اگر سرچ کاربر برابر "هودی "بود
            {
                hoodii h = new hoodii(); // فرم هودی رو میسازه
                h.Show(); // اونو نمایش میده
            }
            else if (search == "پالتو") // در غیر این صورت اگر سرچ کاربر برابر "پالتو "بود
            {
                mantoo m = new mantoo(); // فرم پالتو رو میسازه
                m.Show(); // اونو نمایش میده
            }
            else if (search == "لباس ورزشی" || search == "لباس ورزشی بارسا") // در غیر این صورت اگر سرچ کاربر برابر "لباس ورزشی بارسا یا لباس ورزشی "بود
            {
                barca b = new barca(); // فرم  رو میسازه
                b.Show(); // اونو نمایش میده
            }
            else if (search == "شلوار زنانه") // در غیر این صورت اگر سرچ کاربر برابر "شلوار زنانه "بود
            {
                shalvarzanane s = new shalvarzanane(); // فرم شلوار زنانه رو میسازه
                s.Show(); // اونو نمایش میده
            }
            else if (search == "دستکش دروازه بانی") // در غیر این صورت اگر سرچ کاربر برابر "دستکش دروازه بانی "بود
            {
                dastkesh d = new dastkesh(); // فرم  رو میسازه
                d.Show(); // اونو نمایش میده
            }
            else if (search == "لباس بچگانه") // در غیر این صورت اگر سرچ کاربر برابر "لباس بچگانه "بود
            {
                bache b = new bache(); // فرم  رو میسازه
                b.Show(); // اونو نمایش میده
            }
            else
            {
                MessageBox.Show("اطلاع", "!محصولی با این نام پیدا نشد", MessageBoxButtons.OK, MessageBoxIcon.Information); // اگه محصول پیدا نشه، پیغام اطلاع رسانی نشون میده
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
