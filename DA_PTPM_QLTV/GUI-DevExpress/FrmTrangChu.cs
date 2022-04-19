using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS;
using System.IO;

namespace GUI_DevExpress
{
    public partial class FrmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTrangChu()
        {

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TheLoaiBus theLoaiBus = new TheLoaiBus();
            grcDSTheLoai.DataSource = theLoaiBus.GetAllDTO();
        }

        private void FrmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}