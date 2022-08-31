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
    public partial class ResetBookDates : Form
    {

        string ConferenceCode;
        string MainFolio;

        string OldStart = string.Empty;
        string OldEnd = string.Empty;
     
        
        public ResetBookDates(string _ConferenceCode, string _MainFolio)
        {
            InitializeComponent();
            ConferenceCode = _ConferenceCode;
            MainFolio = _MainFolio;
        }

        private void ResetBookDates_Load(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.ConferenceAdmin.get_original_dates(MainFolio, out OldStart, out OldEnd);               
               
                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    dte_old_start.Value = DateTime.Parse(OldStart);
                    dte_new_start.Value = DateTime.Parse(OldStart);

                    if (dte_new_start.Value <= DateTime.Today.AddDays(1)) dte_new_start.Enabled = false;
                    else dte_new_start.MinDate = DateTime.Today.AddDays(1);

                    dte_old_end.Value = DateTime.Parse(OldEnd);
                    dte_new_end.Value =  DateTime.Parse(OldEnd);

                    if (dte_new_end.Value <= DateTime.Today.AddDays(1)) dte_new_end.Enabled = false;
                    else dte_new_end.MinDate = dte_new_start.MinDate;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (dte_new_start.Value == dte_old_start.Value && dte_old_end.Value == dte_new_end.Value)
                {
                    MessageBox.Show("Error - You have not updated the conference dates. Update Failed.", "Reset Dates", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (dte_new_end.Value <= dte_new_start.Value)
                {
                    MessageBox.Show("Error = New End Date cannot be on or before the new start date. Update Failed.", "Reset Dates", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string meals = " You have chosen NOT to recreate the meals!";
                if (chk_recreate.Checked == true) meals = "Meals will also be recreated!";
                
                if (MessageBox.Show("Are you sure you wish to update the dates of this conference dates?"  + Environment.NewLine + Environment.NewLine + meals, "Change Group Dates",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
                
                string feedback = Proxy.ConferenceAdmin.reset_group_dates(ConferenceCode, MainFolio, chk_recreate.Checked,dte_new_start.Value, dte_new_end.Value, dte_old_start.Value, dte_old_end.Value);
                if (feedback != "") MessageBox.Show(feedback, "Reset Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!feedback.StartsWith("Error")) this.Close(); 
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
    }
}
