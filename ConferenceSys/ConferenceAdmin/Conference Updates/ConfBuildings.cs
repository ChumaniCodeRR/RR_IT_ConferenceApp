using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ConferenceSys.ConferenceAdmin
{
    public partial class ConfBuildings : Form
    {
        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_buildings;
        DataView dv_list;
        int rowcount;

        string ConferenceCode;
        string MainFolio;
        public ConfBuildings(string _ConferenceCode, string _MainFolio)
        {
            InitializeComponent();
            ConferenceCode = _ConferenceCode;
            MainFolio = _MainFolio;
        }

        private void ConfBuildings_Load(object sender, EventArgs e)
        {
            string feedback = "";
            bool conf_admin;
            ds_buildings = Proxy.ConferenceAdmin.get_conference(false, ConferenceCode, out conf_admin, out feedback);
            if (feedback != "")
            {
                MessageBox.Show(feedback, "Error Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                rowcount = ds_buildings.tt_conf_build.Count;
                dv_list = new DataView(ds_buildings.tt_conf_build);
                bs_building1.DataSource = dv_list;
                if (ds_buildings.tt_conference[0].gender_specific == true)
                {
                    pnl_gender.Visible = true;
                    rb_male.Checked = true;
                }
                else pnl_gender.Visible = false;

            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgBuildings.Rows)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells[ckCopy.Name];
                if (checkCell.Value == null || !(bool)checkCell.Value) checkCell.Value = true;
            }
            dgBuildings.ClearSelection();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgBuildings.Rows)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells[ckCopy.Name];
                if (checkCell.Value != null && (bool)checkCell.Value) checkCell.Value = false;
            }
            dgBuildings.ClearSelection();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgBuildings.Rows.Count > 0)
                {
                    bool selected = false;
                    foreach (DataGridViewRow row in dgBuildings.Rows)
                    {
                        if (row.Cells[ckCopy.Name].Value != null && (bool)row.Cells[ckCopy.Name].Value)
                        {
                            selected = true; break;
                        }
                    }
                    if (!selected) MessageBox.Show("There are no buildings selected", "Conference Buildings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int x = 0;
                        string tempbuilding = "";
                        foreach (DataGridViewRow row in dgBuildings.Rows)
                        {
                            if (row.Cells[ckCopy.Name].Value != null && (bool)row.Cells[ckCopy.Name].Value)
                            {

                                x = x + 1;
                                if (tempbuilding != "") tempbuilding = tempbuilding + ",";
                                tempbuilding = tempbuilding + row.Cells[cnbuilding.Name].Value.ToString();
                            }
                        }

                        if (x == rowcount) tempbuilding = "*";
                        

                        string feedback = Proxy.ConferenceAdmin.group_booking(MainFolio, tempbuilding, chk_allow_split.Checked, rb_male.Checked);
                        MessageBox.Show(feedback, "Group Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!feedback.Contains("Error")) this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }


        private void filter()
        {
            dv_list.RowFilter = "gender = " + rb_male.Checked.ToString();
            bs_building1.DataSource = dv_list;
        }
    }
}
