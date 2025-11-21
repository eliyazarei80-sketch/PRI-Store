using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI_STORE
{
   public  class Product
    {
       public string Name { get; set; } // نام محصول را ذخیره میکند
       public int Price { get; set; }  // قیمت محصول را به صورت عدد ذخیره میکند
       public int Stock { get; set; }  // موجودی محصول (تعداد در انبار ) را ذخیره میکند
       public string Category { get; set;}  // دسته بندی محصول ( مثل لباس یا گوشی ) را ذخیره میکند
       public string Sellrid { get; set; }  // شناسه فروشنده ای که محصول رو میفروشه را ذخیره میکند
       public string ImagePath { get; set; }  // مسیر فایل تصویر محصول را ذخیره میکند 
       public string Description { get; set; } // توضیحات مربوط به محصول را ذخیره میکند
       

       public Product (string name, int price, int stock, string category, string sellerid, string imagepath,string description)
       {
           Name = name;   // نام محصول را از ورودی ست میکند
           Price = price;  // قیمت محصول را از ورودی ست میکند
           Stock = stock; //موجودی محصول را از ورودی ست میکند
           Category = category; //دسته بندی محصول را از ورودی ست میکند
           Sellrid = sellerid;  // شناسه فروشنده را از ورودی ست میکند
           ImagePath = imagepath; // مسیر تصویر محصول را از ورودی ست میکند
           Description = description; // توضیحات محصول را از ورودی ست میکند

           // ست میکند یعنی یک چیزی رو انگار تو یه جعبه بزاریم.( ذخیره کنیم) مثلا برای اولی قلی رو میگیره و تویه جعبه ی فرست نیم میزاره پس "ست میکند"یعنی گذاشتن "قلی" تویه جعبه "از ورودی" یعنی اون قلی از چیزی که ما به برنامه دادیم اومده
       }

    }
}
