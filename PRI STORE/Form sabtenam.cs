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
    public partial class Form_sabtenam : Form
    {
        public Form_sabtenam()
        {
            InitializeComponent(); //تنظیمات اولیه فرم ( مثل فیلد های متنی ، دکمه ها و پنل ) رو از طراحی لود میکنه
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Black; //وقتی موس روی تصویر میاد،  رنگ پنل 1 به سیاه تغییر میکنه
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control; // وقتی موس از تصویر دور میشه ، رنگ پنل 1 به حالت پیش فرض برمیگرده
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); // یه نمونه از فرم 1 میسازه
            f1.Show(); // فرم 1 رو نمایش میده
            this.Hide(); //این فرم ( ثبت نام ) رو مخفی میکنه
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text==""||txtLastName.Text==""||txtCity.Text==""||txtPhone.Text==""||txtNationalid.Text==""||txtUsername.Text==""||txtPassword.Text=="")
            {
                MessageBox.Show("خطا", "!لطفا همه ی فیلدها را پر کنید",MessageBoxButtons.OK,MessageBoxIcon.Error ); // اگه فیلد ها خالی باشن ، پیغام خطا نشون میده
                return;
            }
            for(int i=0;i<txtFirstName.Text.Length;i++)
            {
                if(!char.IsLetter(txtFirstName.Text[i]) && txtFirstName.Text[i]!=' ')
                {
                    MessageBox.Show("خطا", "!نام باید فقط حروف باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); //  اگه نام شامل کاراکتر غیر حرفی باشه ، پیغام خطا نشون میده
                    return;
                }
            }


            for(int i=0;i<txtLastName.Text.Length;i++)
            {
                if(!char.IsLetter(txtLastName.Text[i]) && txtLastName.Text[i] !=' ')
                {
                    MessageBox.Show("خطا", "!نام خانوادگی باید فقط حروف باشد", MessageBoxButtons.OK, MessageBoxIcon.Error);  // اگه نام خانوادگی شامل کاراکتر غیر حرفی باشه ، پیغام خطا نشون میده
                    return;
                }
            }

             for(int i=0;i<txtCity.Text.Length;i++)
             {
                 if(!char.IsLetter(txtCity.Text[i]) && txtCity.Text[i] !=' ')
                 {
                     MessageBox.Show("خطا", "!شهر باید فقط حروف باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه شهر شامل کاراکتر غیر حرفی باشه ، پیغام خطا نشون میده
                     return;
                 }
             }

             for (int i = 0; i < txtPhone.Text.Length; i++)
             {
                 if (!char.IsDigit(txtPhone.Text[i]))
                 {
                     MessageBox.Show("خطا", "!شماره تلفن باید فقط عدد باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه شماره تلفن شامل کاراکتر غیر عددی باشه ، پیغام خطا نشون میده
                     return;
                 }
             }
            if(txtPhone.Text.Length!=11)
            {
                MessageBox.Show("خطا", "!شماره تلفن باید 11 رقم باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه طول شماره تلفن 11 نباشه، پیغام خطا نشون میده
                return;
            }

            for(int i=0;i<txtNationalid.Text.Length;i++)
            {
                if(!char.IsDigit(txtNationalid.Text[i]))
                {
                    MessageBox.Show("خطا", "!کد ملی باید فقط عدد باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه کد ملی شامل کاراکتر غیر عددی باشه ، پیغام خطا نشون میده
                    return;
                }
            }
            if(txtNationalid.Text.Length !=10)
            {
                MessageBox.Show("خطا", "!کد ملی باید 10 رقم باشد", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه طول کدملی 10 نباشه ، پیغام خطا نشون میده
                return;
            }

            if(txtPassword.Text.Length < 8)
            {
                MessageBox.Show("خطا", "!رمز عبور باید حداقل 8 کاراکتر باشد", MessageBoxButtons.OK, MessageBoxIcon.Error);// اگه رمز عبور کمتر از  8 کاراکتر باشه ، پیغام خطا نشون میده
                return;
            }

            List<User> users = FileManager.LoadUsers(); // لیست کاربران رو از فایل لود میکنه
            for(int i=0;i<users.Count;i++)
            {
                if(users[i].Username==txtUsername.Text )
                {
                    MessageBox.Show("خطا", "!این نام کاربری قبلا ثبت شده است", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه نام کاربری تکراری باشه ، پیغام خطا نشون میده
                    return;
                }
            }

            User newUser = new User(txtFirstName.Text, txtLastName.Text, txtCity.Text, txtPhone.Text, txtNationalid.Text, txtUsername.Text, txtPassword.Text); // یه کاربر جدید میسازه
            users.Add(newUser); // کاربر جدید رو به لیست اضافه میکنه

            FileManager.SaveUsers(users); // لیست کاربران رو توی فایل ذخیره میکنه
            

            MessageBox.Show("موفقیت", "!ثبت نام با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // پیغام موفقیت رو نشون میده

            this.Close(); // فرم رو میبنده
            Form1 f1 = new Form1(); // یه نمونه از فرم 1 میسازه
            f1.Show(); // فرم 1 رو نمایش میده

        }

        private void Form_sabtenam_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus(); //فوکوس رو روی فیلد نام قرار میده که کاربر سریع شروع به تایپ کنه
        }
    }
}
