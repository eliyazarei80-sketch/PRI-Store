using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_STORE
{
    public partial class karbaran : Form    // تعریف یه کلاس عمومی به اسم karbaran که از فرم (Form) ارث‌بری می‌کنه و بخشی از طراحی رابط کاربریه
    {
        public karbaran()                    // سازنده (Constructor) کلاس karbaran که وقتی فرم ساخته می‌شه اجرا می‌شه
        {
            InitializeComponent();           // اجزای رابط کاربری فرم (مثل دکمه‌ها و لیبل‌ها) رو مقداردهی اولیه می‌کنه
        }

        private void label5_Click(object sender, EventArgs e)    // رویداد کلیک برای لیبل 5 رو تعریف می‌کنه که با کلیک کاربر اجرا می‌شه
        {
            
        }

        private List<User> LoadUsers()    // یه متد خصوصی تعریف می‌کنه که لیست کاربران رو از فایل لود می‌کنه و نوع برگشتیش لیست از کلاس User هست
        {
            List<User> users = new List<User>();    // یه لیست جدید از نوع User می‌سازه که کاربران رو توی خودش ذخیره می‌کنه
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");    // مسیر فایل users.txt رو با ترکیب دایرکتوری جاری برنامه می‌سازه
            if (File.Exists(filePath))    // چک می‌کنه که فایل users.txt وجود داره یا نه
            {
                string[] lines = File.ReadAllLines(filePath);    // همه خطوط فایل رو می‌خونه و توی یه آرایه رشته ذخیره می‌کنه
                foreach (string line in lines)    // برای هر خط توی آرایه خطوط، این حلقه اجرا می‌شه
                {
                    string[] parts = line.Split('+');    // خط رو با علامت '+' جدا می‌کنه و توی یه آرایه قسمت‌ها ذخیره می‌کنه
                    if (parts.Length == 7)    // چک می‌کنه که تعداد قسمت‌ها برابر 7 باشه (7 فیلد: نام، نام خانوادگی، شهر، تلفن، کد ملی، نام کاربری، رمز عبور)
                    {
                        users.Add(new User(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));    // یه کاربر جدید با اطلاعات قسمت‌ها می‌سازه و به لیست اضافه می‌کنه
                    }
                }
            }
            return users;    // لیست کاربران رو برمی‌گردونه
        }

        private void btnSearch_Click(object sender, EventArgs e)    // رویداد کلیک برای دکمه جستجو رو تعریف می‌کنه که با کلیک کاربر اجرا می‌شه
        {
            // مرحله ۱: گرفتن کد ملی از تکست‌باکس
            string nationalId = txtNationalCode.Text.Trim();    // متن داخل تکست‌باکس کد ملی رو می‌خونه و فاصله‌های اضافی رو حذف می‌کنه
            if (string.IsNullOrEmpty(nationalId))    // چک می‌کنه که کد ملی خالی باشه یا نه
            {
                MessageBox.Show("لطفاً کد ملی را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);    // اگه خالی باشه، پیغام خطا نمایش می‌ده
                return;    // اجرای متد رو متوقف می‌کنه
            }

            // مرحله ۲: چک کردن طول کد ملی (باید ۱۰ رقم باشه)
            if (nationalId.Length != 10)    // چک می‌کنه که طول کد ملی برابر 10 کاراکتر باشه یا نه
            {
                MessageBox.Show("کد ملی باید ۱۰ رقم باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);    // اگه طولش 10 نباشه، پیغام خطا نمایش می‌ده
                return;    // اجرای متد رو متوقف می‌کنه
            }

            // مرحله ۳: چک کردن که کد ملی فقط شامل عدد باشه
            if (!nationalId.All(char.IsDigit))    // چک می‌کنه که همه کاراکترهای کد ملی عدد باشن، اگه حروف داشته باشه خطا می‌ده
            {
                MessageBox.Show("کد ملی باید فقط شامل اعداد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);    // اگه حروف باشه، پیغام خطا نمایش می‌ده
                return;    // اجرای متد رو متوقف می‌کنه
            }

            // مرحله ۴: لود کردن لیست کاربران
            List<User> users = LoadUsers();    // متد LoadUsers رو فراخونی می‌کنه و لیست کاربران رو توی متغیر users ذخیره می‌کنه

            // مرحله ۵: جستجو بر اساس کد ملی
            User foundUser = users.FirstOrDefault(u => u.Nationalid == nationalId);    // اولین کاربری که کد ملیش با nationalId مطابقت داره رو پیدا می‌کنه
            if (foundUser != null)    // چک می‌کنه که کاربری پیدا شده یا نه
            {
                // مرحله ۶: پر کردن لیبل‌ها با اطلاعات کاربر
                lblFirstName.Text = foundUser.FirstName;    // متن لیبل نام رو با نام کاربر پر می‌کنه
                lblLastName.Text = foundUser.LastName;      // متن لیبل نام خانوادگی رو با نام خانوادگی کاربر پر می‌کنه
                lblCity.Text = foundUser.City;              // متن لیبل شهر رو با شهر کاربر پر می‌کنه
                lblPhone.Text = foundUser.Phone;            // متن لیبل تلفن رو با شماره تلفن کاربر پر می‌کنه
                lblUsername.Text = foundUser.Username;      // متن لیبل نام کاربری رو با نام کاربری کاربر پر می‌کنه
                lblPassword.Text = foundUser.Password;      // متن لیبل رمز عبور رو با رمز عبور کاربر پر می‌کنه
            }
            else    // اگه کاربری پیدا نشد
            {
                // مرحله ۷: اگه کاربر پیدا نشد، پیام خطا و خالی کردن لیبل‌ها
                MessageBox.Show("کاربری با این کد ملی یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);    // پیغام خطا نمایش می‌ده که کاربر پیدا نشده
                lblFirstName.Text = lblLastName.Text = lblCity.Text = lblPhone.Text = lblPassword.Text = lblUsername.Text = "";    // همه لیبل‌ها رو خالی می‌کنه
            }
        }

        private void karbaran_Load(object sender, EventArgs e)    // رویداد بارگذاری فرم karbaran رو تعریف می‌کنه که وقتی فرم لود می‌شه اجرا می‌شه
        {
            txtNationalCode.Focus();    // فوکوس رو روی تکست‌باکس کد ملی می‌ذاره تا کاربر بتونه فوراً شروع به تایپ کنه
        }
    }
}
