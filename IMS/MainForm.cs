using IMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                foreach (Control ctl in this.Controls)
                {
                    try
                    {
                        System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                        Mdi.BackColor = System.Drawing.Color.White;
                    }
                    catch (Exception a)
                    {
                    
                    }
                }
            }
            MenuDisabled();
            ts_login_Click(sender, e);
        }

        public void MenuEnabled()
        {
            ts_Invertory.Enabled = true;
            ts_reports.Enabled = true;
            ts_Settings.Enabled = true;
            ts_users.Enabled = true;
            ts_login.Enabled = true;
            ts_login.Text = "Logout";
        }
        public void MenuDisabled()
        {
            ts_Invertory.Enabled = false;
            ts_reports.Enabled = false;
            ts_Settings.Enabled = false;
            ts_users.Enabled = false;
            ts_login.Text = "Login";
        }
        
        private void ts_Invertory_Click(object sender, EventArgs e)
        {


            if (System.Windows.Forms.Application.OpenForms["frmInvertory"] as frmInvertory == null)
            {
                this.IsMdiContainer = true;
                frmInvertory F2 = new frmInvertory();
                F2.MdiParent = this;
                F2.Show();
            }
            else
            {
                frmInvertory F2 = (frmInvertory)Application.OpenForms["frmInvertory"];
                F2.Focus();
            }  
        }

        private void ts_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ts_Settings_Click(object sender, EventArgs e)
        {

            if (System.Windows.Forms.Application.OpenForms["frmedit"] as frmedit == null)
            {
                this.IsMdiContainer = true;
                frmedit F3 = new frmedit();
                F3.MdiParent = this;
                F3.Show();
            }
            else
            {
                frmedit F3 = (frmedit)Application.OpenForms["frmedit"];
                F3.Focus();
            }  
        }

        private void ts_reports_Click(object sender, EventArgs e)
        {

            if (System.Windows.Forms.Application.OpenForms["frmReports"] as frmReports == null)
            {
                this.IsMdiContainer = true;
                frmReports F2 = new frmReports();
                F2.MdiParent = this;
                F2.Show();
            }
            else
            {
                frmReports F2 = (frmReports)Application.OpenForms["frmReports"];
                F2.Focus();
            }  
        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }
        private void ts_login_Click(object sender, EventArgs e)
        {
            if (ts_login.Text=="Login")
            {
                closeForm();
                showFrm(new frmLogin(this));
                ts_login.Enabled = false;
            }
            else
            {
                closeForm();
                MenuDisabled();
                ts_login.Text = "Login";
                showFrm(new frmLogin(this));
                ts_login.Enabled = false;
                ts_loginas.Visible = false;
            }
        }

        private void ts_users_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["frmUsernames"] as frmUsernames == null)
            {
                this.IsMdiContainer = true;
                frmUsernames F2 = new frmUsernames();
                F2.MdiParent = this;
                F2.Show();
            }
            else
            {
                frmUsernames F2 = (frmUsernames)Application.OpenForms["frmUsernames"];
                F2.Focus();
            }  
        }

        private void ts_about_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["frm_about"] as frm_about == null)
            {
                this.IsMdiContainer = true;
                frm_about F2 = new frm_about();
                F2.MdiParent = this;
                F2.Show();
            }
            else
            {
                frm_about F2 = (frm_about)Application.OpenForms["frm_about"];
                F2.Focus();
            }  
        }
    }
}
