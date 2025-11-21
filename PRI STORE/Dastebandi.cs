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
    public partial class Dastebandi : Form
    {
        public Dastebandi()
        {
            InitializeComponent(); //تنظیمات اولیه فرم ( مثل کمبو باکس و دکمه ) رو از طراحی لود میکنه
        }

        private void Dastebandi_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ورزشی"); //گزینه ورزشی رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("لوازم آرایش"); //گزینه لوازم آرایش رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("لباس"); //گزینه لباس  رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("خوراکی"); //گزینه خوراکی رو به کمبو باکس اضافه میکنه
            comboBox1.Items.Add("گوشی"); //گزینه گوشی رو به کمبو باکس اضافه میکنه
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="دسته بندی")
            {
                MessageBox.Show("خطا", "!لطفا یک دسته انتخاب کنید", MessageBoxButtons.OK, MessageBoxIcon.Error); // اگه دسته بندی انتخاب نشده باشه، پیغام خطا نشون میده
                return;
            }

            if(comboBox1.Text=="ورزشی") // اگه تکس ، کمبو باکس برابر "ورزشی " بود
            {
                varzeshi v = new varzeshi(); //یه نمونه از فرم ورزشی میسازه
                v.Show(); // فرم ورزشی رو نمایش میده
                this.Hide(); //این فرم ( دسته بندی رو ) مخفی میکنه
            }
            else if (comboBox1.Text == "لوازم آرایش") // در غیر این صورت اگر تکس ، کمبو باکس برابر "لوازم آرایش " بود
            {
                Arayeshi a = new Arayeshi(); //یه نمونه از فرم آرایشی میسازه
                a.Show(); // فرم آرایشی رو نمایش میده
                this.Hide(); //این فرم ( دسته بندی رو ) مخفی میکنه
            }
            else if (comboBox1.Text == "لباس") // در غیر این صورت اگر تکس ، کمبو باکس برابر "لباس " بود
            {
                lebass l = new lebass(); //یه نمونه از فرم لباس میسازه
                l.Show(); // فرم لباس رو نمایش میده
                this.Hide(); //این فرم ( دسته بندی رو ) مخفی میکنه
            }
            else if (comboBox1.Text == "خوراکی") // در غیر این صورت اگر تکس ، کمبو باکس برابر "خوراکی " بود
            {
                khoraki k = new khoraki(); //یه نمونه از فرم خوراکی میسازه
                k.Show(); // فرم خوراکی رو نمایش میده
                this.Hide(); //این فرم ( دسته بندی رو ) مخفی میکنه
            }
            else if (comboBox1.Text == "گوشی") // در غیر این صورت اگر تکس ، کمبو باکس برابر "گوشی " بود
            {
                mobile m = new mobile(); //یه نمونه از فرم موبایل میسازه
                m.Show(); // فرم موبایل رو نمایش میده
                this.Hide(); //این فرم ( دسته بندی رو ) مخفی میکنه
            }
        }
    }
}
