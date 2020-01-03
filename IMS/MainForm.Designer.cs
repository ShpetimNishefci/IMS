namespace IMS
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ts_Invertory = new System.Windows.Forms.ToolStripButton();
            this.ts_Settings = new System.Windows.Forms.ToolStripButton();
            this.ts_users = new System.Windows.Forms.ToolStripButton();
            this.ts_reports = new System.Windows.Forms.ToolStripButton();
            this.ts_login = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ts_about = new System.Windows.Forms.ToolStripButton();
            this.ts_exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ts_loginas = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.ts_Invertory,
            this.ts_Settings,
            this.ts_users,
            this.ts_reports,
            this.ts_login,
            this.toolStripLabel3,
            this.ts_about,
            this.ts_exit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(88, 777);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(87, 32);
            this.toolStripLabel2.Text = "MENU";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 15);
            this.toolStripLabel1.Text = "____________________";
            // 
            // ts_Invertory
            // 
            this.ts_Invertory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ts_Invertory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Invertory.Image = ((System.Drawing.Image)(resources.GetObject("ts_Invertory.Image")));
            this.ts_Invertory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Invertory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Invertory.Name = "ts_Invertory";
            this.ts_Invertory.Size = new System.Drawing.Size(80, 97);
            this.ts_Invertory.Text = "Inventory";
            this.ts_Invertory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Invertory.Click += new System.EventHandler(this.ts_Invertory_Click);
            // 
            // ts_Settings
            // 
            this.ts_Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Settings.Image = ((System.Drawing.Image)(resources.GetObject("ts_Settings.Image")));
            this.ts_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Settings.Name = "ts_Settings";
            this.ts_Settings.Size = new System.Drawing.Size(76, 97);
            this.ts_Settings.Text = "Settings";
            this.ts_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Settings.Click += new System.EventHandler(this.ts_Settings_Click);
            // 
            // ts_users
            // 
            this.ts_users.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_users.Image = ((System.Drawing.Image)(resources.GetObject("ts_users.Image")));
            this.ts_users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_users.Name = "ts_users";
            this.ts_users.Size = new System.Drawing.Size(76, 97);
            this.ts_users.Text = "Users";
            this.ts_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_users.Click += new System.EventHandler(this.ts_users_Click);
            // 
            // ts_reports
            // 
            this.ts_reports.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_reports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_reports.Image = ((System.Drawing.Image)(resources.GetObject("ts_reports.Image")));
            this.ts_reports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_reports.Name = "ts_reports";
            this.ts_reports.Size = new System.Drawing.Size(76, 97);
            this.ts_reports.Text = "Repors";
            this.ts_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_reports.Click += new System.EventHandler(this.ts_reports_Click);
            // 
            // ts_login
            // 
            this.ts_login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_login.Image = global::IMS.Properties.Resources.login_IN1;
            this.ts_login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_login.Name = "ts_login";
            this.ts_login.Size = new System.Drawing.Size(76, 97);
            this.ts_login.Text = "Login";
            this.ts_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_login.Click += new System.EventHandler(this.ts_login_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(107, 15);
            this.toolStripLabel3.Text = "____________________";
            // 
            // ts_about
            // 
            this.ts_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_about.Image = ((System.Drawing.Image)(resources.GetObject("ts_about.Image")));
            this.ts_about.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_about.Name = "ts_about";
            this.ts_about.Size = new System.Drawing.Size(76, 97);
            this.ts_about.Text = "About";
            this.ts_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_about.Click += new System.EventHandler(this.ts_about_Click);
            // 
            // ts_exit
            // 
            this.ts_exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_exit.Image = ((System.Drawing.Image)(resources.GetObject("ts_exit.Image")));
            this.ts_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_exit.Name = "ts_exit";
            this.ts_exit.Size = new System.Drawing.Size(76, 97);
            this.ts_exit.Text = "Exit";
            this.ts_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_exit.Click += new System.EventHandler(this.ts_exit_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_loginas});
            this.toolStrip2.Location = new System.Drawing.Point(88, 752);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1213, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ts_loginas
            // 
            this.ts_loginas.BackColor = System.Drawing.Color.LightGreen;
            this.ts_loginas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_loginas.Image = global::IMS.Properties.Resources.Users_80;
            this.ts_loginas.ImageTransparentColor = System.Drawing.Color.Lime;
            this.ts_loginas.Name = "ts_loginas";
            this.ts_loginas.Size = new System.Drawing.Size(77, 22);
            this.ts_loginas.Text = "Login as:";
            this.ts_loginas.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1301, 777);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Main  -  Inventory Management System                                            " +
    "                                                           Shpettimn";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_Invertory;
        private System.Windows.Forms.ToolStripButton ts_Settings;
        private System.Windows.Forms.ToolStripButton ts_users;
        public System.Windows.Forms.ToolStripButton ts_login;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton ts_reports;
        private System.Windows.Forms.ToolStripButton ts_exit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripLabel ts_loginas;
        private System.Windows.Forms.ToolStripButton ts_about;
    }
}

