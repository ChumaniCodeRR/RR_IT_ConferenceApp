﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceWardens
{
    public partial class QuerySurnName : Form
    {
        public QuerySurnName()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

            for (int x = DateTime.Today.Year - 10; x <= DateTime.Today.Year + 1; x++)
            {
                cb_yr.Items.Add(x);
            }
            cb_yr.SelectedIndex = cb_yr.FindString((DateTime.Today.Year).ToString());
            

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MainFolio.Text == "" && txt_search.Text == "") MessageBox.Show("Error - Please enter surname, name or group to search for", "Error Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    NS_Conference.StrongTypesNS.ds_registerDataSet ds_register = new NS_Conference.StrongTypesNS.ds_registerDataSet();

                    bool surn_name = rb_surn.Checked;
                    string searchstr = txt_search.Text;
                    string MainFolio = txt_MainFolio.Text;
                    int tempyr = Int32.Parse(cb_yr.Text.ToString());

                    ds_register = Proxy.ConferenceSystem.query_by_names(surn_name, searchstr, MainFolio, tempyr);

                    if (ds_register.TT_REGISTER.Rows.Count > 0)
                    {

                        string temptitle = "Query By Surname/Name/Folio or Group";
                        Reports frm_report = new Reports("QuerySurnName", ds_register, temptitle);
                        frm_report.Show();

                    }
                    else MessageBox.Show("Your query returned no data to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btn_search_groups_Click(object sender, EventArgs e)
        {
            SearchFolio frm_search = new SearchFolio();
            frm_search.ShowDialog();

            if (frm_search.folio != "")
            {
                txt_MainFolio.Text = frm_search.folio;
                txt_grp_descrip.Text = frm_search.descrip;
            }


           
        }

        private void validate_group()
        {
            try
            {
                if (txt_MainFolio.Text != "")
                {
                    string feedback = Proxy.ConferenceSystem.validate_mainfolio(txt_MainFolio.Text);
                    if (!feedback.Contains("Error")) txt_grp_descrip.Text = feedback;
                    else
                    {
                        MessageBox.Show(feedback, "Error Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MainFolio.Text = "";
                        txt_grp_descrip.Text = "";
                        txt_MainFolio.Focus();
                    }
                }
                else txt_grp_descrip.Text = "";
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }

        }

        private void txt_group_Leave(object sender, EventArgs e)
        {
            validate_group();
        }

        private void txt_group_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate_group();
            }
        }

    }
}
