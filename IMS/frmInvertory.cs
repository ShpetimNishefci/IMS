using IMS.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace IMS
{
    public partial class frmInvertory : Form
    {
        public frmInvertory()
        {
            InitializeComponent();
            KeyPreview = true;
            txtDate.Text = DateTime.Now.ToShortDateString();
           autosugestItemsi();
           autosugestLocation();
           autosugestManufactureri();
           autosugestModeli();
           autosugestOwner();
            
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        frmReports formaraporti = new frmReports();
        string sql;
        int maxcolumn;
        int inc = 0;
        int maxrow;
        private void navi(string sql)
        {
            config.singleResult(sql);
            maxrow = config.dt.Rows.Count;
        }


        public void autosugestItemsi()
        {


            try
            {

                string selectQuery = "SELECT Items FROM Item";
                config.con.Open();
                SqlCommand command = new SqlCommand(selectQuery, config.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtItem.Items.Add(reader.GetString(0));

                }
                config.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void autosugestManufactureri()
        {


            try
            {

                string selectQuery = "SELECT Manufacturer from Manufacture";
                config.con.Open();
                SqlCommand command = new SqlCommand(selectQuery, config.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtManufacturer.Items.Add(reader.GetString(0));

                }
                config.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void autosugestModeli()
        {


            try
            {

                string selectQuery = "SELECT Models FROM Model";
                config.con.Open();
                SqlCommand command = new SqlCommand(selectQuery, config.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtModel.Items.Add(reader.GetString(0));

                }
                config.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void autosugestOwner()
        {


            try
            {

                string selectQuery = "SELECT Owners FROM Owner";
                config.con.Open();
                SqlCommand command = new SqlCommand(selectQuery, config.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbOwner.Items.Add(reader.GetString(0));

                }
                config.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void autosugestLocation()
        {


            try
            {

                string selectQuery = "SELECT Locations FROM Location";
                config.con.Open();
                SqlCommand command = new SqlCommand(selectQuery, config.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbLocation.Items.Add(reader.GetString(0));

                }
                config.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void navi_records(int inc)
        {
            config.singleResult("SELECT * FROM tblreg");
            txtid.Text = config.dt.Rows[inc].Field<int>("Nr").ToString();
            txtItem.Text = config.dt.Rows[inc].Field<string>("Item");
            txtBarcode.Text = config.dt.Rows[inc].Field<int>("Barcode").ToString();
            txtSerial.Text = config.dt.Rows[inc].Field<string>("Serial").ToString();
            txtManufacturer.Text = config.dt.Rows[inc].Field<string>("Manufacturer").ToString();
            txtModel.Text = config.dt.Rows[inc].Field<string>("Model");
            cmbOwner.Text = config.dt.Rows[inc].Field<string>("Owner");
            txtComment.Text = config.dt.Rows[inc].Field<string>("Comments");
          txtDate.Text = config.dt.Rows[inc].Field<DateTime>("Date").ToString();
            cmbLocation.Text = config.dt.Rows[inc].Field<string>("Location");

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblreg WHERE Item LIKE '%" + txtsearch.Text + "%' OR Barcode LIKE '%" + txtsearch.Text + "%'OR Serial LIKE '%" + txtsearch.Text + "%'OR Manufacturer LIKE '%" + txtsearch.Text + "%'OR Model LIKE '%" + txtsearch.Text + "%'OR Owner LIKE '%" + txtsearch.Text + "%'OR Comments LIKE '%" + txtsearch.Text + "%'OR Date LIKE '%" + txtsearch.Text + "%'OR Location LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dataGridView1);


           maxcolumn = dataGridView1.Columns.Count - 1;

            dataGridView1.Columns[maxcolumn].Visible = true;

        }

        private void searchafter()
        {
            sql = "SELECT * FROM tblreg WHERE Nr LIKE '%" + txtid.Text + "%'";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void seealldata()
        {
            sql = "select * from tblreg";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }
        private void rriteid()
        {
            string sql = "SELECT MAX(Nr)+1 FROM tblreg";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }

        private void designdatagridview()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[0].Width = 30;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtItem.Text=="")
            {
                MessageBox.Show("Item field are required to be fill up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                try
                {
                    rriteid();

                    sql = "insert into tblreg(Nr,Item,Barcode,Serial,Manufacturer,Model,Owner,Comments,Date,Location) values('" + this.txtid.Text + "','" + this.txtItem.Text + "','" + this.txtBarcode.Text + "','" + this.txtSerial.Text + "','" + this.txtManufacturer.Text + "','" + this.txtModel.Text + "','" + this.cmbOwner.Text + "','" + this.txtComment.Text + "','" + this.txtDate.Text + "','" + this.cmbLocation.Text + "');";
                    config.Execute_CUD(sql, "No data saved.", "" + txtItem.Text + " Data has been saved in the database.");
                    
                    Thread.Sleep(200); 
                    navi("SELECT Nr from tblreg");
                    if (inc != maxrow)
                    {
                        inc = maxrow;
                        lblinc.Text = inc.ToString();
                        inc = maxrow - 1;
                        navi_records(inc);
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(100);
                        searchafter();
                    }
       
                }
                    

                catch (System.Data.SqlClient.SqlException ex)
                {
                    if (ex.Number == 2627) { /*  primary key violation */ }


                }

            }

            }

        private void frmInvertory_Load(object sender, EventArgs e)
        {
            rriteid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (this.txtItem.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItem.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update "+txtItem.Text+" ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update tblreg set Item='" + this.txtItem.Text + "',Barcode='" + this.txtBarcode.Text + "',Serial='" + this.txtSerial.Text + "',Manufacturer='" + this.txtManufacturer.Text + "',Model='" + this.txtModel.Text + "',Owner='" + this.cmbOwner.Text + "',Comments='" + this.txtComment.Text + "',Location='" + this.cmbLocation.Text + "' where Nr='" + this.txtid.Text + "';";
                        config.Execute_CUD(sql, "Can`t update", ""+txtItem.Text+" Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);

                        //((DataTable)dataGridView1.DataSource).Rows.Clear();
                        //dataGridView1.Refresh();
                        searchafter();
                       // rriteid();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            inc = 0;

            sql = "SELECT * FROM tblreg";
            config.Load_DTG(sql, dataGridView1);

            maxcolumn = dataGridView1.Columns.Count - 1;

            dataGridView1.Columns[maxcolumn].Visible = false;

            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            dataGridView1.Refresh();

            navi("SELECT Nr FROM tblreg");
            lblmax.Text = maxrow.ToString();
            lblinc.Text = inc.ToString();
            funct.clearTxt(paneli);
            rriteid();
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtItem.Text == "")
            {
                MessageBox.Show("Nothing to Delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItem.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete "+txtItem.Text+" ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        sql = "DELETE FROM tblreg WHERE Nr='" + txtid.Text + "'";
                        config.Execute_CUD(sql, "Error to delete", "Data has been deleted.");
                        seealldata();
                        //btnNew_Click(sender, e);
                        rriteid(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (DialogResult == DialogResult.No)
                {
                    //Nothing to do
                }
            }
            
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtItem.Text = row.Cells[1].Value.ToString();
                txtBarcode.Text = row.Cells[2].Value.ToString();
                txtSerial.Text = row.Cells[3].Value.ToString();
                txtManufacturer.Text = row.Cells[4].Value.ToString();
                txtModel.Text = row.Cells[5].Value.ToString();
                cmbOwner.Text = row.Cells[6].Value.ToString();
                txtComment.Text = row.Cells[7].Value.ToString();
                cmbLocation.Text = row.Cells[9].Value.ToString();

            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            seealldata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);

                }
                catch (Exception msg)
                {
                    MessageBox.Show("You can´t delete A row " + msg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            sql = "SELECT * FROM tblreg";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                DialogResult dr = MessageBox.Show("Do you want to open created " + saveFileDialog1.FileName + " file?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(500);

                        System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (DialogResult == DialogResult.No)
            {
                //Nothing to do
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnexporttable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Nothing to EXPORT!!",
"Information !!",
MessageBoxButtons.OK,
MessageBoxIcon.Exclamation,
MessageBoxDefaultButton.Button1);
            }
            else
            {


                Excel.Application xlAppe = new Microsoft.Office.Interop.Excel.Application();

                if (xlAppe == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Save Excel File";
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.CheckPathExists = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    DialogResult dr = MessageBox.Show("Do you want to open created " + saveFileDialog1.FileName + " file?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            Thread.Sleep(500);

                            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (DialogResult == DialogResult.No)
                {
                    //Nothing to do
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            inc = 1;
            lblinc.Text = inc.ToString();
            inc = 0;
            navi_records(inc);
            Cursor.Current = Cursors.WaitCursor;
            Thread.Sleep(100);
            searchafter();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            navi("SELECT Nr from tblreg");
            if (inc != maxrow)
            {
                inc = maxrow;
                lblinc.Text = inc.ToString();
                inc = maxrow - 1;
                navi_records(inc);
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(100);
                searchafter();
            } 
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int lbl_inc = 0;

            if (inc > 0)
            {
                inc = inc - 1;
                navi_records(inc);


                lbl_inc = int.Parse(lblinc.Text) - 1;

                lblinc.Text = lbl_inc.ToString();
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(100);
                searchafter();
            }
            else if (inc == 0)
            {
                navi_records(inc);
                lbl_inc = 1;
                lblinc.Text = lbl_inc.ToString();
                MessageBox.Show("Already first Record", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int lbl_inc;

            navi("SELECT Nr from tblreg");
            if (inc == maxrow - 1)
            {
                MessageBox.Show("No more rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (inc != maxrow - 1)
                {
                    inc = inc + 1;
                    navi_records(inc);
                    Cursor.Current = Cursors.WaitCursor;
                    Thread.Sleep(100);
                    searchafter();
                }

                lbl_inc = int.Parse(lblinc.Text) + 1;
                lblinc.Text = lbl_inc.ToString();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtItem.Items.Clear();
            cmbLocation.Items.Clear();
            cmbOwner.Items.Clear();
            txtModel.Items.Clear();
            txtManufacturer.Items.Clear();
            autosugestItemsi();
            autosugestLocation();
            autosugestManufactureri();
            autosugestModeli();
            autosugestOwner();
        }

        private void frmInvertory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtsearch.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnsave_Click(sender,e);
            }

            else if (e.KeyCode == Keys.F3)
            {
                btnUpdate_Click(sender,e);
            }

            else if (e.KeyCode == Keys.F4)
            {
                btnDelete_Click(sender,e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnNew_Click(sender,e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnReload_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnAll_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                button2_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F9)
            {
                btnexporttable_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                btnExport_Click(sender, e);
            }

        }

        private void frmInvertory_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        
        }
    }

