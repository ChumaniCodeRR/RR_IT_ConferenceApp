using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConferenceSys.ConferenceWardens;
using Utilities;
using ConferenceSys.ConferenceAdmin;

namespace ConferenceSys.ConferenceAdmin.ConferenceUpdate
{
    public partial class FinCoreConferenceUpdate : Form
    {
        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conference;
        public int tcode = 0;
        public bool addnew;
        bool loaded = false;




        public FinCoreConferenceUpdate()
        {
            InitializeComponent();
        }

        private void FinCoreConferenceUpdate_Load(object sender, EventArgs e)
        {
            pnl_header.Enabled = true;
            pnl_detail.Enabled = false;
            dte_arrive.Value = DateTime.Today;
            dte_departure.Value = DateTime.Today;

            if (Global.Global.fincore_status == true)
            {
                lblfincore_live.Text = "Fincore Live";
                lblfincore_live.ForeColor = Color.Red;
            }
        }

        private void load_conference()
        {
            if (txt_conf_code.Text == "") MessageBox.Show("Please enter conference code to continue", "Error Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //txt_gl_account.Enabled = true;
                string feedback;
                bool conf_admin;
                ds_conference = Proxy.ConferenceAdmin.get_conference(addnew, txt_conf_code.Text, out conf_admin, out feedback);
                if (feedback != "") MessageBox.Show(feedback, "Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    txt_ccode.Text = txt_conf_code.Text;
                    txt_conf_descrip.Text = ds_conference.tt_conference[0].conference.ToString();
                    bs_conference.DataSource = ds_conference.tt_conference;
                    bs_adms.DataSource = ds_conference.tt_adms;
                    bs_build.DataSource = ds_conference.tt_conf_build;
                    bs_rates.DataSource = ds_conference.tt_conf_type;
                    bs_build_conf_type.DataSource = ds_conference.tt_conf_type;

                    cnBuildConfType.DataSource = bs_build_conf_type;
                    cnBuildConfType.DisplayMember = "descrip";
                    cnBuildConfType.ValueMember = "tcode";

                    display_gender();

                    addnew_click();
                    pnl_header.Enabled = false;
                    lblfincore_live.Enabled = true;
                    pnl_detail.Enabled = true;
                    if (conf_admin == false) pnl_update.Enabled = btn_delete.Enabled = btn_save.Enabled = false;
                    else pnl_update.Enabled = btn_delete.Enabled = btn_save.Enabled = true;
                }
            }
        }



        private void MaintainSubjects_Load(object sender, EventArgs e)
        {
            pnl_detail.Enabled = false;
            pnl_header.Enabled = true;
        }

        private void chck_add_new_CheckedChanged(object sender, EventArgs e)
        {
            addnew_click();
        }

        private void addnew_click()
        {
            if (chck_add_new.Checked == true) txt_ccode.Text = txt_conf_code.Text;
            else txt_ccode.Enabled = false;
        }

        private void btn_continue_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (chck_add_new.Checked == true) addnew = true;
                else addnew = false;
                load_conference();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void btn_search_conf_Click_1(object sender, EventArgs e)
        {
            try
            {
                SearchConference frm_search = new SearchConference();
                frm_search.ShowDialog();

                if (frm_search.conference != "")
                {
                    txt_conf_code.Text = frm_search.conference;
                    txt_conf_descrip.Text = frm_search.descrip;
                }
            }

            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
                if (feedback == "") cancel_conf_update();
                else
                {
                    if (MessageBox.Show(feedback, "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cancel_conf_update();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void cancel_conf_update()
        {
            ds_conference.tt_conference.Clear();
            ds_conference.tt_adms.Clear();
            ds_conference.tt_conf_type.Clear();
            ds_conference.tt_conf_build.Clear();

            txt_conf_code.Text = "";
            txt_conf_descrip.Text = "";
            chck_add_new.Checked = false;

            pnl_header.Enabled = true;
            pnl_detail.Enabled = false;
        }


        private void btn_add_adm_Click(object sender, EventArgs e)
        {
            try
            {
                NS_System.StrongTypesNS.DS_ISD_DATADataSet ds_users = Proxy.System.Get_Programs_And_Users();
                SearchEmployee.Search_Protea_Users frm_search_users = new SearchEmployee.Search_Protea_Users(false, ds_users);
                frm_search_users.ShowDialog();
                if (frm_search_users.UserId != "")
                {
                    bool found = false;
                    string admin = frm_search_users.UserId.ToString();
                    for (int i = 0; i < ds_conference.tt_adms.Rows.Count; i++)
                    {
                        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_admsRow adminrow = ds_conference.tt_adms[i];
                        if (adminrow.ADMIN == admin) found = true;
                    }

                    if (found == false)
                    {
                        DataRow newrow = ds_conference.tt_adms.NewRow();
                        newrow["ccode"] = txt_conf_code.Text.ToString();
                        newrow["admin"] = frm_search_users.UserId.ToString();
                        newrow["admin_name"] = frm_search_users.NameString.ToString();
                        ds_conference.tt_adms.Rows.InsertAt(newrow, 0);
                        bs_adms.DataSource = ds_conference.tt_adms;
                    }
                    else MessageBox.Show("Administrator has already been added to the list", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void btn_remove_adm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dv_administrators.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to remove " + dv_administrators.SelectedRows[0].Cells[cn_admin_name.Name].Value.ToString() + " from the administrators list?", "Remove Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string admin = dv_administrators.SelectedRows[0].Cells[cn_admin.Name].Value.ToString();
                        for (int i = 0; i < ds_conference.tt_adms.Rows.Count; i++)
                        {
                            NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_admsRow adminrow = ds_conference.tt_adms[i];
                            if (adminrow.ADMIN == admin)
                            {
                                ds_conference.tt_adms.Rows.Remove(adminrow);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }

        }


        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_conference.Text == string.Empty) MessageBox.Show("Conference name cannot be blank", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_gl_account.Text == string.Empty) MessageBox.Show("Please select GL Account for the conference", "GL Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (dte_arrive.Value == null | dte_departure.Value == null) MessageBox.Show("Arrival and/or Departure dates cannot be blank", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (DateTime.Parse(dte_arrive.Value.ToString()) >= DateTime.Parse(dte_departure.Value.ToString())) MessageBox.Show("Arrival Date cannot be the same or after Departure date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    string feedback = Proxy.ConferenceAdmin.update_conference(ds_conference, false);
                    MessageBox.Show(feedback, "Update Conference", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void txt_conf_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (txt_conf_code.Text != "")
                {
                    if (chck_add_new.Checked == true) addnew = true;
                    else addnew = false;
                    load_conference();

                }
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + txt_ccode.Text + " - " + txt_conference.Text, "Delete Conference", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string feedback = Proxy.ConferenceAdmin.delete_conference(txt_conf_code.Text);
                    if (feedback != "") MessageBox.Show(feedback, "Delete Conference", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else load_conference();
                }
            }

            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }

        }

        private void btn_search_gl_Click(object sender, EventArgs e)
        {
            /* try
             {
                 if (Proxy.Info.username.StartsWith("testcc")) Proxy.Info.branch = "SD";

                 NS_System.StrongTypesNS.ds_accountsDataSet ds_accounts = Proxy.System.Get_GL_Accounts(Proxy.Info.branch , true);

                 DMU.Shared_Screens.SearchGLAccounts frm_search_gl = new DMU.Shared_Screens.SearchGLAccounts(ds_accounts);
                 frm_search_gl.ShowDialog();
                 if (frm_search_gl.gl_account != "") txt_gl_account.Text = frm_search_gl.gl_account;
             }
             catch (Exception ex)
             {
                 Utils.HandleException(ExceptionSource.ResOps, ex);
             } */

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
                if (feedback != string.Empty || txt_conference.Text == string.Empty)
                {
                    MessageBox.Show("Please save the changes you have made to the conference details, before modifying the conference types.", "Save Changes First", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conf_type = Proxy.ConferenceAdmin.get_conference_type(true, txt_conf_code.Text, 0, out feedback);
                if (feedback != "") MessageBox.Show(feedback, "Error Conf Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ConferenceAdmin.ConferenceUpdate.ConferenceTypes frm_types = new ConferenceTypes(ds_conf_type);
                    frm_types.ShowDialog();
                    addnew = false;
                    load_conference();
                }


            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void dg_types_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (dg_types.SelectedRows.Count > 0)
                {
                    string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
                    if (feedback != string.Empty || txt_conf_descrip.Text == string.Empty)
                    {
                        MessageBox.Show("Please save the changes you have made to the conference details, before modifying the conference types.", "Save Changes First", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conf_type = Proxy.ConferenceAdmin.get_conference_type(false, txt_conf_code.Text, Int32.Parse(dg_types.SelectedRows[0].Cells[cn_tcode.Name].Value.ToString()), out feedback);
                    if (feedback != "") MessageBox.Show(feedback, "Error Conf Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        ConferenceAdmin.ConferenceUpdate.ConferenceTypes frm_types = new ConferenceTypes(ds_conf_type);
                        frm_types.ShowDialog();
                        addnew = false;
                        load_conference();
                    }
                }


            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_types.SelectedRows.Count > 0)
                {
                    string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
                    if (feedback != string.Empty || txt_conf_descrip.Text == string.Empty)
                    {
                        MessageBox.Show("Please save the changes you have made to the conference details, before modifying the conference types.", "Save Changes First", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to delete " + dg_types.SelectedRows[0].Cells[cn_descrip.Name].Value.ToString() + " from conference types list", "Delete Conference Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        feedback = Proxy.ConferenceAdmin.delete_conference_types(txt_conf_code.Text, Int32.Parse(dg_types.SelectedRows[0].Cells[cn_tcode.Name].Value.ToString()));
                        if (feedback != "") MessageBox.Show(feedback, "Delete Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else load_conference();
                    }
                }

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConferenceBuildings frm_buildings = new ConferenceBuildings();
            frm_buildings.ShowDialog();
            if (frm_buildings.Proceed)
            {
                for (int i = 0; i < frm_buildings.ds_build.tt_conf_build.Rows.Count; i++)
                {
                    bool found = false;
                    NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_conf_buildRow buildrow = frm_buildings.ds_build.tt_conf_build[i];
                    for (int y = 0; y < ds_conference.tt_conf_build.Rows.Count; y++)
                    {
                        if (buildrow.building == ds_conference.tt_conf_build[y].building.ToString()) found = true;
                    }
                    if (found == false)

                    {
                        DataRow newrow = ds_conference.tt_conf_build.NewRow();
                        newrow["building"] = buildrow.building;
                        newrow["building_descrip"] = buildrow.building_descrip;
                        newrow["ccode"] = txt_conf_code.Text;
                        newrow["gender"] = false;
                        ds_conference.tt_conf_build.Rows.InsertAt(newrow, 0);
                        bs_build.DataSource = ds_conference.tt_conf_build;
                    }

                }
            }

        }

        private void btnRemoveBuilding_Click(object sender, EventArgs e)
        {
            if (dv_buildings.SelectedRows.Count > 0)
            {
                string tempbuilding = dv_buildings.SelectedRows[0].Cells[cnBuilding.Name].Value.ToString();

                string feedback = Proxy.ConferenceAdmin.check_delete_conf_building(txt_conf_code.Text, tempbuilding);
                if (feedback == "")
                {
                    if (MessageBox.Show("Are you sure you want to remove " + dv_buildings.SelectedRows[0].Cells[cnBuildingDescrip.Name].Value.ToString() + " from the buildings list?", "Remove Building", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < ds_conference.tt_conf_build.Rows.Count; i++)
                        {
                            NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_conf_buildRow buildrow = ds_conference.tt_conf_build[i];
                            if (buildrow.building == tempbuilding)
                            {
                                ds_conference.tt_conf_build.Rows.Remove(buildrow);
                                return;
                            }
                        }

                    }
                }
                else MessageBox.Show(feedback, "Remove Building", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_gender_CheckedChanged(object sender, EventArgs e)
        {
            display_gender();
        }

        private void display_gender()
        {
            if (chk_gender.Checked) dv_buildings.Columns[cngender.Name].Visible = true;
            else dv_buildings.Columns[cngender.Name].Visible = false;
        }

        private void ConferenceUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (txt_conf_code.Text != string.Empty)
                {
                    string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
                    if (feedback != "")
                    {
                        if (MessageBox.Show(feedback, "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string feedback = Proxy.ConferenceAdmin.check_conf_changes(ds_conference);
            if (feedback != string.Empty || txt_conference.Text == string.Empty)
            {
                MessageBox.Show("Please save the changes you have made to the conference details, before modifying the conference types.", "Save Changes First", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (dte_arrive.Value != null & dte_departure.Value != null)
            {
                if (DateTime.Parse(dte_departure.Value.ToString()) > DateTime.Today)
                {
                    DateTime Arrival = DateTime.Parse(dte_arrive.Value.ToString());
                    DateTime Departure = DateTime.Parse(dte_departure.Value.ToString());

                    if (Arrival < DateTime.Today) Arrival = DateTime.Today;
                    MealProcessing frmMeals = new MealProcessing("Conference", txt_conf_code.Text, "", Arrival, Departure);
                    frmMeals.ShowDialog();
                }
                else MessageBox.Show("Cannot update previous meals ", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please enter start and end dates to continue", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_block_Click(object sender, EventArgs e)
        {
            if (txt_conference.Text == "") MessageBox.Show("Conference name cannot be blank", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ConferenceSys.ConferenceAdmin.Conference_Updates.BlockBooking frmBlock = new ConferenceSys.ConferenceAdmin.Conference_Updates.BlockBooking(txt_conf_code.Text.ToString(), string.Empty, string.Empty, string.Empty, string.Empty);
                frmBlock.ShowDialog();
            }
        }

        private void chk_paid_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_paid.Checked)
                {
                    NS_ConfAdmin.StrongTypesNS.ds_lock_problemsDataSet ds_lock_problems = Proxy.ConferenceAdmin.check_conf_lock(txt_conf_code.Text.ToString());

                    if (ds_lock_problems.tt_lock_problems.Count > 0)

                    {

                        MessageBox.Show("There are problem(s) with this conference, it cannot be marked as Paid In Full, see the report for details.", "Error Lock", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        DataView dvReport = new DataView(ds_lock_problems.tt_lock_problems);
                        string title = txt_conf_code.Text.ToString() + "  " + txt_conference.Text.ToString();
                        ConferenceSys.Reports frmReports = new ConferenceSys.Reports(false, "LockProblems", dvReport, title);
                        frmReports.Show();

                        chk_paid.Checked = false; ds_conference.tt_conference[0].PAID_FULL = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void txt_gl_account_Leave(object sender, EventArgs e)
        {
            /*Check fincore GL Account*/

            if (txt_gl_account.Text.Length > 0 && Global.Global.fincore_status == true)
            {
                bool ok_leave = Proxy.System.checkfincoreGLAccount(txt_gl_account.Text.ToString());
                if (ok_leave == false)
                {
                    MessageBox.Show("Errror " + txt_gl_account.Text.ToString() + " is not a valid Fincore account", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_gl_account.Text = string.Empty;
                    return;
                }
            }
        }
    }
}
