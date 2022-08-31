using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceWardens
{
    public partial class QueryResRoom : Form
    {
        public QueryResRoom()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                nlb_from.Value = DateTime.Today;
                nlb_to.Value = DateTime.Today;

                DataRow newbuild = Global.Global.ds_conf_codes.TT_CONF_BUILDING.NewRow();
                newbuild["building"] = "*";
                newbuild["building_name"] = "All Buildings";
                newbuild["res"] = 999;
                Global.Global.ds_conf_codes.TT_CONF_BUILDING.Rows.InsertAt(newbuild, 0);
                bs_building.DataSource = Global.Global.ds_conf_codes.TT_CONF_BUILDING;
                cb_buliding.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                NS_Conference.StrongTypesNS.ds_registerDataSet ds_register = new NS_Conference.StrongTypesNS.ds_registerDataSet();

                string tempdate;
                string tempdate1;
                string cbuilding = "";
                string troom = "";
                string feedback = "";

                if (nlb_from.Value == null) tempdate = "?";
                else tempdate = ((DateTime)nlb_from.Value).ToString("dd/MM/yyyy");

                if (nlb_to.Value == null) tempdate1 = "?";
                else tempdate1 = ((DateTime)nlb_to.Value).ToString("dd/MM/yyyy");
                cbuilding = cb_buliding.SelectedValue.ToString();
                troom = txt_room.Text;

                ds_register = Proxy.ConferenceSystem.query_res_room(tempdate, tempdate1, cbuilding, troom, out feedback);
                if (feedback.Contains("Error"))
                {
                    MessageBox.Show(feedback, "Register Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ds_register.TT_REGISTER.Rows.Count > 0)
                {
                    string temptitle = "Residence Query By Room";
                    Reports frm_report = new Reports("QueryResRoom", ds_register, temptitle);
                    frm_report.Show();
                }
                else MessageBox.Show("Your query returned no data to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ConferenceSystem, ex);
            }
        }

    }

}
