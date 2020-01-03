using IMS.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmLogin : Form
    {
        frmSettings MenuForma;
        public frmLogin(frmSettings MenuForma)
        {
            InitializeComponent();
            this.MenuForma = MenuForma;
            txtusername.Focus();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForma.ts_login.Enabled = true;
        }
        public string Hash(byte[] temp)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }
        Color HighlightColor = Color.LightGreen;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtusername.Text == "" || this.txtpassword.Text == "")
            {
                MessageBox.Show("Please write Username and Password for Login", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtusername.Focus();
            }
            else
            {
                sql = " SELECT* FROM Users WHERE Username = '" + txtusername.Text + "' and Password = '" + this.Hash(System.Text.Encoding.UTF8.GetBytes(txtpassword.Text)) + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    MenuForma.ts_loginas.Visible = true;
                    MenuForma.MenuEnabled();
                    MenuForma.ts_loginas.BackColor = HighlightColor;
                   // MenuForma.ts_loginas.ForeColor = HighlightColor;
                   MenuForma.ts_loginas.Text=""+txtusername.Text+"";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This account "+txtusername.Text+" doesn`t match or your Password is wrong!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
