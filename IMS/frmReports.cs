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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
namespace IMS
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
            autosugestItemsi();
            autosugestLocation();
            autosugestManufactureri();
            autosugestModeli();
            autosugestOwner();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxcolumn;
        private void designdatagridview()
        {
           dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

        }
        public void autosugestItemsi()
        {


            try
            {

                string selectQuery = "SELECT Items from Item";
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

                string selectQuery = "SELECT Models from Model";
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
        public void btnItems_Click(object sender, EventArgs e)
        {
            sql = "SELECT Item, COUNT(*) Total FROM tblreg GROUP BY Item ;";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            sql = "SELECT Manufacturer, COUNT(*) Total FROM tblreg where Manufacturer  <>'' GROUP  BY Manufacturer ;";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            sql = "SELECT Model, COUNT(*) Total FROM tblreg where Model  <>'' GROUP BY Model ;";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            sql = "SELECT Owner, COUNT(*) Total FROM tblreg where Owner  <>'' GROUP BY Owner ;";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            sql = "SELECT Location, COUNT(*) Total FROM tblreg where Location  <>'' GROUP BY Location;";
            config.Load_DTG(sql, dataGridView1);
            designdatagridview();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = txtItem.Text.Trim();
            string sql = "SELECT * FROM tblreg WHERE Item LIKE '%" + input + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            designdatagridview();
        }

        private void btnPdf_Click(object sender, EventArgs e)
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

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 1;
                pdfTable.WidthPercentage = 150;
                //float[] columnWidths = new float[] { 3f, 5f, 8f, 12f, 8f, 12f, 8f, 10f, 10f, 8f };
                //pdfTable.SetWidths(columnWidths);
                pdfTable.TotalWidth = 830f;
                pdfTable.LockedWidth = true;
                pdfTable.HorizontalAlignment = 0;
                pdfTable.DefaultCell.BorderWidth = 1;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(150, 150, 150);
                    pdfTable.AddCell(cell);


                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Save PDF File";
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "Pdf files (*.pdf)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.CheckPathExists = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 5f, 10f, 20f, 5f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
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
        private void txtManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = txtManufacturer.Text.Trim();
            string sql = "SELECT * FROM tblreg WHERE Manufacturer LIKE '%" + input + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            designdatagridview();
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = txtModel.Text.Trim();
            string sql = "SELECT * FROM tblreg WHERE Manufacturer LIKE '%" + input + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            designdatagridview();
        }

        private void cmbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = cmbOwner.Text.Trim();
            string sql = "SELECT * FROM tblreg WHERE Manufacturer LIKE '%" + input + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            designdatagridview();
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = cmbLocation.Text.Trim();
            string sql = "SELECT * FROM tblreg WHERE Manufacturer LIKE '%" + input + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            designdatagridview();
        }

        private void btnExcel_Click(object sender, EventArgs e)
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
