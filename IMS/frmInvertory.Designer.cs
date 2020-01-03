namespace IMS
{
    partial class frmInvertory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvertory));
            this.Label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmax = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblinc = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclearlist = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.paneli = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblf2 = new System.Windows.Forms.Label();
            this.lblf5 = new System.Windows.Forms.Label();
            this.lblf4 = new System.Windows.Forms.Label();
            this.lblf3 = new System.Windows.Forms.Label();
            this.lblf1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.txtManufacturer = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnexporttable = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paneli.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label6.Location = new System.Drawing.Point(272, 250);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 16);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "Search :";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(343, 249);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(263, 20);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 341);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblmax
            // 
            this.lblmax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmax.AutoSize = true;
            this.lblmax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmax.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(146, 252);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(14, 16);
            this.lblmax.TabIndex = 57;
            this.lblmax.Text = "1";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(86, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ITEM:";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(105, 252);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(19, 16);
            this.Label9.TabIndex = 51;
            this.Label9.Text = "of";
            // 
            // lblinc
            // 
            this.lblinc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblinc.AutoSize = true;
            this.lblinc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblinc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinc.Location = new System.Drawing.Point(69, 252);
            this.lblinc.Name = "lblinc";
            this.lblinc.Size = new System.Drawing.Size(14, 16);
            this.lblinc.TabIndex = 56;
            this.lblinc.Text = "1";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(96, 33);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(27, 16);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(129, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(251, 22);
            this.txtid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "SERIAL:";
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSerial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(129, 112);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(251, 22);
            this.txtSerial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "BARCODE :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarcode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(129, 85);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(251, 22);
            this.txtBarcode.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "MANUFACTURER:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "OWNER:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(477, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "Model :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "DATE:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "COMMENT :";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComment.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(529, 91);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(251, 22);
            this.txtComment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "LOCATION:";
            // 
            // btnclearlist
            // 
            this.btnclearlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclearlist.BackColor = System.Drawing.Color.Transparent;
            this.btnclearlist.ForeColor = System.Drawing.Color.Black;
            this.btnclearlist.Location = new System.Drawing.Point(945, 245);
            this.btnclearlist.Name = "btnclearlist";
            this.btnclearlist.Size = new System.Drawing.Size(106, 30);
            this.btnclearlist.TabIndex = 15;
            this.btnclearlist.Text = "&Clear List";
            this.btnclearlist.UseVisualStyleBackColor = false;
            this.btnclearlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(800, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 44);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export all &data to Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(529, 145);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(251, 23);
            this.cmbLocation.TabIndex = 8;
            // 
            // cmbOwner
            // 
            this.cmbOwner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(529, 62);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(251, 23);
            this.cmbOwner.TabIndex = 5;
            // 
            // paneli
            // 
            this.paneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneli.BackColor = System.Drawing.Color.White;
            this.paneli.Controls.Add(this.groupBox5);
            this.paneli.Controls.Add(this.btnReload);
            this.paneli.Controls.Add(this.txtModel);
            this.paneli.Controls.Add(this.txtManufacturer);
            this.paneli.Controls.Add(this.txtItem);
            this.paneli.Controls.Add(this.label13);
            this.paneli.Controls.Add(this.btnexporttable);
            this.paneli.Controls.Add(this.btnAll);
            this.paneli.Controls.Add(this.txtsearch);
            this.paneli.Controls.Add(this.Label6);
            this.paneli.Controls.Add(this.btnClose);
            this.paneli.Controls.Add(this.txtDate);
            this.paneli.Controls.Add(this.btnLast);
            this.paneli.Controls.Add(this.cmbOwner);
            this.paneli.Controls.Add(this.btnNext);
            this.paneli.Controls.Add(this.cmbLocation);
            this.paneli.Controls.Add(this.btnPrev);
            this.paneli.Controls.Add(this.btnFirst);
            this.paneli.Controls.Add(this.btnNew);
            this.paneli.Controls.Add(this.btnExport);
            this.paneli.Controls.Add(this.btnclearlist);
            this.paneli.Controls.Add(this.btnDelete);
            this.paneli.Controls.Add(this.label3);
            this.paneli.Controls.Add(this.txtComment);
            this.paneli.Controls.Add(this.btnUpdate);
            this.paneli.Controls.Add(this.label4);
            this.paneli.Controls.Add(this.label7);
            this.paneli.Controls.Add(this.btnSave);
            this.paneli.Controls.Add(this.label11);
            this.paneli.Controls.Add(this.label12);
            this.paneli.Controls.Add(this.label10);
            this.paneli.Controls.Add(this.txtBarcode);
            this.paneli.Controls.Add(this.label2);
            this.paneli.Controls.Add(this.txtSerial);
            this.paneli.Controls.Add(this.label5);
            this.paneli.Controls.Add(this.txtid);
            this.paneli.Controls.Add(this.Label8);
            this.paneli.Controls.Add(this.lblinc);
            this.paneli.Controls.Add(this.Label9);
            this.paneli.Controls.Add(this.Label1);
            this.paneli.Controls.Add(this.lblmax);
            this.paneli.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1066, 291);
            this.paneli.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lblf2);
            this.groupBox5.Controls.Add(this.lblf5);
            this.groupBox5.Controls.Add(this.lblf4);
            this.groupBox5.Controls.Add(this.lblf3);
            this.groupBox5.Controls.Add(this.lblf1);
            this.groupBox5.Location = new System.Drawing.Point(949, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(102, 204);
            this.groupBox5.TabIndex = 87;
            this.groupBox5.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(5, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "F10= Export All";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.Location = new System.Drawing.Point(5, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "F9= Export Table";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(5, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "F8 = Clear List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(5, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "F7 = See All";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(5, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "F6 = Reload";
            // 
            // lblf2
            // 
            this.lblf2.AutoSize = true;
            this.lblf2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblf2.Location = new System.Drawing.Point(5, 30);
            this.lblf2.Name = "lblf2";
            this.lblf2.Size = new System.Drawing.Size(57, 13);
            this.lblf2.TabIndex = 4;
            this.lblf2.Text = "F2 = Save";
            // 
            // lblf5
            // 
            this.lblf5.AutoSize = true;
            this.lblf5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblf5.Location = new System.Drawing.Point(5, 87);
            this.lblf5.Name = "lblf5";
            this.lblf5.Size = new System.Drawing.Size(54, 13);
            this.lblf5.TabIndex = 3;
            this.lblf5.Text = "F5 = New";
            // 
            // lblf4
            // 
            this.lblf4.AutoSize = true;
            this.lblf4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblf4.Location = new System.Drawing.Point(5, 68);
            this.lblf4.Name = "lblf4";
            this.lblf4.Size = new System.Drawing.Size(64, 13);
            this.lblf4.TabIndex = 2;
            this.lblf4.Text = "F4 = Delete";
            // 
            // lblf3
            // 
            this.lblf3.AutoSize = true;
            this.lblf3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblf3.Location = new System.Drawing.Point(5, 49);
            this.lblf3.Name = "lblf3";
            this.lblf3.Size = new System.Drawing.Size(68, 13);
            this.lblf3.TabIndex = 1;
            this.lblf3.Text = "F3 = Update";
            // 
            // lblf1
            // 
            this.lblf1.AutoSize = true;
            this.lblf1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblf1.Location = new System.Drawing.Point(5, 11);
            this.lblf1.Name = "lblf1";
            this.lblf1.Size = new System.Drawing.Size(66, 13);
            this.lblf1.TabIndex = 0;
            this.lblf1.Text = "F1 = Search";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = global::IMS.Properties.Resources._process_32;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReload.Location = new System.Drawing.Point(800, 125);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(136, 44);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "&Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(530, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 23);
            this.txtModel.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtManufacturer.FormattingEnabled = true;
            this.txtManufacturer.Location = new System.Drawing.Point(129, 139);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(251, 23);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtItem.FormattingEnabled = true;
            this.txtItem.Location = new System.Drawing.Point(129, 57);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(251, 23);
            this.txtItem.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 82;
            this.label13.Text = "Record:";
            // 
            // btnexporttable
            // 
            this.btnexporttable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexporttable.BackColor = System.Drawing.Color.Transparent;
            this.btnexporttable.ForeColor = System.Drawing.Color.Black;
            this.btnexporttable.Location = new System.Drawing.Point(800, 79);
            this.btnexporttable.Name = "btnexporttable";
            this.btnexporttable.Size = new System.Drawing.Size(136, 44);
            this.btnexporttable.TabIndex = 17;
            this.btnexporttable.Text = "Export &table data to Excel";
            this.btnexporttable.UseVisualStyleBackColor = false;
            this.btnexporttable.Click += new System.EventHandler(this.btnexporttable_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(833, 245);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(106, 30);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Show &all Data";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::IMS.Properties.Resources.close_sign_30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(674, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 36);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDate.Location = new System.Drawing.Point(529, 119);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(251, 20);
            this.txtDate.TabIndex = 7;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.ForeColor = System.Drawing.Color.Black;
            this.btnLast.Image = global::IMS.Properties.Resources.icons8_end_30;
            this.btnLast.Location = new System.Drawing.Point(150, 191);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(39, 36);
            this.btnLast.TabIndex = 23;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::IMS.Properties.Resources.icons8_sort_right_30;
            this.btnNext.Location = new System.Drawing.Point(104, 191);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 36);
            this.btnNext.TabIndex = 22;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Image = global::IMS.Properties.Resources.sort_left_30;
            this.btnPrev.Location = new System.Drawing.Point(58, 191);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(39, 36);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.ForeColor = System.Drawing.Color.Black;
            this.btnFirst.Image = global::IMS.Properties.Resources.end_to_start_30;
            this.btnFirst.Location = new System.Drawing.Point(12, 191);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(39, 36);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::IMS.Properties.Resources.new_copy_30;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNew.Location = new System.Drawing.Point(563, 190);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 36);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::IMS.Properties.Resources.delete_30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.Location = new System.Drawing.Point(452, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::IMS.Properties.Resources.edit_file_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUpdate.Location = new System.Drawing.Point(344, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = " &Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::IMS.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(233, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmInvertory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvertory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInvertory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInvertory_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInvertory_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paneli.ResumeLayout(false);
            this.paneli.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnPrev;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblmax;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblinc;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtSerial;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtComment;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnclearlist;
        internal System.Windows.Forms.Button btnExport;
        internal System.Windows.Forms.Panel paneli;
        private System.Windows.Forms.TextBox txtDate;
        internal System.Windows.Forms.Button btnAll;
        internal System.Windows.Forms.Button btnexporttable;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ComboBox cmbLocation;
        internal System.Windows.Forms.ComboBox cmbOwner;
        internal System.Windows.Forms.ComboBox txtModel;
        internal System.Windows.Forms.ComboBox txtManufacturer;
        private System.Windows.Forms.ComboBox txtItem;
        internal System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblf2;
        private System.Windows.Forms.Label lblf5;
        private System.Windows.Forms.Label lblf4;
        private System.Windows.Forms.Label lblf3;
        private System.Windows.Forms.Label lblf1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}