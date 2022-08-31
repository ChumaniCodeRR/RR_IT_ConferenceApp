﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceAdmin
{
    public partial class SearchMainReserv : Form
    {
        string conference_code;
        string ConfDescrip;

        string _Mainfolio;
        string _descrip;
        NS_ConfAdmin.StrongTypesNS.ds_reserv_lookupDataSet ds_reserv_lookup = new NS_ConfAdmin.StrongTypesNS.ds_reserv_lookupDataSet();
        DataView dv_reservations;

        public SearchMainReserv(string _conference_code, string _Confdescrip)
        {
            InitializeComponent();
            conference_code = _conference_code;
            ConfDescrip = _Confdescrip;
        }

        public string Mainfolio
        {
            get { return _Mainfolio; }
            set { _Mainfolio = value; }
        }

        public string descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }

        private void SearchMainReserv_Load(object sender, EventArgs e)
        {


            if (conference_code != "")
            {
                cb_conferences.Items.Add(new Item(ConfDescrip,conference_code));
                cb_conferences.SelectedIndex = 0;
               // cb_conferences.SelectedValue = conference_code;
                cb_conferences.Enabled = false;

            }
            else
             {
                NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conferences = Proxy.ConferenceAdmin.get_conference_reservations();
                cb_conferences.DataSource = ds_conferences.tt_conference;
                cb_conferences.DisplayMember = "";
                cb_conferences.ValueMember = "";

                cb_conferences.Enabled = true;

            }

            if (cb_conferences.SelectedIndex != -1) get_reservations();
        }

        private void get_reservations()
        {
            string SearchConference = conference_code;
            if (SearchConference == "") SearchConference = cb_conferences.SelectedValue.ToString();
            bool showStuDetails;
            ds_reserv_lookup = Proxy.ConferenceAdmin.get_reservations(SearchConference, out showStuDetails);
            filter();
        }

        private void filter()
        {
            try
            {
                dv_reservations = new DataView(ds_reserv_lookup.tt_reserve_lookup);
                dv_reservations.RowFilter = "folio like '*" + txt_folio.Text + "*' and institution like '*" + txt_organisation.Text + "*' and surn like '*" + txt_surname.Text + "*'";
                bs_reservations.DataSource = dv_reservations;

            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void dg_conferences_DoubleClick(object sender, EventArgs e)
        {
            if (dg_conferences.SelectedRows.Count > 0)
            {
                _Mainfolio = dg_conferences.SelectedRows[0].Cells[cnFolio.Name].Value.ToString();
                _descrip = dg_conferences.SelectedRows[0].Cells[cnSurn.Name].Value.ToString();
                if(dg_conferences.SelectedRows[0].Cells[cnInstitution.Name].Value.ToString() != "")
                    _descrip = _descrip + ", " + dg_conferences.SelectedRows[0].Cells[cnInstitution.Name].Value.ToString(); ;
                this.Close();

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_conferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_reservations();
        }
        
    }
}
