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
        bool UpdatePayments;

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
        bool allow_update = false;

        string BookingAddNew = string.Empty;
        bool MealAddNew;

        string feedback = "";

        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_rooms;
        NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet ds_reserv;
        NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet ds_booking;
        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_ccode;

        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_hall_list;

        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conference;

        public int w_option;

        public UpdateReserv(bool _AddNew, string _ConfCode, string _ParentFolio, string _folio, bool _UpdatePayments)
        {
            InitializeComponent();
            AddNew = _AddNew;
            ConfCode = _ConfCode;
            ParentFolio = _ParentFolio;
            Folio = _folio;
            UpdatePayments = _UpdatePayments;
        }

        #endregion        

        #region form_load

        private void UpdateReserv_Load(object sender, EventArgs e)
        {
            try
            {
                bool conf_admin = false;
                string feedback = string.Empty;
                
                ds_conference = Proxy.ConferenceAdmin.get_conference(false, ConfCode, out conf_admin, out feedback);
                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (UpdatePayments) sc_transactions.Enabled = true;


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
                toolTip1.SetToolTip(this.btn_word_letter, "Print Booking Confirmation Letter");
                toolTip1.SetToolTip(this.btn_email, "Email Confirmation to Group Leader");
                toolTip1.SetToolTip(this.btn_grp_report, "Group Report");
                toolTip1.SetToolTip(this.btn_fin_report, "Financial Report");

                btn_cancel_changes.Enabled = false;

                Dte_start.Value = DateTime.Today;
                dte_end.Value = DateTime.Today;

                dteBookStart.Value = DateTime.Today;
                dteBookEnd.Value = DateTime.Today;

                txt_guests.Text = "1";
               

                if (AddNew == true) update_details = true;
                else
                {
                    update_details = false;
                   // cb_type.Enabled = fals
                    //btnsearch.Enabled = false;
                    txt_titl.Enabled = false;
                    txt_name.Enabled = false;
                    txt_surn.Enabled = false;
                    txt_staff_stuno_other.Enabled = false;
                }

                SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {
                	{"Student", "S"},
	                {"Staff", "R"},
                    {"Other", "O"}
                };
                cb_type.DataSource = new BindingSource(userCache, null);
                cb_type.DisplayMember = "Key";
                cb_type.ValueMember = "Value";
                cb_type.SelectedIndex = 0;       
                
                ds_ccode = Proxy.ConferenceAdmin.get_conf_halls(ConfCode);

                SortedDictionary<string, string> userCache1 = new SortedDictionary<string, string>
                {
                	{"Breakfast", "B"},
	                {"Lunch", "L"},
                    {"Supper", "S"}
                };
                cb_meal.DataSource = new BindingSource(userCache1, null);
                cb_meal.DisplayMember = "Key";
                cb_meal.ValueMember = "Value";

                DataView DvHall = new DataView(ds_ccode.tt_ccode_hall);

                DvHall.Sort = "descrip";
                bsHall.DataSource = DvHall;
                if (DvHall.Count > 0) cbHall.SelectedIndex = 0;
                   
                /*
                  if (ds_ccode.tt_ccode_hall.Rows.Count > 0)
                    {

                        

                       

                        if (ds_reserv.tt_reservations[0].stuno != "" && ds_reserv.tt_reservations[0]["gender_specific"].ToString() == "True")
                        {
                            bool gender = ds_reserv.tt_reservations[0].gender;

                            ds_hall_list = new NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet();

                            for (int x = 0; x < ds_ccode.tt_ccode_hall.Count; x++)
                            {
                                string hall = ds_ccode.tt_ccode_hall[x].shall;
                                bool found = false;

                                for (int y = 0; y < ds_ccode.tt_ccode_res.Count; y++)
                                {
                                    string resHall = ds_ccode.tt_ccode_res[y].shall;
                                    bool resGender = ds_ccode.tt_ccode_res[y].gender;

                                    if (resHall == hall && resGender == gender)
                                    {
                                        DataRow newrow = ds_hall_list.tt_ccode_hall.NewRow();
                                        newrow["descrip"] = ds_ccode.tt_ccode_hall[x].descrip;
                                        newrow["shall"] = hall;
                                        ds_hall_list.tt_ccode_hall.Rows.Add(newrow);
                                        found = true;
                                    }

                                    if (found)
                                    {
                                        break;
                                    }

                                }
                            }

                            if(ds_hall_list.tt_ccode_hall.Count > 0)
                            {
                                DataView DV_Halls = new DataView(ds_hall_list.tt_ccode_hall);

                                DV_Halls.Sort = "descrip";
                                bsHall.DataSource = DV_Halls;
                                cbHall.SelectedIndex = 0;
                            }
                            else
                            {
                                string value = "";

                                if(gender)
                                {
                                    value = "Male";
                                }
                                else
                                {
                                    value = "Female";
                                }
                                MessageBox.Show("There Are No Halls For " + value + " Students To Book Into.", "Information", MessageBoxButtons.OK);
                            }
                        } 
                       // else
                      //  {
                        //    DataView DV_Halls = new DataView(ds_ccode.tt_ccode_hall);

                           
                            /*bool festHotelExist = false;
                            string conf = ConfCode.ToUpper();
                           
                            if (conf.Contains("NAF"))
                            {
                                for (int x = 0; x < ds_ccode.tt_ccode_hall.Count; x++)
                                {
                                    if (ds_ccode.tt_ccode_hall[x].festival_hotel == true)
                                    {
                                        festHotelExist = true;
                                    }
                                }


                                if (festHotelExist)
                                {
                                    DV_Halls.RowFilter = "festival_hotel = true";                                  
                                }
                            } 
                            
                            DV_Halls.Sort = "descrip";
                            if (cb_book_conf_type.SelectedIndex > -1 && cb_book_conf_type.Text.ToString().ToUpper().Contains("HOTEL"))
                            {
                                if (DV_Halls.RowFilter != "") DV_Halls.RowFilter =  DV_Halls.RowFilter + " and festival_hotel = true";
                                else DV_Halls.RowFilter = "festival_hotel = true";
                            }

                            bsHall.DataSource = DV_Halls;
                            cbHall.SelectedIndex = 0;
                            
                        } 

                        
                    } */

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

                    NS_System.StrongTypesNS.ds_genDataSet ds_paytypes = Proxy.System.Get_Gen("*", "R1");
                    bs_paytypes.DataSource = ds_paytypes.TT_GEN;

                    sc_bookings.Panel1.Enabled = true;
                    sc_bookings.Panel2Collapsed = true;

                    sc_meals.Panel1.Enabled = true;
                    sc_meals.Panel2Collapsed = true;

                    sc_transactions.Panel1.Enabled = true;
                    sc_transactions.Panel2Collapsed = true;

                    get_reservation();

                  

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

            bool gender = false;
            if (ds_ccode.tt_ccode_res.Rows.Count > 0)
            {
                DataView dvRes = new DataView(ds_ccode.tt_ccode_res);
                get_reservation();

                if (cbHall.SelectedIndex > -1) dvRes.RowFilter = "shall = '" + cbHall.SelectedValue.ToString() + "'";
                       
                if (ds_reserv.tt_reservations[0].stuno != "" && ds_reserv.tt_reservations[0].parentfolio == ParentFolio && ds_reserv.tt_reservations[0]["gender_specific"].ToString() == "True")
                {
                    gender = ds_reserv.tt_reservations[0].gender;

                    if (cbHall.Items.Count > 0 && cbHall.SelectedIndex >= 0)
                     {
                         dvRes.RowFilter = string.Format("shall = '{0}' and gender = '{1}'", cbHall.SelectedValue.ToString(), gender);
                       
                     }
                    
                }

                if (cb_book_conf_type.SelectedIndex > -1 && cb_book_conf_type.Text.ToString().ToUpper().Contains("HOTEL"))
                {

                    if (dvRes.RowFilter != "") dvRes.RowFilter = dvRes.RowFilter + " and festival_hotel = true";
                    else dvRes.RowFilter = "festival_hotel = true";

                }
                bsHouse.DataSource = dvRes;
                filter_buildings();
                   
            }
               
               
        }

        private void set_fields()
        {

           

            if (ds_reserv.tt_reservations[0].conf_admin == false || ds_reserv.tt_reservations[0].conf_locked == true || ds_reserv.tt_reservations[0]["xl_dte"].ToString() != string.Empty )
            allow_update = false;
            else allow_update = true;

           
            
            gb_updates.Enabled = pnl_details_update.Visible = pnl_meals.Visible = pnl_tranactions.Visible = pnl_booking_update.Visible = gb_reports.Enabled = allow_update;

            if (decimal.Parse(txt_funds_available.Text) > 0) btn_overpaid.Enabled = true;
            else btn_overpaid.Enabled = false;

            if (update_details == true)
            {
                pnl_header.Enabled = false;
                pnl_details.Enabled = true;
                pnl_booking.Enabled = true;

                /* Can only update the group details if on main reservation or new folio */
                if (ds_reserv.tt_reservations[0].folio.ToString() != ds_reserv.tt_reservations[0].parentfolio.ToString()) grp_info.Enabled = false;
                else grp_info.Enabled = true;

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
                btn_pay_override.Enabled = false;
            }

            /* New Booking, wait for information */
            if (txt_parentfolio.Text == string.Empty) gb_reports.Enabled = gb_updates.Enabled = false;

            if (ds_reserv.tt_reservations[0].request_override == false)
            {
                btn_pay_override.Text = "Request Override";
                if (ds_reserv.tt_reservations[0].parentfolio == ds_reserv.tt_reservations[0].folio) btn_pay_override.Enabled = true;
                else btn_pay_override.Enabled = false;
            }
            else
            {
                if (ds_reserv.tt_reservations[0].payment_override == true) btn_pay_override.Text = "Override Approved";
                else btn_pay_override.Text = "Override Requested";
                btn_pay_override.Enabled = false;
            }

            
        }

        #endregion

        #region reservation details

        private void cb_reservation_lookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_reservation_lookup.Enabled == true)
            {
                Folio = cb_reservation_lookup.SelectedValue.ToString();
            
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
                ConferenceSys.Reports frmReport = new ConferenceSys.Reports("ReservationReport", ds_report);
                frmReport.Show();
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
                    if (ParentFolio == "0") pnl_guests.Visible = true;
                    else pnl_guests.Visible = false;

                    if (ds_reserv.tt_reservations[0].total_cost > 0)
                    {
                        txt_bal_folio.Text = ds_reserv.tt_reservations[0].total_cost.ToString();
                        txt_funds_available.Text = ds_reserv.tt_reservations[0].total_cost.ToString();
                    }
                    if (ds_reserv.tt_reservations[0].folio_total > 0)
                    {
                        txt_bal_folio.Text = ds_reserv.tt_reservations[0].folio_total.ToString();
                    }
                    if (ds_reserv.tt_reservations[0].total_cost < 0 && txt_funds_available.Text.Length <= 0)
                    {
                        txt_funds_available.Text = (ds_reserv.tt_reservations[0].total_cost * -1).ToString();
                    }
                    if (ds_reserv.tt_reservations[0].total_cost == 0 && txt_funds_available.Text.Length <= 0)
                    {
                        txt_funds_available.Text = "0";                      
                    }

                    if (ds_reserv.tt_reservations[0].total_cost == 0 && txt_bal_folio.Text.Length <= 0)
                    {
                       txt_bal_folio.Text = "0";
                    }

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

                    object start_dte = ds_reserv.tt_reservations[0]["start_dte"];
                    object end_dte = ds_reserv.tt_reservations[0]["end_dte"];

                    if (start_dte != DBNull.Value && end_dte != DBNull.Value)
                    {
                        if (DateTime.Parse(ds_reserv.tt_reservations[0].start_dte.ToString()) < DateTime.Parse(ds_conference.tt_conference[0]["start_dte"].ToString()))
                        {
                            Dte_start.MinDate = dte_end.MinDate = DateTime.Parse(ds_reserv.tt_reservations[0].start_dte.ToString());
                        }
                        else Dte_start.MinDate = dte_end.MinDate = DateTime.Parse(ds_conference.tt_conference[0]["start_dte"].ToString());

                        if (DateTime.Parse(ds_reserv.tt_reservations[0].end_dte.ToString()) > DateTime.Parse(ds_conference.tt_conference[0]["end_dte"].ToString()))
                        {
                            Dte_start.MaxDate = dte_end.MaxDate = DateTime.Parse(ds_reserv.tt_reservations[0].end_dte.ToString());
                        }
                        else Dte_start.MaxDate = dte_end.MaxDate = dteBookStart.MaxDate = dteBookEnd.MaxDate = DateTime.Parse(ds_conference.tt_conference[0]["end_dte"].ToString());
                    }
                    else MessageBox.Show("Please set a start date and an end date for this reservation", "Missing Reservation Dates", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    

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

            if (cb_type.SelectedValue.ToString() != "O" && txt_staff_stuno_other.Text.Trim().Length == 0)
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

            if (txt_discount.Text != string.Empty)
            {
                if (Decimal.Parse(txt_discount.Text.ToString()) < 0 | Decimal.Parse(txt_discount.Text.ToString()) > 100)
                {
                    valid = false;
                    errorProvider.SetError(txt_discount, "Discount should be between 0 and 100 percent");
                }
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

            return valid;
        }
              
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btn_save_details.Text == "Save Details")
                {
                    if (Dte_start.Text == "" | dte_end.Text == "")
                    {
                        MessageBox.Show("Error - Please enter reservation dates to continue", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (DateTime.Parse(Dte_start.Text) > DateTime.Parse(dte_end.Text))
                    {
                        MessageBox.Show("Error - Start date cannot be after end date", "Error Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    if (cb_type.SelectedIndex == -1) MessageBox.Show("Please select Guest Type to continue", "Guest Type", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    else
                    {
                        errorProvider.Clear();
                        if (ValidDetailsForReservation())
                        {
                            string NewParent = "";
                            string NewFolio = "";

                           // ds_reserv.tt_reservations[0].type = cb_type.SelectedValue.ToString();

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

                if (cb_type.SelectedValue.ToString() == "S")
                {
                    Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(true);
                    frmStuSearch.ShowDialog();
                    if (frmStuSearch.Stuno != "")
                    {
                        txt_staff_stuno_other.Text = frmStuSearch.Stuno;
                        Load_Person();
                    }

                }
                if (cb_type.SelectedValue.ToString() == "R")
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
                string surname = Proxy.System.get_personal_details(cb_type.SelectedValue.ToString(), txt_staff_stuno_other.Text, out name1, out email, out contact_no, out title, out gender);
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
                ds_rooms = Proxy.ConferenceAdmin.check_available_rooms(ds_reserv.tt_reservations[0].folio.ToString(), cbBuilding.SelectedValue.ToString(), DateTime.Parse(dteBookStart.Text), DateTime.Parse(dteBookEnd.Text), chk_find_double.Checked, false /* will be set correctly based on reservation in .p */, out ownroom, out otherfolio, out doubles_only);
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
            prevstart = Convert.ToDateTime(null);
            prevend = Convert.ToDateTime(null); 

            BookingAddNew = "N";
            booktrs = 0;
            if (cbHall.Items.Count > 0) cbHall.SelectedIndex = 0;
            else cbHall.SelectedIndex = -1;

            dteBookStart.MinDate = dteBookEnd.MinDate = DateTime.Parse(ds_conference.tt_conference[0]["start_dte"].ToString());
            dteBookStart.MaxDate = dteBookEnd.MaxDate = DateTime.Parse(ds_conference.tt_conference[0]["end_dte"].ToString());
         
            string feedback = Proxy.ConferenceAdmin.get_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, 0, out ds_booking);
            if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                booking_update_screen_refresh();
                //FilterResidence();

            
               
                TabIndex = Int32.Parse(tb_reservation.SelectedIndex.ToString());
                lbl_rooms.Text = "Available Rooms:";
                cbRooms.Visible = true;
                txt_booked_room.Visible = false;

                if (ds_reserv.tt_reservations[0].double_booking == false) cb_double_rooms.Enabled = false;
                else cb_double_rooms.Enabled = true;

                if (ds_reserv.tt_reservations[0].stairs == false) lbl_info.Visible = lbl_mobility.Visible = false;
                else
                {
                    lbl_info.Visible = lbl_mobility.Visible = true;
                    lbl_mobility.Text = ds_reserv.tt_reservations[0].mobility;
                }

              
                LeavePage = false;
                update_details = true;
                set_fields();
            }
        }

        private void cbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHouse.SelectedIndex > -1)
            {  filter_buildings(); }
        }

        private void filter_buildings()
        {

            if (ds_ccode.tt_ccode_build.Rows.Count > 0)
            {

                bsBuilding.DataSource = null;

                if (cbHouse.SelectedIndex > -1)
                {
                    
                    DataView dvBuilding = new DataView(ds_ccode.tt_ccode_build);

                    dvBuilding.RowFilter = "res = '" + cbHouse.SelectedValue.ToString() + "'";

                    if (ds_reserv.tt_reservations[0]["gender_specific"].ToString() == "True")
                    {
                        if (cbHouse.SelectedIndex >= 0 && cbHouse.Items.Count > 0)
                        {
                            dvBuilding.RowFilter = string.Format("res = '{0}' and gender = '{1}'", cbHouse.SelectedValue.ToString(), ds_reserv.tt_reservations[0]["gender"].ToString());
                        }
                    }

                    if (cb_book_conf_type.SelectedIndex > -1 && cb_book_conf_type.Text.ToString().ToUpper().Contains("HOTEL"))
                    {
                        if (dvBuilding.RowFilter != "") dvBuilding.RowFilter = dvBuilding.RowFilter + " and festival_hotel = true";
                        else dvBuilding.RowFilter = dvBuilding.RowFilter + "festival_hotel = true";
                    }
                    bsBuilding.DataSource = dvBuilding;
                }
                

              /*  else
                {
                    if (cbHouse.SelectedIndex >= 0 && cbHouse.Items.Count > 0)
                    {
                        bool festHotelExist = false;
                        string conf = ConfCode.ToUpper();

                        if (conf.Contains("NAF"))
                        {
                            for (int x = 0; x < ds_ccode.tt_ccode_build.Count; x++)
                            {
                                if (ds_ccode.tt_ccode_build[x].festival_hotel == true)
                                {
                                    festHotelExist = true;
                                    break;
                                }
                            }


                            if (festHotelExist)
                            {                                
                                dvBuilding.RowFilter = string.Format("res = '{0}' and festival_hotel = '{1}'", cbHouse.SelectedValue.ToString(), true);
                                bsBuilding.DataSource = dvBuilding;
                            }
                        }
                        else
                        { 
                            dvBuilding.RowFilter = string.Format("res = '{0}'", cbHouse.SelectedValue.ToString());
                            bsBuilding.DataSource = dvBuilding;
                        }
                       
                    }
                }*/
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
                string feedback = "";
                bool okProceed = false;

                feedback = Proxy.ConferenceAdmin.check_booking(ds_reserv.tt_reservations[0].parentfolio, cbBuilding.SelectedValue.ToString());

                if (feedback == "") okProceed = true;
                else if (MessageBox.Show(feedback, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)okProceed = true;


                if (okProceed)
                {

                    if (txt_booked_room.Visible == false) room_num = cbRooms.SelectedValue.ToString();
                    if (BookingAddNew == "N" && DateTime.Parse(dteBookStart.Text) < DateTime.Today.AddDays(2))
                    {
                        if (MessageBox.Show("The start date of this booking request is either in the past or within the next 2 days. As a result you will not be able to modify the start date once the booking has been made. Are you sure you want to proceed with this booking?", "Confrimation of Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    }

                    TimeSpan span = DateTime.Parse(dteBookEnd.Text) - DateTime.Parse(dteBookStart.Text);
                    if (span.TotalDays >= 14)
                    {
                        if (MessageBox.Show("This booking is longer than 2 weeks. Are you sure you want to continue with the booking request?", "Confirmation of Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    }


                    if (BookingAddNew == "E" & prevend != DateTime.Parse(dteBookEnd.Text) & DateTime.Parse(dteBookEnd.Text) < prevend)
                    {
                        if (DateTime.Parse(dteBookEnd.Text) < DateTime.Today)
                        {
                            MessageBox.Show("Error - You cannot change end date to a day earlier than today", "Error Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (DateTime.Parse(dteBookEnd.Text) == DateTime.Today) if (MessageBox.Show("Note: The guest will be charged a cancellation fee for two days. Are you sure you want to proceed?", "Changed Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                        if (DateTime.Parse(dteBookEnd.Text) == DateTime.Today.AddDays(1)) if (MessageBox.Show("Note: The guest will be charged a cancellation fee for one day. Are you sure you want to proceed?", "Changed Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    }

                    feedback = Proxy.ConferenceAdmin.update_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, ref booktrs, Int32.Parse(cbHouse.SelectedValue.ToString()), cbBuilding.SelectedValue.ToString(), room_num, Int32.Parse(txt_mattress.Text), DateTime.Parse(dteBookStart.Text), DateTime.Parse(dteBookEnd.Text), cb_double_rooms.Checked, cb_book_conf_type.SelectedValue.ToString());
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
        }

        private void booking_update_screen_refresh()
        {
            dteBookStart.Enabled = dteBookEnd.Enabled = cbHall.Enabled = cbHouse.Enabled = cbBuilding.Enabled = txt_booked_room.Enabled = cbRooms.Enabled = true;
            btn_chk_available.Enabled = btn_save.Enabled = btn_cancel_bookings.Enabled = txt_mattress.Enabled = cb_double_rooms.Enabled = pnl_rooms.Enabled = true;
            btn_change_room.Enabled = false;
            sc_bookings.Panel1.Enabled = false;
            sc_bookings.Panel2Collapsed = false;
            bs_book_update.DataSource = ds_booking.tt_bookings;
        }

        private void dg_bookings_DoubleClick(object sender, EventArgs e)
        {
            if (dg_bookings.SelectedRows.Count > 0 && allow_update)
            {
                BookingAddNew = "E";
                booktrs = Int32.Parse(dg_bookings.SelectedRows[0].Cells[cn_booking_ref.Name].Value.ToString());

                /* Reset Date Time Picker Min/Max Dates */
                dteBookStart.MinDate = dteBookEnd.MinDate = DateTimePicker.MinimumDateTime;
                dteBookStart.MaxDate = dteBookEnd.MaxDate = DateTimePicker.MaximumDateTime;
                 
                string feedback = Proxy.ConferenceAdmin.get_a_booking(BookingAddNew, ds_reserv.tt_reservations[0].folio, booktrs, out ds_booking);                
                if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    booking_update_screen_refresh();

                    prevstart = DateTime.Parse(ds_booking.tt_bookings[0]["start_dte"].ToString());
                    prevend = DateTime.Parse(ds_booking.tt_bookings[0]["end_dte"].ToString());

                    if (prevstart <= DateTime.Parse(ds_conference.tt_conference[0]["start_dte"].ToString())) dteBookStart.MinDate = dteBookEnd.MinDate = prevstart;
                    else dteBookStart.MinDate = dteBookEnd.MinDate = DateTime.Parse(ds_conference.tt_conference[0]["start_dte"].ToString());

                    if (prevend >= DateTime.Parse(ds_conference.tt_conference[0]["end_dte"].ToString())) dteBookStart.MaxDate = dteBookEnd.MaxDate = prevend;
                    else dteBookStart.MaxDate = dteBookEnd.MaxDate = DateTime.Parse(ds_conference.tt_conference[0]["end_dte"].ToString());

                    if (ds_reserv.tt_reservations[0].stairs == false) lbl_info.Visible = lbl_mobility.Visible = false;                    
                    else
                    {
                        lbl_info.Visible = lbl_mobility.Visible = true;   
                        lbl_mobility.Text = ds_reserv.tt_reservations[0].mobility;
                    }

                    lbl_rooms.Text = "Booked Room:";
                    cbRooms.Visible = false;
                    txt_booked_room.Visible = true;

                    /* Cannot make any changes since booking is in the past */
                    if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_end_dte.Name].Value.ToString()) <= DateTime.Today)
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
                        chk_find_double.Enabled = false;
                    }

                    /* Cannot change the Start Date since it is in the past */
                    else if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_start_dte.Name].Value.ToString()) < DateTime.Today)
                    {
                        dteBookStart.Enabled = false;
                        dteBookEnd.MinDate = DateTime.Today.AddDays(2);
                        cb_double_rooms.Enabled = false;
                    }

                    /* Otherwise set min dates on both date fields */
                    else
                    {
                        if (dteBookStart.MinDate <= DateTime.Today) dteBookStart.MinDate = dteBookEnd.MinDate = DateTime.Today;
                        //dteBookStart.MinDate = DateTime.Today;
                        //dteBookEnd.MinDate = DateTime.Today;
                    }

                    /* If we are within the booking period, then we can only offer to change the room */
                    if (dteBookStart.Enabled == false)
                    {
                        pnl_rooms.Enabled = false;
                        btn_change_room.Enabled = true;
                    }
                    else
                    {
                        pnl_rooms.Enabled = true;
                        btn_change_room.Enabled = false;
                    }
                    

                    /* Double Booking Set */
                    if (DateTime.Parse(dg_bookings.SelectedRows[0].Cells[cn_book_start_dte.Name].Value.ToString()) > DateTime.Today)
                    {
                        if (ds_reserv.tt_reservations[0].double_booking == true) cb_double_rooms.Enabled = true;
                        else cb_double_rooms.Enabled = false;
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
                
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_bookings.SelectedRows.Count > 0)
                {
                    
                    if (MessageBox.Show("Are you sure you want to cancel this booking?", "Cancel Booking ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string folio = ds_reserv.tt_reservations[0].folio.ToString();
                        int booktrs = Int32.Parse(dg_bookings.SelectedRows[0].Cells[cn_booking_ref.Name].Value.ToString());
                        string hallcode = dg_bookings.SelectedRows[0].Cells[cn_booking_hall_code.Name].Value.ToString();
                        string feedback = Proxy.ConferenceAdmin.delete_booking(folio, booktrs, hallcode);
                        MessageBox.Show(feedback, "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!feedback.Contains("Error")) get_reservation();
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
            if (!Utilities.AccessControl.HasOverrideDates)
            {
                dte_mdate.Value = DateTime.Today.AddDays(2);
                dte_mdate.MinDate = DateTime.Today.AddDays(2);
            }
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

        private void btn_x_meal_Click(object sender, EventArgs e)
        {
            
            bool selected = false;
            foreach (DataGridViewRow row in dgvMeals.Rows)
            {
                if (row.Cells[ckCancel.Name].Value != null && (bool)row.Cells[ckCancel.Name].Value)
                {
                    selected = true; break;
                }
            }
            if (!selected) MessageBox.Show("There are no selected meals to cancel", "Cancel Meal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are you sure you want to cancel selected meal(s)?", "Cancel Meals", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NS_Conference.StrongTypesNS.ds_mealsDataSet meal_list = new ds_mealsDataSet();
                    foreach (DataGridViewRow row in dgvMeals.Rows)
                    {
                        if (row.Cells[ckCancel.Name].Value != null && (bool)row.Cells[ckCancel.Name].Value)
                        {
                            temp_dte = DateTime.Parse(row.Cells[cmdate.Name].Value.ToString());
                            temp_refno = txt_folio.Text.ToString();
                            temp_mealtime = row.Cells[cMEAL_TIME.Name].Value.ToString(); 
                            temp_mealcount = int.Parse(row.Cells[cmcnt.Name].Value.ToString());

                            DataRow newrow =  meal_list.TT_MEALS.NewRow();
                            newrow["MDATE"] = temp_dte;
                            newrow["MCNT"] = temp_mealcount;
                            newrow["MEAL_TIME"] = temp_mealtime;
                            newrow["REF_NO"] = temp_refno;
                            meal_list.TT_MEALS.Rows.Add(newrow);
                        }
                    }
                    string feedback = Proxy.ConferenceSystem.cancel_selected_meals(meal_list);
                    MessageBox.Show(feedback, "Cancel Selected Meals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    get_reservation();


                }                
            }
            
        }

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
                    get_reservation();
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
            get_reservation();
        }

        private void dgvMeals_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0 && allow_update)
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
                    cb_meal.SelectedValue = dgvMeals.SelectedRows[0].Cells[cMEAL_TIME.Name].Value.ToString();
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
                    temp_mealtime = cb_meal.SelectedValue.ToString();
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
                        btn_xl_all.Visible = true;
                        LeavePage = true;
                        update_details = false;
                        get_reservation();
                        set_fields();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btn_taken_Click(object sender, EventArgs e)
        {
            bool selected = false;
            foreach (DataGridViewRow row in dgvMeals.Rows)
            {
                if (row.Cells[ckCancel.Name].Value != null && (bool)row.Cells[ckCancel.Name].Value)
                {
                    selected = true; break;
                }
            }
            if (!selected) MessageBox.Show("There are no selected meals to mark as Taken", "Take Meals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are you sure you want to mark selected meal(s) as Taken?", "Take Meals", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NS_Conference.StrongTypesNS.ds_mealsDataSet meal_list = new ds_mealsDataSet();
                    foreach (DataGridViewRow row in dgvMeals.Rows)
                    {
                        if (row.Cells[ckCancel.Name].Value != null && (bool)row.Cells[ckCancel.Name].Value)
                        {
                            temp_dte = DateTime.Parse(row.Cells[cmdate.Name].Value.ToString());
                            temp_refno = txt_folio.Text.ToString();
                            temp_mealtime = row.Cells[cMEAL_TIME.Name].Value.ToString();
                            temp_mealcount = int.Parse(row.Cells[cmcnt.Name].Value.ToString());

                            DataRow newrow = meal_list.TT_MEALS.NewRow();
                            newrow["MDATE"] = temp_dte;
                            newrow["MCNT"] = temp_mealcount;
                            newrow["MEAL_TIME"] = temp_mealtime;
                            newrow["REF_NO"] = temp_refno;
                            meal_list.TT_MEALS.Rows.Add(newrow);
                        }
                    }
                    string feedback = Proxy.ConferenceSystem.take_selected_meals(meal_list);
                    MessageBox.Show(feedback, "Take Selected Meals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    get_reservation();


                }
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

            bool IsNAF = false;
            string conf = ConfCode.ToUpper();
            if (conf.Contains("NAF")) IsNAF = true;

            feedback = Proxy.ConferenceAdmin.produce_confirmation_email(IsNAF,txt_parentfolio.Text);
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
                    string feedback = Proxy.ConferenceAdmin.cancel_reservations(false,ds_reserv.tt_reservations[0].parentfolio,"");
                    MessageBox.Show(feedback, "Cancel Resevations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!feedback.ToUpper().StartsWith("ERROR")) this.Close();
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
                string conf_descrip = "Conference = " + txtConference.Text;
                bool print_zeros = true;

                NS_Conference.StrongTypesNS.ds_financialDataSet ds_financial = Proxy.ConferenceSystem.financial_report(ds_reserv.tt_reservations[0].ccode, "*", parentfolio, "*", print_zeros, out feedback);
                if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ds_financial.BOOKFILE1.Rows.Count < 1) MessageBox.Show("Your query returned no data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            DataView dv_data = new DataView(ds_financial.BOOKFILE1);
                            //dv_data.Sort = "REF,FOLIO";

                            DataTable dt1 = dv_data.ToTable() ;
                            DataTable dt2 = ds_financial.MONEYFILE;

                            oSheet.Cells[1, 1] = "Financial Report";
                            oSheet.Cells[1, 3] = conf_descrip;
                            oSheet.Cells[2, 3] = "Main Folio: " + parentfolio.ToString();

                            int rowCount = 0;
                           
                            oSheet.Cells[3, 1] = "FOLIO";
                            oSheet.Cells[3, 2] = "NAME";
                            oSheet.Cells[3, 3] = "BUILDING";
                            oSheet.Cells[3, 4] = "ROOM";
                            oSheet.Cells[3, 5] = "START DATE";
                            oSheet.Cells[3, 6] = "END DATE";
                            oSheet.Cells[3, 7] = "RATE";
                            oSheet.Cells[3, 8] = "Cancelled";
                            oSheet.Cells[3, 9] = "Totals";
                            oSheet.Cells[3, 10] = "Extra Meals";
                            oSheet.Cells[3, 11] = "B";
                            oSheet.Cells[3, 12] = "L";
                            oSheet.Cells[3, 13] = "S";
                            oSheet.Cells[3, 14] = "Charges";
                            oSheet.Cells[3, 15] = "PD/ADJ";
                            oSheet.Cells[3, 16] = "Write Off";
                            oSheet.Cells[3, 17] = "Refund";
                            oSheet.Cells[3, 18] = "Balance";

                            rowCount = 3;
                            
                            int ColCount = 0;
                                
                            foreach (DataRow dr in dt1.Rows)
                            {
                                if (dr[0].ToString() == dr[15].ToString() && dr[3].ToString() == "Main")
                                {
                                    if (rowCount > 3) rowCount += 2;
                                    rowCount += 1;
                                    for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                    {
                                        if (i == 1 | i == 2 | i == 8 | i == 9 | i == 20 | i == 21 | i == 22 | i == 23 | i == 25)
                                        {
                                            ColCount = i;
                                            if (i == 25) ColCount = 14;
                                            if (i == 20) ColCount = 15;
                                            if (i == 21) ColCount = 16;
                                            if (i == 22) ColCount = 17;
                                            if (i == 23) ColCount = 18;                                            
                                            oSheet.Cells[rowCount, ColCount] = dr[i - 1].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    rowCount += 1;
                                    for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                    {
                                        if (dr[3].ToString() != "CNFTRS")
                                        {
                                            ColCount = i;
                                            if (i == 9) ColCount = 14;
                                            if (i == 14) break;

                                            oSheet.Cells[rowCount, i] = dr[ColCount - 1].ToString();
                                        }

                                        if (dr[3].ToString() == "CNFTRS")
                                        {
                                            if (i == 1 | i == 2 | i == 20 | i == 21 | i == 22 | i == 25)
                                                {
                                                ColCount = i;
                                                if (i == 25) ColCount = 14;
                                                if (i == 20) ColCount = 15;
                                                if (i == 21) ColCount = 16;
                                                if (i == 22) ColCount = 17;
                                                oSheet.Cells[rowCount, ColCount] = dr[i - 1].ToString();
                                                    
                                            }
                                        }

                                    }
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

        #region print_letter


        private void btn_word_letter_Click(object sender, EventArgs e)
        {
          
            string feedback = string.Empty;
            string headerline = string.Empty;
            bool IsNAF = false;
            string conf = ConfCode.ToUpper();
            if (conf.Contains("NAF")) IsNAF = true;

            NS_ConfAdmin.StrongTypesNS.ds_lettersDataSet ds_letters = Proxy.ConferenceAdmin.print_confirmation_letter(IsNAF,txt_parentfolio.Text, out feedback,out headerline);
            if (feedback != "") MessageBox.Show(feedback, "Confirmation Letter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataView dvData = new DataView(ds_letters.tt_book_list);
                ConferenceSys.Reports frmReport  = new ConferenceSys.Reports(IsNAF,"ConfirmationLetter", dvData, headerline);
                frmReport.Show();
            }
            
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
            txt_receipt.Enabled = true;
            txt_amount.Enabled = true;
            txt_narr.Enabled = true;

            if (w_option == 1 | w_option == 5 | w_option == 7) { txt_receipt.Enabled = false; cb_paytype.SelectedIndex = -1; cb_paytype.Enabled = false; }
            if (w_option == 3) { txt_narr.Enabled = false; cb_paytype.SelectedIndex = 0; cb_paytype.Enabled = true; }

            sc_transactions.Panel1.Enabled = false;
            sc_transactions.Panel2Collapsed = false;
            txt_amount.Focus();

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
            decimal tamount = 0;
            string Narrative = "";
            int receipt_no;
            string tempreceipt = string.Empty;


            if (txt_amount.Text != string.Empty)
            {
                if (!decimal.TryParse(txt_amount.Text.ToString(), out tamount))
                {
                    MessageBox.Show("Please enter a correct amount", "Error Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (tamount < 1)
            {
                MessageBox.Show("Can only enter positive amounts", "Error Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (w_option != 3)
            {
                if (txt_narr.Text == string.Empty)
                {
                    MessageBox.Show("You need to enter a Narrative", "Error Narrative", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (w_option == 1) Narrative = "EXTRA CHARGE - " + txt_narr.Text.ToString();
            if (w_option == 3)
            {
                if (cb_paytype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select payment type to continue!", "Error Pay Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (txt_receipt.Text == string.Empty)
                {
                    MessageBox.Show("Please enter receipt or student number to continue!", "Error Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cb_paytype.SelectedValue.ToString() != "SA" &&  !int.TryParse(txt_receipt.Text.ToString(), out receipt_no))
                {
                     if (MessageBox.Show("Normally only integers are used as a reference. Are you sure you want to save this reference with characters in them? ", 
                     "Receipt Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                     {
                         txt_receipt.Text = string.Empty; return;
                     }
                }

                tempreceipt = cb_paytype.SelectedValue.ToString() + txt_receipt.Text.ToString().Replace(" ", "");

                string feedback = Proxy.ConferenceAdmin.check_valid_receipt(tempreceipt, tamount);

                if (feedback != string.Empty)
                {
                    if (feedback.Contains("Error"))
                    {
                        MessageBox.Show(feedback, "Error Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (MessageBox.Show(feedback, "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                }
                Narrative = "RECEIPT - " + tempreceipt;

            }
            if (w_option == 5) Narrative = "REFUND - " + txt_narr.Text.ToString();
            if (w_option == 7) Narrative = "WRITE OFF - " + txt_narr.Text.ToString();

            string feedback2 = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, tamount, tempreceipt, Narrative, 0);
            if (feedback2 != string.Empty) MessageBox.Show(feedback2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cb_double_rooms_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_double_rooms.Checked)
            {
                chk_find_double.Checked = true;
                chk_find_double.Enabled = false;
            }
            else
            {
                chk_find_double.Checked = false;
                chk_find_double.Enabled = true;
            }


        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex != -1)
            {
                txt_titl.Text = txt_name.Text = txt_surn.Text = txt_staff_stuno_other.Text = string.Empty;

                txt_staff_stuno_other.Visible = btnsearch.Visible = true;
                if (cb_type.SelectedValue.ToString() == "S" | cb_type.SelectedValue.ToString() == "R")
                {
                    txt_titl.Enabled = txt_name.Enabled = txt_surn.Enabled = txt_staff_stuno_other.Enabled = rb_male.Enabled = rb_female.Enabled = false;
                    txt_staff_stuno_other.Visible = btnsearch.Visible = true;
                    if (cb_type.SelectedValue.ToString() == "R") rb_male.Enabled = rb_female.Enabled = true;
                }
                else
                {
                    txt_titl.Enabled = txt_name.Enabled = txt_surn.Enabled = rb_male.Enabled = rb_female.Enabled = true;
                    txt_staff_stuno_other.Visible = btnsearch.Visible = false;
                }
            }
        }

        private void cb_mhall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_pay_override_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to request payment override for this reservation?", "Request Override", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string feedback = Proxy.ConferenceAdmin.request_payment_override(ParentFolio);
                if (feedback.Contains("Error")) MessageBox.Show(feedback, "Error Override", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(feedback, "Payment Override", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    get_reservation();
                }
            }
        }

        private void chk_stairs_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_stairs.Checked) pnl_mobility.Visible = true;
            else
            {
                pnl_mobility.Visible = false;
                txt_mobility.Text = string.Empty;
            }
        }

     

        private void btn_overpaid_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to write off R " + txt_funds_available.Text + " as an overpayment.", "Overpayment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                w_option = 8;
                string feedback = Proxy.ConferenceAdmin.update_transactions(w_option, ParentFolio, decimal.Parse(txt_funds_available.Text) * -1, "", "EXTRA CHARGE - Over Payment", 0);
                if (feedback != string.Empty) MessageBox.Show(feedback, "Over Payment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else{
                    get_reservation();
                    btn_overpaid.Enabled = false;
                }
            }
        }

        private void btn_change_room_Click(object sender, EventArgs e)
        {
            dteBookEnd.Enabled = false; /* Change room is for the duration of the booking request */
            dteBookStart.Enabled = true; /* Might want to change room from tomorrow, etc */
            dteBookStart.MinDate = DateTime.Parse(dteBookStart.Value.ToString());
            dteBookStart.MaxDate = DateTime.Parse(dteBookEnd.Value.ToString());
            cb_book_conf_type.Enabled = false;
            txt_mattress.Enabled = false;
            pnl_rooms.Enabled = true;
            cbHall.Enabled = cbHouse.Enabled = cbBuilding.Enabled = chk_find_double.Enabled = cbRooms.Enabled = btn_chk_available.Enabled = btn_save.Enabled = true;
            BookingAddNew = "C";
            btn_change_room.Enabled = false;
        }


        private void dgv_transactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_transactions.SelectedRows.Count > 0 && allow_update)
            {
                if (dgv_transactions.SelectedRows[0].Cells[cn_multi_payment.Name].Value.ToString() != "0")
                {
                    ConferenceSys.ConferenceAdmin.Conference_Updates.Capture_Reciept frmReciept = new ConferenceAdmin.Conference_Updates.Capture_Reciept(dgv_transactions.SelectedRows[0].Cells[cn_trs_ref.Name].Value.ToString(),Int32.Parse(dgv_transactions.SelectedRows[0].Cells[cn_multi_payment.Name].Value.ToString()));
                    frmReciept.ShowDialog();
                }
            }
        }

        private void cb_paytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_paytype.SelectedIndex > -1)
            {
                if (cb_paytype.SelectedValue.ToString() == "SA")
                {
                    btn_search_stu.Enabled = true; txt_receipt.Enabled = false;

                    if (cb_type.SelectedValue.ToString() == "S" && txt_staff_stuno_other.Text.ToString() != string.Empty)
                    {
                        txt_receipt.Text = txt_staff_stuno_other.Text;
                    }
                }
                else { btn_search_stu.Enabled = false; txt_receipt.Enabled = true; }
            }
        }

        private void btn_search_stu_Click(object sender, EventArgs e)
        {
            Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(true);
            frmStuSearch.ShowDialog();
            if (frmStuSearch.Stuno != "")  txt_receipt.Text = frmStuSearch.Stuno;
        }

        private void cb_book_conf_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_book_conf_type.SelectedIndex > -1) FilterResidence();
        }

     
    }
}
