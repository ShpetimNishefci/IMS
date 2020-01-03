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
namespace IMS
{
    public partial class frmedit : Form
    {
        public frmedit()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, idja;
        #region RRITI_ID-t
        private void rriteid()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Item";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }
        private void rriteidModels()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Model";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }
        private void rriteidmanufacture()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Manufacture";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }
        private void rriteidOwneri()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Owner";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }
        private void rriteidLocation()
        {
            string sql = "SELECT MAX(Nr)+1 FROM Location";
            SqlDataAdapter da = new SqlDataAdapter(sql, config.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtid.Text = dt.Rows[0][0].ToString();
        }
        #endregion
        #region WhenYouClickONCells


        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItems.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
            idja = dgvItems.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvManufacturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManufacturer.Text = dgvManufacturer.CurrentRow.Cells[1].Value.ToString();
            idja = dgvManufacturer.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = dgvModels.CurrentRow.Cells[1].Value.ToString();
            idja = dgvModels.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOwner.Text = dgvOwners.CurrentRow.Cells[1].Value.ToString();
            idja = dgvOwners.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLocations.Text = dgvLocations.CurrentRow.Cells[1].Value.ToString();
            idja = dgvLocations.CurrentRow.Cells[0].Value.ToString();
        }
        #endregion
        #region DatagridviewDizajni
        private void designdatagridview()
        {
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;

        }
        private void designdatagridviewMAN()
        {
            dgvManufacturer.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvManufacturer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvManufacturer.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvManufacturer.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvManufacturer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvManufacturer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvManufacturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManufacturer.AllowUserToResizeColumns = false;
            dgvManufacturer.AllowUserToResizeRows = false;

        }
        private void designdatagridviewMOD()
        {
            dgvModels.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvModels.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvModels.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvModels.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvModels.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvModels.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvModels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModels.AllowUserToResizeColumns = false;
            dgvModels.AllowUserToResizeRows = false;

        }
        private void designdatagridviewOWN()
        {
            dgvOwners.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvOwners.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOwners.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvOwners.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvOwners.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvOwners.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvOwners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOwners.AllowUserToResizeColumns = false;
            dgvOwners.AllowUserToResizeRows = false;

        }
        private void designdatagridviewLOC()
        {
            dgvLocations.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dgvLocations.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLocations.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgvLocations.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            dgvLocations.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLocations.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocations.AllowUserToResizeColumns = false;
            dgvLocations.AllowUserToResizeRows = false;

        }
        #endregion
        #region ITEMSI
        private void btnItemLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Item ;";
            config.Load_DTG(sql, dgvItems);
            dgvItems.Columns[0].Visible = false;
            designdatagridview();
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {

            if (this.txtItems.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItems.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtItems.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Item set Items='" + this.txtItems.Text + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtItems.Text + " Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Item WHERE Items LIKE '%" + txtItems.Text + "%'";
                        config.Load_DTG(sql, dgvItems);
                        designdatagridview();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {

            if (this.txtItems.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItems.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtItems.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Item WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtItems.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT Items from item";
                        config.Load_DTG(sql, dgvItems);
                        designdatagridview();
                        txtItems.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {

            if (this.txtItems.Text == "")
            {
                MessageBox.Show("Nothing to add", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItems.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtItems.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteid();
                        sql = "insert into Item(Nr,Items) values('" + this.txtid.Text + "','" + this.txtItems.Text + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtItems.Text + " Data has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Item WHERE Items LIKE '%" + txtItems.Text + "%'";
                        config.Load_DTG(sql, dgvItems);
                        designdatagridview();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        #endregion
        // Save Edit Delete ==>
        #region Manufactureri
        private void btnManSave_Click(object sender, EventArgs e)
        {

            if (this.txtManufacturer.Text == "")
            {
                MessageBox.Show("Nothing to add", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtItems.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtManufacturer.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteidmanufacture();
                        sql = "insert into Manufacture(Nr,Manufacturer) values('" + this.txtid.Text + "','" + this.txtManufacturer.Text + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtManufacturer.Text + " Data has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * from Manufacture WHERE Manufacturer LIKE '%" + txtManufacturer.Text + "%'";
                        config.Load_DTG(sql, dgvManufacturer);
                        dgvManufacturer.Columns[0].Visible = false;
                        designdatagridviewMAN();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnManLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Manufacture ;";
            config.Load_DTG(sql, dgvManufacturer);
            dgvManufacturer.Columns[0].Visible = false;
            designdatagridviewMAN();
        }

        private void btnManDelete_Click(object sender, EventArgs e)
        {

            if (this.txtManufacturer.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtManufacturer.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtManufacturer.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Manufacture WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtManufacturer.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT Manufacturer from Manufacture";
                        config.Load_DTG(sql, dgvManufacturer);
                        designdatagridviewMAN();
                        txtManufacturer.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnManUpdate_Click(object sender, EventArgs e)
        {

            if (this.txtManufacturer.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtManufacturer.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtManufacturer.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Manufacture set Manufacturer='" + this.txtManufacturer.Text + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtManufacturer.Text + " Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Manufacture WHERE Manufacturer LIKE '%" + txtManufacturer.Text + "%'";
                        config.Load_DTG(sql, dgvManufacturer);
                        designdatagridviewMAN();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }
        #endregion
        #region Modeli
        private void btnModelSave_Click(object sender, EventArgs e)
        {

            if (this.txtModel.Text == "")
            {
                MessageBox.Show("Nothing to add", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtModel.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtModel.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteidmanufacture();
                        sql = "insert into Model(Nr,Models) values('" + this.txtid.Text + "','" + this.txtModel.Text + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtModel.Text + " Data has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * from Model WHERE Models LIKE '%" + txtModel.Text + "%'";
                        config.Load_DTG(sql, dgvModels);
                        dgvModels.Columns[0].Visible = false;
                        designdatagridviewMOD();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnModelUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtModel.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtModel.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtModel.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Model set Models='" + this.txtModel.Text + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtModel.Text + " Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Model WHERE Models LIKE '%" + txtModel.Text + "%'";
                        config.Load_DTG(sql, dgvModels);
                        designdatagridviewMOD();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }

        private void btnModelDelete_Click(object sender, EventArgs e)
        {
            if (this.txtModel.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtModel.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtModel.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Model WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtModel.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT Models from Model";
                        config.Load_DTG(sql, dgvModels);
                        designdatagridviewMOD();
                        txtModel.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnModelLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Model ;";
            config.Load_DTG(sql, dgvModels);
            dgvModels.Columns[0].Visible = false;
            designdatagridviewMOD();
        }
        #endregion
        #region Owneri
        private void btnOwnerSave_Click(object sender, EventArgs e)
        {
            if (this.txtOwner.Text == "")
            {
                MessageBox.Show("Nothing to add", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtOwner.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtOwner.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteidmanufacture();
                        sql = "insert into Owner(Nr,Owners) values('" + this.txtid.Text + "','" + this.txtOwner.Text + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtOwner.Text + " Data has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * from Owner WHERE Owners LIKE '%" + txtOwner.Text + "%'";
                        config.Load_DTG(sql, dgvOwners);
                        dgvOwners.Columns[0].Visible = false;
                        designdatagridviewOWN();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnOwnerUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtOwner.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtOwner.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtOwner.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Owner set Owners='" + this.txtOwner.Text + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtOwner.Text + " Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Owner WHERE Owners LIKE '%" + txtOwner.Text + "%'";
                        config.Load_DTG(sql, dgvOwners);
                        designdatagridviewOWN();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnOwnerDelete_Click(object sender, EventArgs e)
        {
            if (this.txtOwner.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtOwner.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtOwner.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Owner WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtOwner.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT Owners from Owner";
                        config.Load_DTG(sql, dgvOwners);
                        designdatagridviewOWN();
                        txtOwner.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnOwnerLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Owner ;";
            config.Load_DTG(sql, dgvOwners);
            dgvOwners.Columns[0].Visible = false;
            designdatagridviewOWN();
        }
        #endregion
#region Locationi
        private void btnLocationSave_Click(object sender, EventArgs e)
        {
            if (this.txtLocations.Text == "")
            {
                MessageBox.Show("Nothing to add", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtLocations.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to add  " + txtLocations.Text + "  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        rriteidmanufacture();
                        sql = "insert into Location(Nr,Locations) values('" + this.txtid.Text + "','" + this.txtLocations.Text + "');";
                        config.Execute_CUD(sql, "Can`t add", "" + txtLocations.Text + " Data has been added");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * from Location WHERE Locations LIKE '%" + txtLocations.Text + "%'";
                        config.Load_DTG(sql, dgvLocations);
                        dgvLocations.Columns[0].Visible = false;
                        designdatagridviewLOC();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnLocationUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtLocations.Text == "")
            {
                MessageBox.Show("Nothing to Update", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtLocations.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to Update " + txtLocations.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "update Location set Locations='" + this.txtLocations.Text + "'where Nr='" + this.idja + "';";
                        config.Execute_CUD(sql, "Can`t update", "" + txtLocations.Text + " Data has been updated");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT * FROM Location WHERE Locations LIKE '%" + txtLocations.Text + "%'";
                        config.Load_DTG(sql, dgvLocations);
                        designdatagridviewLOC();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnLocationDelete_Click(object sender, EventArgs e)
        {
            if (this.txtLocations.Text == "")
            {
                MessageBox.Show("Nothing to delete", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtLocations.Focus();
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtLocations.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        sql = "DELETE FROM Location WHERE Nr='" + this.idja + "'";
                        config.Execute_CUD(sql, "Can`t delete", "" + txtLocations.Text + " Data has been delete");
                        Cursor.Current = Cursors.WaitCursor;
                        Thread.Sleep(800);
                        sql = "SELECT Locations from Location";
                        config.Load_DTG(sql, dgvLocations);
                        designdatagridviewLOC();
                        dgvLocations.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnLocationLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from Location ;";
            config.Load_DTG(sql, dgvLocations);
            dgvLocations.Columns[0].Visible = false;
            designdatagridviewLOC();
        }
#endregion
    }
}