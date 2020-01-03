using IMS.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace IMS
{
    public partial class frmUsernames : Form
    {
        public frmUsernames()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, idja;
        private void rriteid()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }

        private void designdatagridview()
        {
            dgvUsernames.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvUsernames.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsernames.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvUsernames.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvUsernames.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvUsernames.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsernames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsernames.AllowUserToResizeColumns = false;
            dgvUsernames.AllowUserToResizeRows = false;

        }
        public string Hash(byte[] temp)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "" || this.txtPassword.Text=="")
            {
                MessageBox.Show("Username and Password must be filled up", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtUsername.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtUsername.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteid();
                        sql = "insert into Users(Nr,Username,Password) values('" + txtid.Text + "','" + txtUsername.Text + "','" + this.Hash(System.Text.Encoding.UTF8.GetBytes(txtPassword.Text)) + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtUsername.Text + " Username has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Users WHERE Username LIKE '%" + txtUsername.Text + "%'";
                        config.Load_DTG(sql, dgvUsernames);
                        designdatagridview();
                        dgvUsernames.Columns[0].Visible = false;
                        dgvUsernames.Columns[2].Visible = false;
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtUsername.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtUsername.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Users set Username='" + this.txtUsername.Text + "',Password='" + this.Hash(System.Text.Encoding.UTF8.GetBytes(txtPassword.Text)) + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtUsername.Text + " Username has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Users WHERE Username LIKE '%" + txtUsername.Text + "%'";
                        config.Load_DTG(sql, dgvUsernames);
                        designdatagridview();
                        dgvUsernames.Columns[0].Visible = false;
                        dgvUsernames.Columns[2].Visible = false;
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void dgvUsernames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dgvUsernames.CurrentRow.Cells[1].Value.ToString();
            idja = dgvUsernames.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtUsername.Focus();
            }
            else if (txtUsername.Text == "admin" || txtUsername.Text == "Admin" || txtUsername.Text == "ADMIN")
            {
                                MessageBox.Show("Can`t delete Admin", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtUsername.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtUsername.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Users WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtUsername.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * from Users ";
                        config.Load_DTG(sql, dgvUsernames);
                        designdatagridview();
                        dgvUsernames.Columns[0].Visible = false;
                        dgvUsernames.Columns[2].Visible = false;
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Users ;";
            config.Load_DTG(sql, dgvUsernames);
            designdatagridview();
            dgvUsernames.Columns[0].Visible = false;
            dgvUsernames.Columns[2].Visible = false;
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            btnload_Click(sender, e);
        }
    }
}
