﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConferenceSys.ConferenceWardens;
using Utilities;

namespace ConferenceSys.ConferenceAdmin.ConferenceUpdate
{
    public partial class ConferenceTypes : Form
    {
        NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conference;

        public ConferenceTypes(NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet _ds_conference)
        {
            InitializeComponent();
            ds_conference = _ds_conference;          
        }

       
  

        //Note: This is the first meal they recieve on day of arrival. If Breakfast the following Day, do not make breakfast the first meal.

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_descrip.Text == "") MessageBox.Show("Type description cannot be blank", "Error Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cb_start_meal.SelectedIndex < 0) MessageBox.Show("First Meal cannot be blank", "Error FirstMeal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cb_end_meal.SelectedIndex < 0) MessageBox.Show("Last Meal cannot be blank", "Error LastMeal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string feedback = Proxy.ConferenceAdmin.update_conference_types(ds_conference);
                    if (feedback != "") MessageBox.Show(feedback, "Update Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else this.Close();
                }
            }

            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }         

        }

        private void ConferenceTypes_Load(object sender, EventArgs e)
        {
            cb_start_meal.Items.Add(new Item("Breakfast", "B"));
            cb_start_meal.Items.Add(new Item("Lunch", "L"));
            cb_start_meal.Items.Add(new Item("Supper", "S"));

            cb_end_meal.Items.Add(new Item("Breakfast", "B"));
            cb_end_meal.Items.Add(new Item("Lunch", "L"));
            cb_end_meal.Items.Add(new Item("Supper", "S"));

            bs_rates.DataSource = ds_conference.tt_conf_type;

            toolTip1.SetToolTip(cb_start_meal, "This is the first meal the guest will recieve on day of arrival. DO NOT make the first meal breakfast, if they only getting breakfast the following day.");
            toolTip1.SetToolTip(cb_end_meal, "This is the last meal the guest will recieve on day of departure. Usually set to Breakfast.");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_breakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_breakfast.Checked)
            {
                chk_b_served.Checked = true;
                chk_b_served.Enabled = false;
            }
            else chk_b_served.Enabled = true;
        }

        private void chk_lunch_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lunch.Checked)
            {
                chk_l_served.Checked = true;
                chk_l_served.Enabled = false;
            }
            else chk_l_served.Enabled = true;
        }

        private void chk_supper_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_supper.Checked)
            {
                chk_s_served.Checked = true;
                chk_s_served.Enabled = false;
            }
            else chk_s_served.Enabled = true;
        }    

    }
}
