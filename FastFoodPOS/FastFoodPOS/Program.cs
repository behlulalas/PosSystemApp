using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            BonusSkins.Register();
            Application.Run(new MainForm());
        }
    }
}
