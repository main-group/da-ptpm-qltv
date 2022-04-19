using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;
using DAL;

namespace GUI_DevExpress
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

            var frm = (dynamic)null;

            if (!File.Exists("connect-db.dba") || !Entities.TestConnectionEF())
            {
                frm = new FrmCauHinh("modify");
            }
            else
            {
                frm = new FrmTrangChu();
            }

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(frm);
        }
    }
}
