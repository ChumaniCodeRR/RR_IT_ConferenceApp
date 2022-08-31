﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Conference.StrongTypesNS;
using NS_System.StrongTypesNS;
using Utilities;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.AccessControl;


namespace ConferenceSys.ConferenceAdmin
{
    public partial class UpdateReserv : Form
    {

        #region form variables

        bool AddNew;
        string ParentFolio;
        string Folio;
        string ConfCode;
        int totnum;
        int booktrs;

        DateTime prevstart;
        DateTime prevend;

        bool update_details;
        bool LeavePage;
        //int TabIndex;

        DateTime temp_dte;
        string temp_refno;
        string temp_mealtime;
        int temp_mealcount;
        string temp_diet;
        string temp_mealcode;
        string temp_dhall;


        bool BookingAddNew;
        bool MealAddNew;

        string feedback = "";

        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_rooms;
        NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet ds_reserv;
        NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet ds_booking;
        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_ccode;

        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conference;

        public int w_option;

        public UpdateReserv(bool _AddNew, string _ConfCode, string _ParentFolio, string _folio)
        {
            InitializeComponent();
            AddNew = _AddNew;
            ConfCode = _ConfCode;
            ParentFolio = _ParentFolio;
            Folio = _folio;
        }

        #endregion        

        #region form_load

        private void UpdateReserv_Load(object sender, EventArgs e)
        {
            try
            {
                DataView DV_MHalls = new DataView(Global.Global.ds_conf_codes.tt_dhall);
                DV_MHalls.Sort = "detail";
                cb_mhall.DataSource = DV_MHalls;
                cb_mhall.DisplayMember = "detail";
                cb_mhall.ValueMember = "dhall";
                cb_mhall.SelectedIndex = 0;

                ToolTip toolTip1 = new ToolTip();

                // Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;

                // Set up the ToolTip text for the Button and Checkbox.
                toolTip1.SetToolTip(this.btn_cancel_main, "Cancel all Reservations");
                toolTip1.SetToolTip(this.btn_add_main_meals, "Add all Meals");

                toolTip1.SetToolTip(this.btn_dates, "Modify Start or End Dates");
                toolTip1.SetToolTip(this.btn_meals, "Modify Meals");
                toolTip1.SetToolTip(this.btn_discount, "Adjust Group Discount");
                toolTip1.SetToolTip(this.btn_allocate_room, "Auto book everyone into a building");
                toolTip1.SetToolTip(this.btn_word_letter, "Print MS Word Confirmation Letter");
                toolTip1.SetToolTip(this.btn_email, "Email Confirmation to Group Leader");
                toolTip1.SetToolTip(this.btn_grp_report, "Group Report");
                toolTip1.SetToolTip(this.btn_fin_report, "Financial Report");

                btn_cancel_changes.Enabled = false;

                Dte_start.Value = DateTime.Today;
                dte_end.Value = DateTime.Today;

                dteBookStart.Value = DateTime.Today;
                dteBookEnd.Value = DateTime.Today;

                txt_guests.Text = "1";
                if (ParentFolio == "0") pnl_guests.Visible = true;
                else pnl_guests.Visible = false;

                if (AddNew == true) update_details = true;
                else
                {
                    update_details = false;
                    cb_type.Enabled = false;
                    //btnsearch.Enabled = false;
                    txt_titl.Enabled = false;
                    txt_name.Enabled = false;
                    txt_surn.Enabled = false;
                    txt_staff_stuno_other.Enabled = false;
                }


                cb_type.Items.Add(new Item("Student", "S"));
                cb_type.Items.Add(new Item("Staff", "R"));
                cb_type.Items.Add(new Item("Other", "O"));
                cb_type.SelectedIndex = 0;
                bool conf_admin;
                string feedback = string.Empty;
                ds_conference = Proxy.ConferenceAdmin.get_conference(false, ConfCode, out conf_admin, out feedback);
                ds_ccode = Proxy.ConferenceAdmin.get_conf_halls(ConfCode);
             

                    cb_meal.Items.Add(new Item("Breakfast", "B"));
                    cb_meal.Items.Add(new Item("Lunch", "L"));
                    cb_meal.Items.Add(new Item("Supper", "S"));

                    if (ds_ccode.tt_ccode_hall.Rows.Count > 0)
                    {
                        DataView DV_Halls = new DataView(ds_ccode.tt_ccode_hall);
                        DV_Halls.Sort = "descrip";
                        bsHall.DataSource = DV_Halls;
                        cbHall.SelectedIndex = 0;

                        FilterResidence();
                    }

                    NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conf_types = Proxy.ConferenceAdmin.get_conference_types(ConfCode);
                    bs_conf_types.DataSource = ds_conf_types.tt_conf_type;
                    bs_conf_types2.DataSource = ds_conf_types.tt_conf_type;

                    if (ds_conf_types.tt_conf_type.Rows.Count <= 0)
                    {
                        MessageBox.Show("You must first allocate conference types to this conference, before trying to update reservations/bookings", "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Close();
                        return;
                    }
                    
                    NS_Conference.StrongTypesNS.ds_conference_lookupDataSet ds_diets = Global.Global.ds_conference_lookups;
                    bs_diets.DataSource = bs_m_diets.DataSource = bs_diets2.DataSource = ds_diets.tt_diets;
                    
                    NS_System.StrongTypesNS.ds_genDataSet ds_m_status = Proxy.System.Get_Gen("*", "MC");
                    for (int i = 0; i < ds_m_status.TT_GEN.Rows.Count; i++)
                    {
                        NS_System.StrongTypesNS.ds_genDataSet.TT_GENRow meal_status = ds_m_status.TT_GEN[i];
                        if (meal_status.code == "N")
                        {
                            ds_m_status.TT_GEN.Rows.Remove(meal_status);                           
                        }
                    }
                    bs_m_status.DataSource = ds_m_status.TT_GEN;

                    sc_bookings.Panel1.Enabled = true;
                    sc_bookings.Panel2Collapsed = true;

                    sc_meals.Panel1.Enabled = true;
                    sc_meals.Panel2Collapsed = true;

                    sc_transactions.Panel1.Enabled = true;
                    sc_transactions.Panel2Collapsed = true;

                    get_reservation();

                    cbHouse_SelectedIndexChanged(sender, e);

                    this.cb_type.Focus();
                    this.cb_type.Select();

                
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        #endregion

        #region form events

        private void lbl_main_folio_Click(object sender, EventArgs e)
        {
            if (txt_parentfolio.Text != string.Empty)
            {
                Folio = txt_parentfolio.Text;
                get_reservation();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FilterResidence()
        {
            if (cbHall.Items.Count > 0 && cbHall.SelectedIndex == -1) cbHall.SelectedIndex = 0;
        
            if (ds_ccode.tt_ccode_res.Rows.Count > 0)
            {
                DataView dvRes = new DataView(ds_ccode.tt_ccode_res);
                dvRes.RowFilter = string.Format("shall = '{0}'", cbHall.SelectedValue.ToString());
                bsHouse.DataSource = dvRes;
            }
        }

        private void set_fields()
        {

            if (ds_reserv.tt_reservations[0].conf_admin == false || ds_reserv.tt_reservations[0].conf_locked == true)
            { gb_updates.Enabled = pnl_details_update.Visible = pnl_meals.Visible = pnl_booking_update.Visible = gb_reports.Enabled = false; }

            else gb_updates.Enabled = pnl_details_update.Visible = pnl_meals.Visible = pnl_booking_update.Visible = gb_reports.Enabled = true;

            if (update_details == true)
            {
                pnl_header.Enabled = false;
                pnl_details.Enabled = true;
                pnl_booking.Enabled = true;
                btn_save_details.Text = "Save Details";
                TabIndex = Int32.Parse(tb_reservation.SelectedIndex.ToString());
            }
            else
            {
                pnl_header.Enabled = true;
                pnl_details.Enabled = false;
                pnl_booking.Enabled = false;
                btn_save_details.Text = "Update Details";
                LeavePage = true;
            }

            /* New Booking, wait for information */
            if (txt_parentfolio.Text == string.Empty) gb_reports.Enabled = gb_updates.Enabled = false;
            
        }

        #endregion

        #region reservation details

        private void cb_reservation_lookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_reservation_lookup.Enabled == true)
            {
                Folio = cb_reservation_lookup.SelectedValue.ToString();
                if (cb_reservation_lookup.Text.Contains("UNKNOWN"))
                {
                    cb_type.Enabled = true;
                    btnsearch.Enabled = true;
                }
                else
                {
                    cb_type.Enabled = false;
                    btnsearch.Enabled = false;
                }
                get_reservation();
            }
        }

        // Double Reservation
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_double.Checked == true) pnl_diet.Visible = true;
            else pnl_diet.Visible = false;
        }

        // Print Reservation
        private void button1_Click_1(object sender, EventArgs e)
        {
            NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet ds_report = Proxy.ConferenceAdmin.reservation_report(false, ds_reserv.tt_reservations[0].folio.ToString());
            if (ds_report.tt_reservations.Rows.Count > 0)
            {
                Reports frmReport = new Reports("ReservationReport", ds_report);
                frmReport.Show();
            }
        }

        private void cb_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex != -1)
            {
                if (((Item)cb_type.SelectedItem).Value.ToString() == "S" | ((Item)cb_type.SelectedItem).Value.ToString() == "R")
                {
                    txt_titl.Enabled = txt_name.Enabled = txt_surn.Enabled = txt_staff_stuno_other.Enabled = rb_male.Enabled = rb_female.Enabled = false;
                    txt_staff_stuno_other.Visible = btnsearch.Visible = true;
                    if (((Item)cb_type.SelectedItem).Value.ToString() == "R") rb_male.Enabled = rb_female.Enabled = true;
                }
                else
                {
                    txt_titl.Enabled = txt_name.Enabled = txt_surn.Enabled = rb_male.Enabled = rb_female.Enabled = true;
                    txt_staff_stuno_other.Visible = btnsearch.Visible = false;
                }
            }
        }

        private void get_reservation()
        {
            try
            {
                rb_female.Checked = true;
                ds_reserv = Proxy.ConferenceAdmin.get_a_reservation(AddNew, ConfCode, ParentFolio, Folio, out feedback);
                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    txtConference.Text = ds_reserv.tt_reservations[0].ConferenceDescrip;
                    NS_Conference.StrongTypesNS.ds_mealsDataSet ds_meals = Proxy.ConferenceSystem.Get_Reservation_Meals(ds_reserv.tt_reservations[0].folio);
                    
                    dgvMeals.DataSource = ds_meals.TT_MEALS;
                    bs_resrvation.DataSource = ds_reserv.tt_reservations;
                    bs_bookings.DataSource = ds_reserv.tt_bookings;
                    bs_cnftrs.DataSource = ds_reserv.tt_cnftrs;
                    bs_reservation_lookup.DataSource = ds_reserv.tt_res_lookup;
                    bs_conf_let.DataSource = ds_reserv.tt_cnflet;

                    cb_reservation_lookup.Enabled = false;
                    cb_reservation_lookup.SelectedValue = ds_reserv.tt_reservations[0].folio;
                    cb_reservation_lookup.Enabled = true;

                    if (ds_reserv.tt_reservations[0].gender_specific) pnl_gender.Visible = true;
                    else pnl_gender.Visible = false;

                    set_fields();

                    cb_reservation_lookup.Focus();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }         

        }

        bool ValidDetailsForReservation()
        {

            bool valid = true;

            if (cb_type.SelectedIndex < 0)
            {
                valid = false;
                errorProvider.SetError(cb_type, "Please select guest type to continue");
            }

            if (((Item)cb_type.SelectedItem).Value.ToString() != "O" && txt_staff_stuno_other.Text.Trim().Length == 0)
            {
                valid = false;
                errorProvider.SetError(txt_staff_stuno_other, "Please select staff/student number to continue");
            }

            if (txt_surn.Text.Trim().Length.Equals(0))
            {
                valid = false;
                errorProvider.SetError(txt_surn, "Guest surname cannot be blank");
            }
            if (txt_guests.Text.Trim().Length > 0)
            {
                bool proceed = int.TryParse(txt_guests.Text.ToString(), out totnum);

                if (proceed == false)
                {
                    valid = false;
                    errorProvider.SetError(txt_guests, "Please enter a number");
                }
            }

            if (cb_conf_type.SelectedIndex < 0)
            {
                valid = false;
                errorProvider.SetError(cb_conf_type, "Please select book type to continue");
            }

    
            return valid;
        }

        bool ValidationCheck()
        {
            bool valid = true;           

            if (cb_diet.SelectedIndex < 0)
            {
                valid = false;
                errorProvider.SetError(cb_diet, "Please select diet to continue");
            }           

            if (chk_tax_invoice.Checked == true && txt_tax_addr.Text == "") 
            {
                valid = false;
                errorProvider.SetError(txt_tax_addr, "Please enter tax invoice address");
            }    

            return valid;
        }
              
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btn_save_details.Text == "Save Details")
                {
                    if (Dte_start.Text != " " && dte_end.Text != " ")
                    {
                        if (DateTime.Parse(Dte_start.Text) > DateTime.Parse(dte_end.Text))
                        {
                            MessageBox.Show("Error - Start date cannot be after end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (cb_type.SelectedIndex == -1) MessageBox.Show("Please select Guest Type to continue", "Guest Type", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    else
                    {
                        errorProvider.Clear();
                        if (ValidDetailsForReservation())
                        {
                            string NewParent = "";
                            string NewFolio = "";

                            string feedback = Proxy.ConferenceAdmin.update_reservation(AddNew, ParentFolio, totnum, ds_reserv, out NewParent, out NewFolio);
                            MessageBox.Show(feedback, "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!feedback.Contains("Error"))
                            {
                                btn_cancel_changes.Enabled = false;
                                update_details = false;
                                LeavePage = true;
                                AddNew = false;
                                ParentFolio = NewParent;
                                Folio = NewFolio;
                                get_reservation();
                            }
                        }
                    }
                }
                else
                {
                    btn_cancel_changes.Enabled = true;
                    update_details = true;
                    LeavePage = false;
                    set_fields();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }         
        }

        private void btn_save_booking_Click(object sender, EventArgs e)
        {
            try
            {
                TabIndex = Int32.Parse(tb_reservation.SelectedIndex.ToString());
                if (btn_save_booking.Text == "Save Booking")
                {
                    if (cb_type.SelectedIndex == -1) MessageBox.Show("Please select Guest Type to continue", "Guest Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        errorProvider.Clear();
                        if (ValidationCheck())
                        {
                            string NewParent = "";
                            string NewFolio = "";

                            string feedback = Proxy.ConferenceAdmin.update_reservation(AddNew, ParentFolio, totnum, ds_reserv, out NewParent,out NewFolio);
                            MessageBox.Show(feedback, "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!feedback.Contains("Error"))
                            {
                                LeavePage = true;
                                pnl_booking.Enabled = false;
                                btn_save_booking.Text = "Update Booking";
                                ParentFolio = NewParent;
                                Folio = NewFolio;
                                get_reservation();
                            }
                        }
                    }
                }
                else
                {
                    LeavePage = false;
                    pnl_booking.Enabled = true;
                    btn_save_booking.Text = "Save Booking";
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }         
        }

        private void tb_reservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LeavePage)
            {
                if (tb_reservation.SelectedIndex != TabIndex)
                {
                    MessageBox.Show("Error - Please save information before leaving this page", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_reservation.SelectedIndex = TabIndex;
                }
            }     
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex < 0) MessageBox.Show("Please select Guest Type to continue", "Guest Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                if (((Item)cb_type.SelectedItem).Value.ToString() == "S")
                {
                    Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(true);
                    frmStuSearch.ShowDialog();
                    if (frmStuSearch.Stuno != "")
                    {
                        txt_staff_stuno_other.Text = frmStuSearch.Stuno;
                        Load_Person();
                    }

                }
                if (((Item)cb_type.SelectedItem).Value.ToString() == "R")
                {
                    NS_System.StrongTypesNS.DS_ISD_DATADataSet ds_empnos = new NS_System.StrongTypesNS.DS_ISD_DATADataSet();
                    SearchEmployee.Search_Protea_Users frm_search_users = new SearchEmployee.Search_Protea_Users(true, ds_empnos);
                    frm_search_users.ShowDialog();
                    if (frm_search_users.UserId != "")
                    {
                        txt_staff_stuno_other.Text = frm_search_users.UserId;
                        Load_Person();
                    }
                }
            }
        }

        private void Load_Person()
        {
            try
            {
                string name1 = "";
                string email = "";
                string contact_no = "";
                string title = "";
                bool gender;
                string surname = Proxy.System.get_personal_details(((Item)cb_type.SelectedItem).Value.ToString(), txt_staff_stuno_other.Text, out name1, out email, out contact_no, out title, out gender);
                rb_female.Checked = true;
                rb_male.Checked = gender;
                txt_surn.Text = surname;
                txt_name.Text = name1;
                txt_contact_no.Text = contact_no;
                txt_email.Text = email;
                txt_titl.Text = title;

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        #endregion

        #region booking details

        private void btn_chk_available_Click(object sender, EventArgs e)
        {

            bs_rooms.DataSource = null;

            if (dteBookStart.Text == " " || dteBookEnd.Text == " ")
            {
                MessageBox.Show("Error - You must enter a start date and an end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DateTime.Parse(dteBookStart.Text) > DateTime.Parse(dteBookEnd.Text))
            {
                MessageBox.Show("Error - Start date cannot be after end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbBuilding.SelectedIndex > -1)
            {
                string ownroom = string.Empty;
                string otherfolio = string.Empty;
                bool doubles_only = false;
                ds_rooms = Proxy.ConferenceAdmin.check_available_rooms(ds_reserv.tt_reservations[0].folio.ToString(), cbBuilding.SelectedValue.ToString(), DateTime.Parse(dteBookStart.Text), DateTime.Parse(dteBookEnd.Text), cb_double_rooms.Checked, out ownroom, out otherfolio, out doubles_only);
                if (ownroom != string.Empty && otherfolio == string.Empty)
                {
                    MessageBox.Show("This student resides in this building in room " + ownroom + ". Room has been automatically selected.", "Room Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_booked_room.Visible = true;
                    txt_booked_room.Text = ownroom;
                    cbRooms.Visible = false;
                }
                else
                {
                    if (ownroom != string.Empty && otherfolio != string.Empty) MessageBox.Show("This student lives in the building in room " + ownroom + " but there is a guest (Folio: " + otherfolio + ") already booked into their room.", "Room Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ds_rooms.tt_rooms.Rows.Count < 1) MessageBox.Show("There are no available rooms in " + cbBuilding.Text.ToString() + " please select another building to continue.", "No Rooms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (doubles_only) MessageBox.Show("There are no single rooms left in this building. Double rooms have as a result been listed below. If you need a single room then please select another building", "No more single rooms available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataView dvRooms = new DataView(ds_rooms.tt_rooms);
                        dvRooms.Sort = "sort_field";
                        bs_rooms.DataSource = dvRooms;
                        cbRooms.Visible = true;
                        txt_booked_room.Visible = false;
                        cbRooms.SelectedIndex = -1;
                    }
                }
            }
            else MessageBox.Show("Please select a building to continue", "Error Building", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRooms.SelectedIndex > -1) txt_booked_room.Text = cbRooms.SelectedValue.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BookingAddNew = true;
            booktrs = 0;
            if (cbHall.Items.Count > 0) cbHall.SelectedIndex = 0;
            else cbHall.SelectedIndex = -1; 

            dteBookStart.MinDate = DateTimePicker.MinimumDateTime;
            dteBookStart.MaxDate = DateTimePicker.MaximumDateTime;
            dteBookEnd.MinDate = DateTimePicker.MinimumDateTime;
            dteBookEnd.MaxDate = DateTimePicker.MaximumDateTime;
            Dte_start.MinDate = DateTimePicker.MinimumDateTime;
            Dte_start.MaxDate = DateTimePicker.MaximumDateTime;
            Dte_start.MinDate = DateTimePicker.MinimumDateTime;
            Dte_start.MaxDate = DateTimePicker.MaximumDateTime;

            string feedback = Proxy.ConferenceAdmin.get_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, 0, out ds_booking);
            if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                booking_update_screen_refresh();
                FilterResidence();

                if (dteBookStart.Text != " ") if (DateTime.Parse(dteBookStart.Text) <= DateTime.Today) dteBookStart.Value = DateTime.Today;
                dteBookStart.MinDate = DateTime.Today;

                if (dteBookEnd.Text != " ") if (DateTime.Parse(dteBookEnd.Text) <= DateTime.Today) dteBookEnd.Value = DateTime.Today.AddDays(1);
                dteBookEnd.MinDate = DateTime.Today;                    
               
                TabIndex = Int32.Parse(tb_reservation.SelectedIndex.ToString());
                lbl_rooms.Text = "Available Rooms:";
                cbRooms.Visible = true;
                txt_booked_room.Visible = false;
              
                LeavePage = false;
                update_details = true;
                set_fields();
            }
        }

        private void cbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_buildings();
        }

        private void filter_buildings()
        {
            if (ds_ccode.tt_ccode_res.Rows.Count > 0)
            {
                if (cbHouse.SelectedIndex == -1) cbHouse.SelectedIndex = 0;
            }

            if (ds_ccode.tt_ccode_build.Rows.Count > 0)
            {
                DataView dvBuilding = new DataView(ds_ccode.tt_ccode_build);
                
                if (ds_reserv.tt_reservations.Rows.Count == 1 && ds_reserv.tt_reservations[0]["gender_specific"].ToString() == "True")
                {
                    dvBuilding.RowFilter = string.Format("res = '{0}' and gender = '{1}'", cbHouse.SelectedValue.ToString(), ds_reserv.tt_reservations[0]["gender"].ToString());
                }
                else dvBuilding.RowFilter = string.Format("res = '{0}'", cbHouse.SelectedValue.ToString());
                bsBuilding.DataSource = dvBuilding;
            }
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds_rooms != null) ds_rooms.tt_rooms.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (dteBookStart.Text == " " || dteBookEnd.Text == " ")
            {
                MessageBox.Show("Error - You must enter a start date and an end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DateTime.Parse(dteBookStart.Text) > DateTime.Parse(dteBookEnd.Text))
            {
                MessageBox.Show("Error - Start date cannot be after end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (cbHall.SelectedIndex == -1) MessageBox.Show("Error - Please select a hall to proceed", "Error Hall", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cbHouse.SelectedIndex == -1) MessageBox.Show("Error - Please select a residence to proceed", "Error Res", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cbBuilding.SelectedIndex == -1) MessageBox.Show("Error - Please select a building to proceed", "Error Building", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_booked_room.Text == "") MessageBox.Show("Error - Please select a room to proceed", "Error Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string room_num = txt_booked_room.Text;
                if (txt_booked_room.Visible == false) room_num = cbRooms.SelectedValue.ToString();
                if (BookingAddNew == true && DateTime.Parse(dteBookStart.Text) < DateTime.Today.AddDays(2))
                {
                    if (MessageBox.Show("This booking request starts within the next 2 days, and as a result you will not be able to modify the start date once the booking has been made. Are you sure you want to proceed with this booking?", "Confrimation of Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    
                }

                TimeSpan span = DateTime.Parse(dteBookEnd.Text) - DateTime.Parse(dteBookStart.Text);
                if (span.TotalDays >= 14)
                {
                    if (MessageBox.Show("This booking is longer than 2 weeks. Are you sure you want to continue with the booking request?", "Confrimation of Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                }

                string feedback = Proxy.ConferenceAdmin.update_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, ref booktrs, Int32.Parse(cbHouse.SelectedValue.ToString()), cbBuilding.SelectedValue.ToString(), room_num, Int32.Parse(txt_mattress.Text), DateTime.Parse(dteBookStart.Text), DateTime.Parse(dteBookEnd.Text), cb_double_rooms.Checked, cb_book_conf_type.SelectedValue.ToString());
                if (feedback.Contains("Error")) MessageBox.Show(feedback, "Update Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DefaultHall frmHall = new DefaultHall(feedback, booktrs, ds_reserv.tt_reservations[0].folio, prevstart, prevend);
                    frmHall.ShowDialog();

                    sc_bookings.Panel1.Enabled = true;
                    sc_bookings.Panel2Collapsed = true;
                    LeavePage = true;
                    get_reservation();
                    update_details = false;
                    set_fields();
                }
            }
        }

        private void booking_update_screen_refresh()
        {
            dteBookStart.Enabled = dteBookEnd.Enabled = cbHall.Enabled = cbHouse.Enabled = cbBuilding.Enabled = txt_booked_room.Enabled = cbRooms.Enabled = true;
            btn_chk_available.Enabled = btn_save.Enabled = btn_cancel_bookings.Enabled = txt_mattress.Enabled = cb_double_rooms.Enabled = true;

            sc_bookings.Panel1.Enabled = false;
            sc_bookings.Panel2Collapsed = false;
            bs_book_update.DataSource = ds_booking.tt_bookings;
        }

        private void dg_bookings_DoubleClick(object sender, EventArgs e)
        {
            if (dg_bookings.SelectedRows.Count > 0 &&  ds_reserv.tt_reservations[0].conf_admin && ds_reserv.tt_reservations[0].conf_locked == false)
            {
                BookingAddNew = false;
                booktrs = Int32.Parse(dg_bookings.SelectedRows[0].Cells[cn_booking_ref.Name].Value.ToString());

                /* Reset Date Time Picker Min/Max Dates */
                dteBookStart.MinDate = DateTimePicker.MinimumDateTime;
                dteBookStart.MaxDate = DateTimePicker.MaximumDateTime;
                dteBookEnd.MinDate = DateTimePicker.MinimumDateTime;
                dteBookEnd.MaxDate = DateTimePicker.MaximumDateTime;
                Dte_start.MinDate = DateTimePicker.MinimumDateTime;
                Dte_start.MaxDate = DateTimePicker.MaximumDateTime;
                Dte_start.MinDate = DateTimePicker.MinimumDateTime;
                Dte_start.MaxDate = DateTimePicker.MaximumDateTime;

                string feedback = Proxy.ConferenceAdmin.get_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, booktrs, out ds_booking);
                if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    booking_update_screen_refresh();

                    prevstart = DateTime.Parse(ds_booking.tt_bookings[0]["start_dte"].ToString());
                    prevend = DateTime.Parse(ds_booking.tt_bookings[0]["end_dte"].ToString());

                    lbl_rooms.Text = "Booked Room:";
                    cbRooms.Visible = false;
                    txt_booked_room.Visible = true;

                    /* Cannot make any changes since booking is in the past */
                    if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_end_dte.Name].Value.ToString()) <= DateTime.Today.AddDays(2))
                    {
                        dteBookStart.Enabled = false;
                        dteBookEnd.Enabled = false;
                        cbHall.Enabled = false;
                        cbHouse.Enabled = false;
                        cbBuilding.Enabled = false;
                        txt_booked_room.Enabled = false;
                        cbRooms.Enabled = false;
                        btn_chk_available.Enabled = false;
                        btn_save.Enabled = false;
                        btn_cancel_bookings.Enabled = true;
                        txt_mattress.Enabled = false;
                        cb_double_rooms.Enabled = false;
                    }

                    /* Cannot change the Start Date since it is in the past */
                    else if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_start_dte.Name].Value.ToString()) < DateTime.Today.AddDays(2))
                    {
                        dteBookStart.Enabled = false;
                        dteBookEnd.MinDate = DateTime.Today.AddDays(2);
                        cb_double_rooms.Enabled = false;
                    }

                    /* Otherwise set min dates on both date fields */
                    else
                    {
                        dteBookStart.MinDate = DateTime.Today;
                        dteBookEnd.MinDate = DateTime.Today;
                    }

                    LeavePage = false;
                    update_details = true;
                    set_fields();
                }
            }
            else MessageBox.Show("Error - You may not modify this booking", "Booking Update", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        // cancel booking update 
        private void button2_Click(object sender, EventArgs e)
        {
            LeavePage = true;
            sc_bookings.Panel1.Enabled = true;
            sc_bookings.Panel2Collapsed = true;

            update_details = false;
            btn_cancel_changes.Enabled = false;
            set_fields();
        }

        private void cbHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResidence();
            filter_buildings();            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_bookings.SelectedRows.Count > 0)
                {
                    if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_start_dte.Name].Value.ToString()) <= DateTime.Today) MessageBox.Show("Error - You can delete future bookings only", "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this booking?", "Delete Booking ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string folio = ds_reserv.tt_reservations[0].folio.ToString();
                            int booktrs = Int32.Parse(dg_bookings.SelectedRows[0].Cells[cn_booking_ref.Name].Value.ToString());
                            string hallcode = dg_bookings.SelectedRows[0].Cells[cn_booking_hall_code.Name].Value.ToString();
                            string feedback = Proxy.ConferenceAdmin.delete_booking(folio, booktrs, hallcode);
                            MessageBox.Show(feedback, "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!feedback.Contains("Error")) get_reservation();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        #endregion

        #region meals update

        private void btn_add_meal_Click(object sender, EventArgs e)
        {
            MealAddNew = true;
            dte_mdate.Value = DateTime.Today.AddDays(2);
            dte_mdate.MinDate = DateTime.Today.AddDays(2);
            dte_mdate.Enabled = true;

            cb_meal.Enabled = true;

            cb_mstatus.SelectedValue = "B";
            cb_mstatus.Enabled = false;


            LeavePage = false;
            update_details = true;

            sc_meals.Panel1.Enabled = false;
            sc_meals.Panel2Collapsed = false;


            set_fields();
        }
        /*
        private void btn_x_meal_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0)
            {
                temp_dte = DateTime.Parse(dgvMeals.SelectedRows[0].Cells[cmdate.Name].Value.ToString());

                if (temp_dte < DateTime.Today.AddDays(1)) MessageBox.Show("You can only cancel future meals", "Error Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (MessageBox.Show("Are you sure you want to cancel the meal?", "Cancel Meal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LeavePage = false;
                        update_details = true;

                        temp_refno = txt_folio.Text.ToString();
                        temp_mealtime = dgvMeals.SelectedRows[0].Cells[cMEAL_TIME.Name].Value.ToString();

                        temp_mealcount = int.Parse(dgvMeals.SelectedRows[0].Cells[cmcnt.Name].Value.ToString());

                        string feedback = Proxy.ConferenceAdmin.cancel_a_meal(temp_refno, temp_mealtime, temp_dte, temp_mealcount);
                        MessageBox.Show(feedback, "Cancel Meal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        get_reservation();
                    }
                }
            }
        }
        */
        private void btn_meals_Click(object sender, EventArgs e)
        {
            if (Dte_start.Value != null & dte_end.Value != null)
            {
                if (DateTime.Parse(dte_end.Value.ToString()) > DateTime.Today)
                {
                    DateTime Arrival = DateTime.Parse(Dte_start.Value.ToString());
                    DateTime Departure = DateTime.Parse(dte_end.Value.ToString());

                    if (Arrival <= DateTime.Today.AddDays(1)) Arrival = DateTime.Today.AddDays(1);
                    MealProcessing frmMeals = new MealProcessing("Groups", ds_reserv.tt_reservations[0].ccode, ds_reserv.tt_reservations[0].parentfolio, Arrival, Departure);
                    frmMeals.ShowDialog();
                    get_reservation();
                }
                else MessageBox.Show("Cannot update previous meals ", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please enter start and end dates to continue", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_xl_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to cancel all the meals for this folio?", " Cancel All Meals ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string feedback = Proxy.ConferenceAdmin.XL_ALL_MEALS(ds_reserv.tt_reservations[0].folio);
                    MessageBox.Show(feedback, "Cancel Meals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NS_Conference.StrongTypesNS.ds_mealsDataSet ds_meals = Proxy.ConferenceSystem.Get_Reservation_Meals(ds_reserv.tt_reservations[0].folio);
                    dgvMeals.DataSource = ds_meals.TT_MEALS;
                }
            }
             catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            LeavePage = true;
            update_details = false;
            btn_save_details.Text = "Update Details";
            btn_cancel_changes.Enabled = false;
            set_fields();
        }

        private void dgvMeals_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0 && ds_reserv.tt_reservations[0].conf_admin && ds_reserv.tt_reservations[0].conf_locked == false)
            {


                temp_dte = DateTime.Parse(dgvMeals.SelectedRows[0].Cells[cmdate.Name].Value.ToString());

                if (temp_dte >= DateTime.Today.AddDays(2))
                {
                    LeavePage = false;
                    update_details = true;

                    MealAddNew = false;


                    temp_refno = txt_folio.Text.ToString();
                    temp_mealtime = dgvMeals.SelectedRows[0].Cells[cMEAL_TIME.Name].Value.ToString();
                    temp_mealcount = int.Parse(dgvMeals.SelectedRows[0].Cells[cmcnt.Name].Value.ToString());

                    dte_mdate.Value = temp_dte;
                    cb_meal.SelectedIndex = cb_meal.FindString(dgvMeals.SelectedRows[0].Cells[cmtime1.Name].Value.ToString());
                    dte_mdate.Enabled = false;
                    cb_meal.Enabled = false;

                    cb_mdiet.SelectedValue = dgvMeals.SelectedRows[0].Cells[cdiet.Name].Value.ToString();
                    cb_mhall.SelectedValue = dgvMeals.SelectedRows[0].Cells[cdhall.Name].Value.ToString();
                    cb_mstatus.SelectedValue = dgvMeals.SelectedRows[0].Cells[cmealcode.Name].Value.ToString();
                    cb_mstatus.Enabled = true;

                    sc_meals.Panel1.Enabled = false;
                    sc_meals.Panel2Collapsed = false;                    

                    set_fields();
                }
              
            }
        }

        private void btn_cancel_meal_Click(object sender, EventArgs e)
        {
            sc_meals.Panel1.Enabled = true;
            sc_meals.Panel2Collapsed = true;
            btn_xl_all.Visible = true;
            LeavePage = true;
            update_details = false;

            set_fields();
        }

        private void btn_save_meal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_meal.SelectedIndex == -1) MessageBox.Show("Please select meal time to proceed", "Error Meal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cb_mhall.SelectedIndex == -1) MessageBox.Show("Please select dinning hall to proceed", "Error Hall", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    temp_diet = cb_mdiet.SelectedValue.ToString();
                    temp_mealcode = cb_mstatus.SelectedValue.ToString();
                    temp_dhall = cb_mhall.SelectedValue.ToString();
                    temp_mealtime = ((Item)cb_meal.SelectedItem).Value.ToString();
                    string feedback = "";
                    if (MealAddNew == false) feedback = Proxy.ConferenceSystem.update_reserv_meal(MealAddNew,temp_dte, temp_refno, temp_mealtime, temp_mealcount, temp_diet, temp_mealcode, temp_dhall);
                    if (MealAddNew == true) feedback = Proxy.ConferenceAdmin.create_single_meal(txt_folio.Text,dte_mdate.Value,temp_mealtime, temp_diet, temp_dhall);
                    MessageBox.Show(feedback, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!feedback.Contains("Error"))
                    {
                        NS_Conference.StrongTypesNS.ds_mealsDataSet ds_meals = Proxy.ConferenceSystem.Get_Reservation_Meals(ds_reserv.tt_reservations[0].folio);
                        dgvMeals.DataSource = ds_meals.TT_MEALS;

                        sc_meals.Panel1.Enabled = true;
                        sc_meals.Panel2Collapsed = true;
                        LeavePage = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        #endregion

        #region group updates

        private void btn_grp_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option is not currently available", "Future report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            string feedback = Proxy.ConferenceAdmin.check_prior_confirmation(txt_parentfolio.Text);

            if (feedback == string.Empty) feedback = "Are you sure you want to send a booking confirmation email to the group leader?";
            if (MessageBox.Show(feedback, "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            NS_ConfAdmin.StrongTypesNS.ds_lettersDataSet ds_letters = Proxy.ConferenceAdmin.produce_confirmation(txt_parentfolio.Text, "E", out feedback);
            MessageBox.Show(feedback, "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!feedback.StartsWith("Error")) get_reservation();

        }

        private void btn_allocate_room_Click(object sender, EventArgs e)
        {
            ConfBuildings frmBuildings = new ConfBuildings(ds_reserv.tt_reservations[0].ccode, ds_reserv.tt_reservations[0].parentfolio);
            frmBuildings.ShowDialog();
            get_reservation();
        }

        private void btn_dates_Click(object sender, EventArgs e)
        {
            ResetBookDates frmDates = new ResetBookDates(ds_reserv.tt_reservations[0].ccode, ds_reserv.tt_reservations[0].parentfolio);
            frmDates.ShowDialog();
            get_reservation();
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            Discount frmDiscount = new Discount(txt_surn.Text + " " + txt_institution.Text, ParentFolio);
            frmDiscount.ShowDialog();
            get_reservation();
        }

        private void btn_cancel_main_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to cancel all the reservations under this main folio?", " Cancel Reservations", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string feedback = Proxy.ConferenceAdmin.xl_parentfolio_reservations(ds_reserv.tt_reservations[0].parentfolio);
                    MessageBox.Show(feedback, "Cancel Resevations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btn_add_main_meals_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add all meals for this main folio?", "Meal Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string feedback = Proxy.ConferenceAdmin.create_meals_for_the_group(ds_reserv.tt_reservations[0].parentfolio);
                    MessageBox.Show(feedback, "Meal Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!feedback.Contains("Error")) get_reservation();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        #endregion

        #region fin_report

        private void btn_fin_report_Click(object sender, EventArgs e)
        {
            try
            {
                string parentfolio = ds_reserv.tt_reservations[0].parentfolio;
                bool det_sum = true;

                string conf_descrip = "Conference = " + txtConference.Text;
                bool print_zeros = true;

                NS_Conference.StrongTypesNS.ds_financialDataSet ds_financial = Proxy.ConferenceSystem.financial_report(ds_reserv.tt_reservations[0].ccode, "*", parentfolio, "*", print_zeros, out feedback);
                if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ds_financial.BOOKFILE.Rows.Count < 1) MessageBox.Show("Your query returned no data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        string filename = System.IO.Path.GetTempPath() + "Financial.xls";

                        FileInfo fi1 = new FileInfo(filename);
                        if (File.Exists(filename) && Utils.IsFileLocked(fi1)) 
                        {
                            MessageBox.Show("Error - The file " + filename + " is already in use. Please close it or save the open file with a different name before running this extract", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        RhodesControl.ThinkManager.StartThink("Generating Excel File - Please Wait");

                        try
                        {

                            Excel.Application oXL;
                            Excel.Workbook oWB;
                            Excel.Worksheet oSheet;
                            Excel.Range oRange;

                            // Start Excel and get Application object.
                            oXL = new Excel.Application();

                            // Set some properties
                            oXL.DisplayAlerts = false;

                            // Get a new workbook.
                            oWB = oXL.Workbooks.Add(Missing.Value);

                            // Get the active sheet
                            oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                            oSheet.Name = "Financial";

                            // Process the DataTable
                            DataTable dt1 = ds_financial.BOOKFILE1;
                            DataTable dt2 = ds_financial.MONEYFILE;

                            oSheet.Cells[1, 1] = "Financial Report";
                            oSheet.Cells[1, 3] = conf_descrip;
                            oSheet.Cells[2, 3] = "Main Folio: " + parentfolio.ToString();

                            int rowCount = 0;
                            if (det_sum == false)
                            {
                                string ParentFolio;
                                string Folio;
                                string Room;
                                oSheet.Cells[3, 1] = "Reference";
                                oSheet.Cells[3, 2] = "Details";
                                oSheet.Cells[3, 3] = "Paid";
                                oSheet.Cells[3, 4] = "Write Off";
                                oSheet.Cells[3, 5] = "Adjustment";
                                oSheet.Cells[3, 6] = "Total";
                                rowCount = 3;

                                foreach (DataRow dr in dt1.Rows)
                                {
                                    if (dr[3].ToString() == "Main")
                                    {
                                        dr[3] = "";

                                        rowCount += 1;
                                        int x = 1;
                                        for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                        {

                                            if (i == 14) break;
                                            if (i == 1 | i == 2 | i == 9 | i == 10 | i == 11 | i == 13)
                                            {
                                                oSheet.Cells[rowCount, x] = dr[i - 1].ToString();
                                                x = x + 1;
                                            }
                                        }
                                    }
                                }
                            }

                            if (det_sum == true)
                            {
                                oSheet.Cells[3, 1] = "FOLIO";
                                oSheet.Cells[3, 2] = "NAME";
                                oSheet.Cells[3, 3] = "BUILDING";
                                oSheet.Cells[3, 4] = "ROOM";
                                oSheet.Cells[3, 5] = "START DATE";
                                oSheet.Cells[3, 6] = "END DATE";
                                oSheet.Cells[3, 7] = "RATE";
                                oSheet.Cells[3, 8] = "Cancelled";
                                oSheet.Cells[3, 9] = "Meals";
                                oSheet.Cells[3, 10] = "Breakfast/Paid In";
                                oSheet.Cells[3, 11] = "Lunch/Write Off";
                                oSheet.Cells[3, 12] = "Supper/Refund";
                                oSheet.Cells[3, 13] = "Balance";

                                rowCount = 3;
                                int count = 0;
                                string reference = "";
                                string currentRef = "";

                                foreach (DataRow dr in dt1.Rows)
                                {
                                    currentRef = dr[14].ToString();
                                    if (count > 0 && reference != currentRef) rowCount += 1;

                                    if (dr[3].ToString() == "Main") dr[3] = "";
                                    rowCount += 1;
                                    for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                    {

                                        if (i == 14) break;
                                        oSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                                    }
                                    count = count + 1;
                                    reference = dr[14].ToString();
                                }
                            }

                            // Resize the columns
                            oRange = oSheet.Range[oSheet.Cells[1, 1],
                            oSheet.Cells[rowCount, dt2.Columns.Count]];
                            oRange.EntireColumn.AutoFit();

                            // Save the sheet and close
                            oSheet = null;
                            oRange = null;
                            
                            oWB.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal,
                                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                Excel.XlSaveAsAccessMode.xlExclusive,
                                Missing.Value, Missing.Value, Missing.Value,
                                Missing.Value, Missing.Value);

                            oWB = null;
                            oXL.Visible = true;

                            // Clean up
                            // NOTE: When in release mode, this does the trick
                            GC.WaitForPendingFinalizers();
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            GC.Collect();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message, "Error with Export", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    finally
                    {
                        RhodesControl.ThinkManager.EndThink();
                        this.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ResOps, ex);
            }
        }

        #endregion
        
        #region mailmerge

        /// <summary>
        /// Validates if template file exists in the template directory, and if user has write permissions to the output directory
        /// </summary>
        /// <param name="templateFile">Template file</param>
        /// <param name="outputDirectory">Output file directory</param>
        /// <returns>True if template file exists and user has write permissions to the output directory, otherwise False</returns>
        static bool ValidTemplateFileAndWritePermission(string templateFile, string outputDirectory)
        {
            //Check if template file exists in the template directory
            if (!string.IsNullOrEmpty(templateFile) && !File.Exists(templateFile))
            {
                string msg = "Could not locate the template files. Please make sure they are in the path specified under the 'Tools --> Letter Settings' Menu";
                MessageBox.Show(msg, "Batch Letters", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            //Check if user has write permission to the output directory
            if (!HasWritePermissionOnOutputDirector(outputDirectory))
            {
                string msg = string.Concat("Cannot write to ", outputDirectory, ". Please change the output path under 'Tools --> Letter Settings' menu, ");
                msg = string.Concat(msg, "to a directory where this program will have write permission");
                MessageBox.Show(msg, "Batch Letters", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            return true;
        }

        /// <summary>
        /// Validates if user has write permissions to the output directory
        /// </summary>
        /// <param name="directory">Output file directory</param>
        /// <returns>True if user has write perissions to the output directory, otherwise False</returns>
        static bool HasWritePermissionOnOutputDirector(string directory)
        {
            try
            {
                if (!Directory.Exists(directory))
                { throw new DirectoryNotFoundException(string.Concat("Directory '", directory, "' doesnt not exist.")); }

                var accessControlList = Directory.GetAccessControl(directory);
                if (accessControlList == null) return false;

                var accessRules = accessControlList.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null) return false;

                var writeAllow = false;
                var writeDeny = false;

                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write) continue;

                    if (rule.AccessControlType.Equals(AccessControlType.Allow)) writeAllow = true;
                    else if (rule.AccessControlType.Equals(AccessControlType.Deny)) writeDeny = true;
                }

                return writeAllow && !writeDeny;
            }
            catch (UnauthorizedAccessException) { return false; }
        }


        private void btn_word_letter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option is not currently available", "Future report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            NS_ConfAdmin.StrongTypesNS.ds_lettersDataSet ds_letters = Proxy.ConferenceAdmin.produce_confirmation(txt_parentfolio.Text, "W", out feedback);
            if (feedback != "") MessageBox.Show(feedback, "Booking Letter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var templateDirectory = Properties.Settings.Default.LetterTemplateDirectory;
            var outputDirectory = Properties.Settings.Default.LetterOutputDirectory;

            string templateFile = string.Concat(templateDirectory, @"\UgLetterAdm.doc");
            if (!ValidTemplateFileAndWritePermission(templateFile, outputDirectory)) return;

            string labelsTemplate = string.Concat(templateDirectory, @"\Labels.doc");
            if (!ValidTemplateFileAndWritePermission(labelsTemplate, outputDirectory)) return;

            StreamWriter streamWriter = new StreamWriter(outputDirectory + @"\DataDoc.doc");


            string header = string.Empty;
            foreach (DataColumn dc in ds_letters.tt_confirm_letters.Columns)
            {
                header = string.IsNullOrEmpty(header) ? dc.ColumnName : string.Concat(header, "|", dc.ColumnName);
            }
            streamWriter.WriteLine(header);

            string data = string.Empty;
            foreach (DataRow dr in ds_letters.tt_confirm_letters.Rows)
            {
                data = string.Empty;
                foreach (DataColumn dc in ds_letters.tt_confirm_letters.Columns)
                {
                    data = string.IsNullOrEmpty(data) ? dr[dc].ToString() : string.Concat(data, "|", dr[dc]);
                }
                streamWriter.WriteLine(data);
            }
            streamWriter.Close();

            if (ds_letters.tt_confirm_letters.Rows.Count > 0)
            {
                string outputFile = string.Concat(outputDirectory, @"\DataDoc.doc");
                //MailMerge.PerformMailMerge(templateFile, outputFile);                
            }
            else
            {
                string msg = "There are no letters to be generated at this stage.";
                MessageBox.Show(msg, "Batch Letters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }
            
        #endregion

        #region transactions


        private void btn_trs_Click(object sender, EventArgs e)
        {
            if (txt_parentfolio.Text != string.Empty)
            {
                ConferenceSys.ConferenceAdmin.Group_Updates.Transactions frmTrans = new ConferenceSys.ConferenceAdmin.Group_Updates.Transactions(txt_parentfolio.Text);
                frmTrans.ShowDialog();
            }
        }

        private void update_transaction()
        {
            txt_amount.Text = "0";
            txt_receipt.Text = string.Empty;
            txt_narr.Text = string.Empty;
            txt_amount.Enabled = true;
            txt_narr.Enabled = true;

            sc_transactions.Panel1.Enabled = false;
            sc_transactions.Panel2Collapsed = false;

            TabIndex = Int32.Parse(tb_reservation.SelectedIndex.ToString());
            LeavePage = false;
            update_details = true;
            set_fields();
        }

        private void btn_add_charge_Click(object sender, EventArgs e)
        {
            w_option = 1;
            lbl_action.Text = "Add Additional Charge";

            update_transaction();
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            w_option = 3;
            lbl_action.Text = "Receipt";

            update_transaction();
        }

        private void btn_refund_Click(object sender, EventArgs e)
        {
            w_option = 5;
            lbl_action.Text = "Refund";

            update_transaction();
        }

        private void btn_write_off_Click(object sender, EventArgs e)
        {
            w_option = 7;
            lbl_action.Text = "Write Off Amount";

            update_transaction();
        }

        private void btn_reverse_charge_Click(object sender, EventArgs e)
        {
            if (dgv_transactions.SelectedRows.Count > 0)
            {
                if (dgv_transactions.SelectedRows[0].Cells[cn_tdescr.Name].Value.ToString() != "CR")
                {
                    string descrip = dgv_transactions.SelectedRows[0].Cells[cn_narr.Name].Value.ToString();
                    if (descrip.Contains("EXTRA CHARGE - "))
                    {
                        descrip = descrip.Replace("EXTRA CHARGE - ", "");
                        decimal tamount = decimal.Parse(dgv_transactions.SelectedRows[0].Cells[cn_tamount.Name].Value.ToString());
                        string receipt = dgv_transactions.SelectedRows[0].Cells[cn_trs_ref.Name].Value.ToString();
                        int link = int.Parse(dgv_transactions.SelectedRows[0].Cells[cn_trs_no.Name].Value.ToString());
                        string Narrative = "REVERSE CHARGES - " + descrip;
                        string msg = "Are you sure you want to reverse R" + tamount;
                        if (receipt != "") msg = msg + " Reference Number:" + receipt;

                        if (MessageBox.Show(msg + receipt, "Reverse Charge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            w_option = 2;
                            string feedback = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, tamount, receipt, Narrative, link);
                            if (feedback != string.Empty) MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else get_reservation();
                        }
                    }
                    else MessageBox.Show("You can only reverse 'Extra Charge' entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else MessageBox.Show("You can not reverse this entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else MessageBox.Show("Please select charge to reverse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            decimal tamount;
            string Narrative = "";
            if (!decimal.TryParse(txt_amount.Text.ToString(), out tamount))
            {
                MessageBox.Show("Please enter a correct amount", "Error Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tamount < 1)
            {
                MessageBox.Show("Can only enter positive amounts", "Error Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_narr.Text == string.Empty)
            {
                MessageBox.Show("You need to enter a Narrative", "Error Narrative", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (w_option == 1) Narrative = "EXTRA CHARGE - " + txt_narr.Text.ToString();
            if (w_option == 3)
            {
                if (txt_receipt.Text == string.Empty)
                {
                    MessageBox.Show("Please enter receipt number to continue!", "Error Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Narrative = "RECEIPT - " + txt_narr.Text.ToString();
            }
            if (w_option == 5) Narrative = "REFUND - " + txt_narr.Text.ToString();
            if (w_option == 7) Narrative = "WRITE OFF - " + txt_narr.Text.ToString();

            string feedback = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, tamount, txt_receipt.Text.ToString(), Narrative,0);
            if (feedback != string.Empty) MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                sc_transactions.Panel1.Enabled = true;
                sc_transactions.Panel2Collapsed = true;
                LeavePage = true;
                get_reservation();
                update_details = false;
                set_fields();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LeavePage = true;
            sc_transactions.Panel1.Enabled = true;
            sc_transactions.Panel2Collapsed = true;
            update_details = false;
            set_fields();
        }

        private void btn_reverse_receipt_Click(object sender, EventArgs e)
        {
            if (dgv_transactions.SelectedRows.Count > 0)
            {
                if (dgv_transactions.SelectedRows[0].Cells[cn_tdescr.Name].Value.ToString() == "CR")
                {
                    string descrip = dgv_transactions.SelectedRows[0].Cells[cn_narr.Name].Value.ToString();
                    if (descrip.StartsWith("RECEIPT -"))
                    {
                        descrip = descrip.Replace("RECEIPT -", "");
                        decimal tamount = decimal.Parse(dgv_transactions.SelectedRows[0].Cells[cn_tamount.Name].Value.ToString());
                        string receipt = dgv_transactions.SelectedRows[0].Cells[cn_trs_ref.Name].Value.ToString();
                        int link = int.Parse(dgv_transactions.SelectedRows[0].Cells[cn_trs_no.Name].Value.ToString());
                        string Narrative = "REVERSE RECEIPT - " + descrip;
                        string msg = "Are you sure you want to reverse R" + tamount;
                        if (receipt != "") msg = msg + " Reference Number:" + receipt;

                        if (MessageBox.Show(msg, "Reverse Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            w_option = 4;
                            string feedback = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, tamount, receipt, Narrative, link);
                            if (feedback != string.Empty) MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else get_reservation();
                        }
                    }
                    else MessageBox.Show("You can only reverse 'Receipt' entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else MessageBox.Show("You cannot reverse this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            }
            else MessageBox.Show("Please select Receipt to reverse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btn_reverse_refund_Click(object sender, EventArgs e)
        {
            if (dgv_transactions.SelectedRows.Count > 0)
            {
                if (dgv_transactions.SelectedRows[0].Cells[cn_tdescr.Name].Value.ToString() != "CR")
                {
                    string descrip = dgv_transactions.SelectedRows[0].Cells[cn_narr.Name].Value.ToString();
                    if (descrip.Contains("REFUND - "))
                    {
                        descrip = descrip.Replace("REFUND - ", "");
                        decimal tamount = decimal.Parse(dgv_transactions.SelectedRows[0].Cells[cn_tamount.Name].Value.ToString());
                        string receipt = dgv_transactions.SelectedRows[0].Cells[cn_trs_ref.Name].Value.ToString();
                        int link = int.Parse(dgv_transactions.SelectedRows[0].Cells[cn_trs_no.Name].Value.ToString());
                        string Narrative = "REVERSE REFUND - " + descrip;

                        string msg = "Are you sure you want to reverse R" + tamount;
                        if (receipt != "") msg = msg + " Reference Number:" + receipt;

                        if (MessageBox.Show(msg, "Reverse Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            w_option = 6;
                            string feedback = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, tamount, receipt, Narrative, link);
                            if (feedback != string.Empty) MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else get_reservation();
                        }
                    }
                    else MessageBox.Show("You can only reverse 'Refund' entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else MessageBox.Show("You can not reverse this entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            }
            else MessageBox.Show("Please select Refund to reverse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        #endregion

        

    }
}
