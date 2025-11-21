using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI_STORE
{
    public class Session
    {
        private string username; // متغیر خصوصی برای نام کاربری
        private string password; // متغیر خصوصی برای رمز عبور

        
        public void SetUserInfo(string user, string pass)// متد برای ست کردن اطلاعات
        {
            username = user; // ذخیره نام کاربری
            password = pass; // ذخیره رمز عبور
        }

        
        public string GetUsername()// متد برای گرفتن نام کاربری
        {
            return username; // برگردوندن نام کاربری
        }

        
        public string GetPassword()// متد برای گرفتن رمز عبور
        {
            return password; // برگردوندن رمز عبور
        }
    }
}
