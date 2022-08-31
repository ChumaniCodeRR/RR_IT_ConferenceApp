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
    public partial class SearchConference : Form
    {
        string _conference;
        string _descrip;
        DataView dv_conferences;

        public NS_Conference.StrongTypesNS.ds_conference_lookupDataSet ds_conference = new NS_Conference.StrongTypesNS.ds_conference_lookupDataSet();


        public SearchConference()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string conference
        {
            get { return _conference; }
            set { _conference = value; }
        }

        public string descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }


        private void SearchFolio_Load(object sender, EventArgs e)
        {
            try
            {
                ds_conference = Proxy.ConferenceSystem.Get_Conference_Code_Descriptions();
                dv_conferences = new DataView(ds_conference.tt_conference);
                bs_conference.DataSource = dv_conferences;
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void filter()
        {
            try
            {
                dv_conferences.RowFilter = "ccode like '*" + txt_code.Text + "*' and conference like '*" + txt_conference.Text + "*'";
                bs_conference.DataSource = dv_conferences;
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void dg_folios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dg_conferences.RowCount > 0)
                {
                    _conference = dg_conferences.SelectedRows[0].Cells[cn_conf.Name].Value.ToString();
                    _descrip = dg_conferences.SelectedRows[0].Cells[cn_conf_descrip.Name].Value.ToString();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }
                
        private void txt_surn_TextChanged_1(object sender, EventArgs e)
        {
            filter();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
