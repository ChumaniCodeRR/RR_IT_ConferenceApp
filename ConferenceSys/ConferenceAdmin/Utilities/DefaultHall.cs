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
    public partial class DefaultHall : Form
    {   
        
        string folio = string.Empty;
        int booking_ref = 0;
        
        DateTime StartDate;
        DateTime EndDate;
        string header;

        public DefaultHall(string header, int booking_ref, string folio, DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();
            this.folio = folio;
            this.booking_ref = booking_ref;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.header = header;
        }

        private void DefaultHall_Load(object sender, EventArgs e)
        {
            DataView DV_Halls = new DataView(Global.Global.ds_conf_codes.tt_dhall);
            DV_Halls.Sort = "detail";
            cbHall.DataSource = DV_Halls;
            cbHall.SelectedIndex = 0;

            txt_feedback.Text = header;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_no.Checked == false && rb_yes.Checked == false) MessageBox.Show("Please specify whether the meal(s) must be reset or not", "Update Meals", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    if (rb_yes.Checked == true)
                    {
                        
                        string reset_mealsfeedback = Proxy.ConferenceAdmin.reset_meals(booking_ref, folio, ckbox_dininghall.Checked, cbHall.SelectedValue.ToString(), StartDate, EndDate);
                        MessageBox.Show(reset_mealsfeedback, "Reset Meals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void rb_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_yes.Checked == true) ckbox_dininghall.Visible = true;
        }

        private void rb_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_no.Checked == true)
            {
                ckbox_dininghall.Checked = ckbox_dininghall.Visible = false;
            }            
        }

        private void ckbox_dininghall_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_dininghall.Checked == true) pnl_dininghall.Visible = true;
            else pnl_dininghall.Visible = false;
        }
    }
}
