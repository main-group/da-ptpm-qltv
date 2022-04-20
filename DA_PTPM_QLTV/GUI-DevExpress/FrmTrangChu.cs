using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI_DevExpress
{
    public partial class FrmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        TheLoaiBus theLoaiBus = new TheLoaiBus();

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void FrmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}