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
using DAL;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GUI_DevExpress
{
    public partial class FrmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection GetConnection(string serverName, string userName, string password, string database)
        {
            return new SqlConnection(string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", serverName, database, userName, password));
        }

        string config = "";
        int flag = 0;

        public FrmCauHinh(string config)
        {
            this.config = config;
            InitializeComponent();
            if (config.Equals("modify"))
            {
                btnThoat.Text = "Trang chủ";
                btnThoat.Enabled = false;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = GetConnection(cmbServer.Text, txtUsername.Text, txtPassword.Text, cmbDatabase.Text);
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (config.Equals("modify") && flag != 0)
                {
                    btnThoat.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn file cấu hình kết nối cơ sở dữ liệu";
            op.Filter = "Text Files (*.dba)|*.dba|All Files(*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                Connect conn = (Connect)bf.Deserialize(fs);

                string serverName = Encryptor.Decrypt(conn.ServerName, "qwertyuiop", true);
                string userName = Encryptor.Decrypt(conn.UserName, "qwertyuiop", true);
                string password = Encryptor.Decrypt(conn.Password, "qwertyuiop", true);
                string database = Encryptor.Decrypt(conn.Database, "qwertyuiop", true);

                cmbServer.Text = serverName;
                txtUsername.Text = userName;
                txtPassword.Text = password;
                cmbDatabase.Text = database;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string serverName = Encryptor.Encrypt(cmbServer.Text, "qwertyuiop", true);
            string userName = Encryptor.Encrypt(txtUsername.Text, "qwertyuiop", true);
            string password = Encryptor.Encrypt(txtPassword.Text, "qwertyuiop", true);
            string database = Encryptor.Encrypt(cmbDatabase.Text, "qwertyuiop", true);

            Connect conn = new Connect(serverName, userName, password, database);

            try
            {
                conn.SaveFile();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag++;
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (config.Equals("modify"))
            {
                this.Hide();
                FrmTrangChu frm = new FrmTrangChu();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void cmbDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cmbDatabase.Items.Clear();

            string connStr = string.Format("server={0}; User ID={1}; pwd={2}", cmbServer.Text, txtUsername.Text, txtPassword.Text);
            string query = "SELECT NAME FROM SYS.DATABASES";

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Server, username hoặc password không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                // throw;
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            IDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbDatabase.Items.Add(dr[0].ToString());
            }
        }
    }
}