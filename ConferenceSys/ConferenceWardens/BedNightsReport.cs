using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceWardens
{
    public partial class BedNightsReport : Form
    {
        string tempconf;

        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_ccode;

        public BedNightsReport()
        {
            InitializeComponent();
        }

        private void BedNightsReport_Load(object sender, EventArgs e)
        {
            // Set default conference
            if (ConferenceSys.Properties.Settings.Default.LastConference != "")
            {
                tempconf = ConferenceSys.Properties.Settings.Default.LastConference;
                validate_conference();
            }
            else
            {
                nlb_from.Value = DateTime.Today;
                nlb_to.Value = DateTime.Today;
            }
        }

     
        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_conf_code.Text == string.Empty) MessageBox.Show("Please select a conference to continue", "Error Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (nlb_from.Value > nlb_to.Value) MessageBox.Show("Error - Start date cannot be after End date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string temphall = cb_hall.SelectedValue.ToString();
                    int tempres = 999;
                    string cbuilding = "*";

                    if (cb_res.SelectedIndex > -1) { if (cb_res.SelectedValue.ToString() != "999")  tempres = int.Parse(cb_res.SelectedValue.ToString()); }
                    if (cb_buliding.SelectedIndex > -1) { if (cb_buliding.SelectedValue.ToString() != "*") cbuilding = cb_buliding.SelectedValue.ToString(); }

                    DateTime start_dte = nlb_from.Value;
                    DateTime end_dte = nlb_to.Value;

                    string feedback = string.Empty;

                    NS_Conference.StrongTypesNS.ds_beds_reportDataSet ds_beds = Proxy.ConferenceSystem.conference_bed_nights(txt_conf_code.Text.ToString(),temphall,tempres, cbuilding, start_dte, end_dte, out feedback);
                    if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (ds_beds.tt_beds_file.Count > 0)
                        {
                            DataView dvReport = new DataView(ds_beds.tt_beds_file);
                            string temptitle = txt_conf_descrip.Text.ToString() + " number of room nights report. Date Range: " + start_dte.ToShortDateString() + " - " + end_dte.ToShortDateString();

                            Reports frm_report = new Reports(false,"BedNights", dvReport, temptitle);
                            frm_report.Show();

                        }
                        else MessageBox.Show("Your query returned no data to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_conf_Click(object sender, EventArgs e)
        {
            try
            {
                SearchConference frm_search = new SearchConference();
                frm_search.ShowDialog();

                if (frm_search.conference != string.Empty)
                 {
                     tempconf = frm_search.conference; 
                     validate_conference();
                    
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            hall_changed();
        }

        private void hall_changed()
        {
            try
            {
                if (cb_hall.SelectedIndex > -1)
                {
                    if (cb_hall.SelectedIndex == 0)
                    {
                        cb_res.SelectedIndex = -1;
                        cb_res.Enabled = false;
                        cb_buliding.SelectedIndex = -1;
                        cb_buliding.Enabled = false;
                    }
                    else
                    {
                        cb_res.Enabled = true;                        
                        DataView dv_res = new DataView(ds_ccode.tt_ccode_res);
                        dv_res.RowFilter = "shall = '" + cb_hall.SelectedValue.ToString() + "'";
                        bool AddAll = true;

                        if (dv_res.Count > 1)
                        {
                            for (int i = 0; i < ds_ccode.tt_ccode_res.Rows.Count; i++)
                            {
                                if (ds_ccode.tt_ccode_res.Rows[i]["res"].ToString() == "999" &&
                                    ds_ccode.tt_ccode_res.Rows[i]["shall"].ToString() == cb_hall.SelectedValue.ToString()) AddAll = false;
                            }

                            if (AddAll == true)
                            {
                                DataRow newres = ds_ccode.tt_ccode_res.NewRow();
                                newres["res"] = "999";
                                newres["res_name"] = "All Residences";
                                newres["shall"] = cb_hall.SelectedValue.ToString();
                                ds_ccode.tt_ccode_res.Rows.InsertAt(newres, 0);
                            }
                        }

                        dv_res.Sort = "res_name";
                        cb_res.DataSource = dv_res;
                        cb_res.DisplayMember = "res_name";
                        cb_res.ValueMember = "res";

                    }

                    res_changed();
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void cb_res_SelectedIndexChanged(object sender, EventArgs e)
        {
            res_changed();
        }

        private void res_changed()
        {
            try
            {
                if (cb_res.SelectedIndex > -1)
                {

                    if (cb_res.SelectedIndex == 0)   cb_buliding.Enabled = false;
                    else cb_buliding.Enabled = true;

                    bool AddAll = true;

                    DataView dv_build = new DataView(ds_ccode.tt_ccode_build);
                    dv_build.RowFilter = "res = '" + cb_res.SelectedValue.ToString() + "'";

                    if (dv_build.Count > 1)
                    {
                        for (int i = 0; i < ds_ccode.tt_ccode_build.Rows.Count; i++)
                        {
                            if (ds_ccode.tt_ccode_build.Rows[i]["building"].ToString() == "*" &&
                                ds_ccode.tt_ccode_build.Rows[i]["res"].ToString() == cb_res.SelectedValue.ToString()) AddAll = false;
                        }

                        if (AddAll == true)
                        {
                            DataRow newbuild = ds_ccode.tt_ccode_build.NewRow();
                            newbuild["building"] = "*";
                            newbuild["building_name"] = "All Buildings";
                            newbuild["res"] = cb_res.SelectedValue.ToString();
                            ds_ccode.tt_ccode_build.Rows.InsertAt(newbuild, 0);
                        }
                    }
                    dv_build.Sort = "building_name";
                    cb_buliding.DataSource = dv_build;
                    cb_buliding.DisplayMember = "building_name";
                    cb_buliding.ValueMember = "building";
                 
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void validate_conference()
        {
            DateTime ConfStart = DateTime.Today;
            DateTime ConfEnd = DateTime.Today;
            string feedback = Proxy.ConferenceSystem.validate_conference(tempconf, out ConfStart, out ConfEnd);
            if (!feedback.Contains("Error"))
            {

                ds_ccode = new NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet();
                ds_ccode = Proxy.ConferenceAdmin.get_conf_halls(tempconf);

                DataRow newhall = ds_ccode.tt_ccode_hall.NewRow();
                newhall["shall"] = "*";
                newhall["descrip"] = "All Halls";
                ds_ccode.tt_ccode_hall.Rows.InsertAt(newhall, 0);


                cb_hall.Enabled = true;
                DataView dvHall = new DataView(ds_ccode.tt_ccode_hall);
                dvHall.Sort = "descrip";
                cb_hall.DataSource = dvHall;
                cb_hall.DisplayMember = "descrip";
                cb_hall.ValueMember = "shall";

                nlb_from.MinDate = nlb_to.MinDate = DateTimePicker.MinimumDateTime;
                nlb_from.MaxDate = nlb_to.MaxDate = DateTimePicker.MaximumDateTime;

                nlb_from.MinDate = nlb_to.MinDate = nlb_from.Value = ConfStart;
                nlb_from.MaxDate = nlb_to.MaxDate = nlb_to.Value = ConfEnd;

                txt_conf_code.Text = tempconf;
                txt_conf_descrip.Text = feedback;

                if (ConferenceSys.Properties.Settings.Default.LastConference != txt_conf_code.Text.ToString())
                {
                    ConferenceSys.Properties.Settings.Default.LastConference = txt_conf_code.Text.ToString();                 
                    ConferenceSys.Properties.Settings.Default.Save();
                }

            }
            else
            {
                MessageBox.Show(feedback, "Error Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_conf_code.Text = "";
                txt_conf_descrip.Text = "";
                txt_conf_code.Focus();
            }


        }
    }
}
