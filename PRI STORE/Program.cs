using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_STORE
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2()); // وقتی بخوایم اپلیکیشن رو ران کنیم (اجرا کنیم ) با این فرم (فرم 2 )باز بشه
        }

        public static Session UserSession = new Session(); // نمونه سراسری از Session
    }

    
   
}
