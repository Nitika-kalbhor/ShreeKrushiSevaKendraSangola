using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using DataAccessLayer.models;
using DataAccessLayer.controller;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmVilegeArea : MetroForm
    {
        public frmVilegeArea()
        {
            InitializeComponent();
        }
        public void BindComboBoxVillageDetails()
        {

            DataTable dtvillageId = customerController.getVillageDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbArea, dtvillageId, "villageId", "villageName");
        }
        public static int villageId = 0;
        public void getVillageDetails()
        {
            try
            {
                //  grdArea.Font = new Font("Tahoma", 11, FontStyle.Bold);

                Category category = new Category();


                grdArea.DataSource = null;
                DataTable lstcategory = customerController.getVillageDetails();

                grdArea.AutoGenerateColumns = false;
                grdArea.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                grdArea.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                grdArea.Font = new Font("Tahoma", 11);

                grdArea.EnableHeadersVisualStyles = false;

                grdArea.ColumnCount = 2;
                if (Utility.Langn == "English")
                {
                    grdArea.Columns[0].Name = "villageId";
                    grdArea.Columns[0].HeaderText = "villageId";
                    grdArea.Columns[0].DataPropertyName = "villageId";
                    grdArea.Columns[0].Visible = false;

                    grdArea.Columns[1].Name = "villageName";
                    grdArea.Columns[1].HeaderText = "Village ";
                    grdArea.Columns[1].DataPropertyName = "villageName";
                    grdArea.Columns[1].Width = 500;
                }
                else
                {
                    grdArea.Columns[0].Name = "villageId";
                    grdArea.Columns[0].HeaderText = "villageId";
                    grdArea.Columns[0].DataPropertyName = "villageId";
                    grdArea.Columns[0].Visible = false;

                    grdArea.Columns[1].Name = "villageName";
                    grdArea.Columns[1].HeaderText = "गाव ";
                    grdArea.Columns[1].DataPropertyName = "villageName";
                    grdArea.Columns[1].Width = 500;
                }

                grdArea.DataSource = lstcategory;


            }
            catch (Exception)
            {
                ////MessageBox.Show("Something went wrong in gridview");
            }

        }
        #region --Lang--

        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Village Details";
                   metroLabel2.Text = "Village Name:";
                   btnnew.Text = "New(Alt+N)";
                   btnSave.Text = "Save (Alt+S)";
                   btnUpdate.Text = "Update";
                   btnDelete.Text = "Delete";              
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmVilegeArea_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Lang();
                getVillageDetails();
                BindComboBoxVillageDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                getVillageDetails();
                BindComboBoxVillageDetails();
                villageId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbArea.Text == string.Empty || cmbArea.Text == "-- Select --")
                {
                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add village name..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया गावाचे नाव भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbArea.Focus();
                    return;
                }

                if (villageId > 0)
                {
                    DialogResult ShowReport = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        ShowReport = MessageBox.Show("Do you want to update this record?", "पावती", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        ShowReport = MessageBox.Show("माहिती अपडेट करायची का?", "पावती", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport == DialogResult.Yes)
                    {
                        int i = villageDetailsController.addVillageDetails(villageId, cmbArea.Text);
                        if (i > 0)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This record saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर माहिती यशस्वीरित्या साठवली गेली आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            Utility.ClearSpace(this);
                            Utility.enableFields(this);
                            btnSave.Enabled = true;
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            getVillageDetails();
                            BindComboBoxVillageDetails();
                            villageId = 0;
                        }
                        if (i < 0)
                        {
                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This village name already present in list.!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("कृपया गावाचे नाव लिट मध्ये आधीच उपलब्ध आहे..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        getVillageDetails();
                        BindComboBoxVillageDetails();
                        villageId = 0;
                    }
                }
                else
                {
                    int i = villageDetailsController.addVillageDetails(villageId, cmbArea.Text);
                    if (i > 0)
                    {

                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This record saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर माहिती यशस्वीरित्या साठवली गेली आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        getVillageDetails();
                        BindComboBoxVillageDetails();
                        villageId = 0;
                    }
                    if (i < 0)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This village name already present in list..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("कृपया गावाचे नाव लिट मध्ये आधीच उपलब्ध आहे..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmVilegeArea_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.grdArea.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        villageId = Convert.ToInt32(row.Cells["villageId"].Value);
                        cmbArea.Text = row.Cells["villageName"].Value.ToString();
                        Utility.enableFields(this);
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
