﻿using System;
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
    public partial class MealProcessing : Form
    {
        string ConferenceCode;
        string ParentFolio;
        string WhichOne;

        DateTime Arrival;
        DateTime Departure;


        public MealProcessing(string _which_onew, string _ConferenceCode,string _ParentFolio, DateTime _Arrival, DateTime _Departure)
        {
            InitializeComponent();
            ConferenceCode = _ConferenceCode;
            ParentFolio = _ParentFolio;
            WhichOne = _which_onew;
            Arrival = _Arrival;
            Departure = _Departure;

        }
      
        private void MealProcessing_Load(object sender, EventArgs e)
        {

            dte_start_date.Value = Arrival;
            dte_end_date.Value = Departure;
            dte_start_date.MinDate = Arrival;
            dte_end_date.MinDate = Arrival;

            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
            {
	            {"Book Meals", "B"},
	            {"Cancel Meals", "X"},
                {"Uncancel Meals", "R"},
                {"Change Dining Hall", "H"},
                {"Packed Meals", "P"},
                {"Undo Packed Meals", "U"},
                {"Change Diets", "D"}
            };
            cb_action.DataSource = new BindingSource(userCache, null);
            cb_action.DisplayMember = "Key";
            cb_action.ValueMember = "Value";
            cb_action.SelectedIndex = 0;

            DataView DV_MHalls = new DataView(Global.Global.ds_conf_codes.tt_dhall);
            DV_MHalls.Sort = "detail";
            cb_dhall.DataSource = DV_MHalls;
            cb_dhall.DisplayMember = "detail";
            cb_dhall.ValueMember = "dhall";
            cb_dhall.SelectedIndex = 0;


            SortedDictionary<string, string> userCache1 = new SortedDictionary<string, string>
            {
	            {"Breakfast", "B"},
	            {"Lunch", "L"},
                {"Supper", "S"}
            };
            cb_start_meal.DataSource = new BindingSource(userCache1, null);
            cb_start_meal.DisplayMember = "Key";
            cb_start_meal.ValueMember = "Value";
            cb_start_meal.SelectedIndex = 0;

            cb_end_meal.DataSource = new BindingSource(userCache1, null);
            cb_end_meal.DisplayMember = "Key";
            cb_end_meal.ValueMember = "Value";
            cb_end_meal.SelectedIndex = 2;

                      

            NS_Conference.StrongTypesNS.ds_conference_lookupDataSet ds_diets = Global.Global.ds_conference_lookups;
            cb_mdiet.DataSource = ds_diets.tt_diets;
            cb_mdiet.DisplayMember = "diet_detail";
            cb_mdiet.ValueMember = "diet";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {

                if (!chk_bf.Checked & !chk_lunch.Checked & !chk_supper.Checked)    
                {
                    MessageBox.Show("Please select the releavant meal times", "Meal Updates", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to proceed with this batch update?", "Meal Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                string meals = "";
                if (chk_bf.Checked) meals = meals + "B";
                if (chk_lunch.Checked) meals = meals + "L";
                if (chk_supper.Checked) meals = meals + "S";

                string setdays = "";
                if (chk_mon.Checked) setdays = setdays + "1";
                if (chk_tue.Checked) setdays = setdays + "2";
                if (chk_wed.Checked) setdays = setdays + "3";
                if (chk_thur.Checked) setdays = setdays + "4";
                if (chk_fri.Checked) setdays = setdays + "5";
                if (chk_sat.Checked) setdays = setdays + "6";
                if (chk_sun.Checked) setdays = setdays + "7";

                string tempsex = "B";
                if (rb_male.Checked) tempsex = "M";
                if (rb_female.Checked) tempsex = "F";

                string feedback = Proxy.ConferenceAdmin.meal_updates(WhichOne, ConferenceCode,ParentFolio, cb_action.SelectedValue.ToString(), dte_start_date.Value, cb_start_meal.SelectedValue.ToString(), dte_end_date.Value, cb_end_meal.SelectedValue.ToString(), meals, setdays, cb_dhall.SelectedValue.ToString(), cb_mdiet.SelectedValue.ToString(),tempsex );
                if (feedback != "") MessageBox.Show(feedback, "Meal Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else this.Close();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void cb_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_action.Text == "Change Diets") pnl_diet.Visible = true;
            else pnl_diet.Visible = false;

            if (cb_action.Text == "Book Meals" || cb_action.Text == "Change Dining Hall" || cb_action.Text == "Packed Meals") pnl_dining_hall.Visible = true;
            else pnl_dining_hall.Visible = false;
        }       
      
    }
}
