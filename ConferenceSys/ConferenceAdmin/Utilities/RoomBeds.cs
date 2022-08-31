using System;
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

namespace ConferenceSys.ConferenceAdmin
{
    public partial class RoomBeds : Form
    {
        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_rooms;
        bool loaded = false;

        public RoomBeds()
        {
            InitializeComponent();
        }

        private void RoomBeds_Load(object sender, EventArgs e)
        {
            DataView DV_Halls = new DataView(Global.Global.ds_conf_codes.tt_conf_hall);
            DV_Halls.Sort = "hallname";
            bsHall.DataSource = DV_Halls;
            if (cbHall.SelectedIndex > -1) FilterResidence(sender, e);

            pnl_header.Enabled = true;
            pnl_rooms.Enabled = false;
        }

        void FilterResidence(object sender, EventArgs e)
        {
            DataView dvRes = new DataView(Global.Global.ds_conf_codes.tt_conf_res.Copy());
            dvRes.RowFilter = string.Format("HALL = '{0}'", cbHall.SelectedValue.ToString());
            dvRes.Sort = "resname";
            bsHouse.DataSource = dvRes;
            if (cbHouse.Items.Count > 0 && cbHouse.SelectedIndex != 0) cbHouse.SelectedIndex = 0;
            Invoke(new EventHandler(cbHouse_SelectedIndexChanged), cbHouse, e);
        }

        private void cbHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterResidence(sender, e);
        }

        private void cbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbHouse.SelectedIndex >= 0)
                {
                    DS_BUILDINGSDataSet ds_buildings = Proxy.System.Get_Res_Buildings(
                        int.Parse(cbHouse.SelectedValue.ToString()), Proxy.BuildingTypeEnum.Conference.ToString());
                    DataView dvBuilding = new DataView(ds_buildings.TT_BUILDING);
                    dvBuilding.Sort ="BUILDING_NAME";
                    bsBuilding.DataSource = dvBuilding;
                    if (cbBuilding.Items.Count > 0 && cbBuilding.SelectedIndex != 0) cbBuilding.SelectedIndex = 0;

                }
                else
                {
                    bsBuilding.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            get_rooms();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            ds_rooms.Clear();
            pnl_header.Enabled = true;
            pnl_rooms.Enabled = false;
            loaded = false;
        }
       

        private void dv_rooms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (loaded == true)
                {
                    if (dv_rooms.CurrentCell == null) return;

                    if (dv_rooms.CurrentCell.OwningColumn.Name.Equals(cn_bedsconf.Name) | dv_rooms.CurrentCell.OwningColumn.Name.Equals(cn_bedsnaf.Name))
                    {
                        string tempbuilding = cbBuilding.SelectedValue.ToString();
                        string room_no = dv_rooms[cn_roomno.Name, e.RowIndex].Value.ToString();
                        string which_one = string.Empty;
                        int tot_beds = 0;
                        
                        if (dv_rooms.CurrentCell.OwningColumn.Name.Equals(cn_bedsconf.Name))
                        {
                            which_one = "conf";
                            tot_beds = int.Parse(dv_rooms[cn_bedsconf.Name, e.RowIndex].Value.ToString());
                        }
                        else
                        {
                            which_one = "naf";
                            tot_beds = int.Parse(dv_rooms[cn_bedsnaf.Name, e.RowIndex].Value.ToString());                            
                        }
                        if (tot_beds < 0 | tot_beds > 2)
                        {
                            MessageBox.Show("Room can only have 0,1 or 2 beds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            get_rooms();

                        }
                        else  Proxy.ConferenceAdmin.update_room_beds(tempbuilding,room_no,which_one,tot_beds);
                    }
                }

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }

        }

        private void get_rooms()
        {
            try
            {
                if (cbBuilding.SelectedIndex > -1)
                {
                    string feedback = Proxy.ConferenceAdmin.get_building_rooms(cbBuilding.SelectedValue.ToString(), out ds_rooms);
                    if (feedback != "") MessageBox.Show(feedback, "Get Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DataView dvRooms = new DataView(ds_rooms.tt_rooms);
                        dvRooms.Sort = "sort_field";
                        bs_rooms.DataSource = dvRooms;
                        pnl_header.Enabled = false;
                        pnl_rooms.Enabled = true;
                        loaded = true;
                    }
                }
             }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }
    }
}
