using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRI_STORE
{
   public  class FileManager
    {
       private static string productsFile = "prodcts.txt";  // مسیر فایل برای ذخیره محصولات
       private static string usersFile = "users.txt";       // مسیر فایل برای ذخیره کاربران 

       public static void SaveProducts(List<Product> products)
       {
           List<string> lines = new List<string>(); // لیستی برای ذخیره خطوط محصولات ایجاد میکنه
           foreach(var product in products )
           {
               string line = product.Name + "+" + product.Price + "+" + product.Stock + "+" + product.Category + "+" + product.Sellrid + "+" + product.ImagePath + "+" + product.Description;
               lines.Add(line); //هر محصول رو به صورت یک خط با کارکتر '+' از هم جدا و به لیست اضافه میکنه
           }
           File.WriteAllLines(productsFile, lines); // همه ی خطوط رو تو فایل productsFile ذخیره میکنه

       }

       public static List<Product> LoadProducts()
       {
           List<Product> products = new List<Product>(); //لیستی برای ذخیره محصولات لود شده ایجاد میکنه
           if(File.Exists(productsFile)) // اول چک میکنه که فایل productsFile وجود داشته باشه
           {
               string[] lines = File.ReadAllLines(productsFile); // همه ی خطوط فایل رو میخونه 
               foreach (string line in lines )
               {
                   string[] parts = line.Split('+'); // خط رو با '+' جدا میکنه
                   Product p = new Product(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), parts[3], parts[4], parts[5], parts[6]); // شی محصول از قسمت ها میسازه ، توضیح دقیق تر اینکه این تکه ها به ترتیب نام، قیمت،موجودی،دسته بندی،شناسه فروشنده،مسیرتصویروتوضیحات رو میگیره و یه محصول جدید میسازه"
                   products.Add(p); //محصول رو به لیست اضافه میکنه
               }
           }
           return products; //لیست محصولات رو برمیگردونه
       }

       public static void SaveUsers(List<User> users)
       {
           List<string> lines = new List<string>(); //لیستی برای ذخیره خطوط کاربران ایجاد میکنه
           foreach(var user in users)
           {
               string line = user.FirstName + "+" + user.LastName + "+" + user.City + "+" + user.Phone + "+" + user.Nationalid + "+" + user.Username + "+" + user.Password;
               lines.Add(line); //هر کاربر را به صورت یک خط با جداکننده+ به لیست اضافه میکنه

           }
           File.WriteAllLines(usersFile, lines); // همه ی خطوط رو تو فایل users.txt ذخیره میکنه
       }

       public static List<User> LoadUsers()
       {
           List<User> users = new List<User>(); //لیستی برای ذخیره کاربران لود شده ایجاد میکنه
           if(File.Exists(usersFile)) // چک میکنه که فایل users.txt وجود داشته باشه
           {
               string[] lines = File.ReadAllLines(usersFile);// همه خطوط فایل رو میخونه 
               foreach(string line in lines )
               {
                   string[] parts = line.Split('+'); // خط رو با + جدا میکنه 
                   User u = new User(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]); // شی کاربر از قسمت ها میسازه
                   users.Add(u); // کاربر رو به لیست اضافه میکنه
               }
           }
           return users; //لیست کاربران رو برمیگردونه 
       }
 
    }
}
