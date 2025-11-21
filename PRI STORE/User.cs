using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI_STORE
{
  public   class User
    {
      public string FirstName { get; set; }  // نام کاربر را ذخیره میکند
      public string LastName { get; set; }   // نام خانوادگی کاربر را ذخیره می کند
      public string City { get; set; }       // شهر محل زندگی کاربر را ذخیره می کند
      public string Phone { get; set; }      // شماره تلفن کاربر را ذخیره می کند
      public string Nationalid { get; set; } // کد ملی کاربر را ذخیره می کند
      public string Username { get; set; }   // نام کاربری برای ورود به سیستم را ذخیره می کند
      public string Password { get; set; }   // رمز عبور برای ورود به سیستم را ذخیره می کند
      public List<Product> ProductsForSale { get; set; }  //لیست محصولاتی که کاربر برای فروش دارد را ذخیره می کند 

      public User(string firstName,string lastName,string city, string phone,string nationalid, string username, string password)
      {
          FirstName = firstName;  // نام کاربر را از ورودی ست میکند 
          LastName = lastName;    // نام خانوادگی کاربر را از ورودی ست میکند
          City = city;            // شهر کاربر را از ورودی ست میکند
          Phone = phone;          // شماره تلفن کاربر را از ورودی ست میکند
          Nationalid = nationalid; // کد ملی کاربر را از ورودی ست میکند
          Username = username;     // نام کاربری را از ورودی ست میکند
          Password = password;     // رمز عبور را از ورودی ست میکند
        
         ProductsForSale = new List<Product>();  // یک لیست جدید برای محصولات درحال فروش ایجاد میکند

          // ست میکند یعنی یک چیزی رو انگار تو یه جعبه بزاریم.( ذخیره کنیم) مثلا برای اولی قلی رو میگیره و تویه جعبه ی فرست نیم میزاره پس "ست میکند"یعنی گذاشتن "قلی" تویه جعبه "از ورودی" یعنی اون قلی از چیزی که ما به برنامه دادیم اومده
      }
    }
}
