using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ConferenceSys.ConferenceAdmin.Conference_Updates
{
    public partial class AvailableBlockRooms : Form
    {

        #region Form Variables
        NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_rooms;
        public bool proceed;
        public string room_no;
        DataView dvList;
        int no_rooms = 0;

        #endregion

        public AvailableBlockRooms(NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet ds_rooms,int no_rooms)
        {
            InitializeComponent();
            this.ds_rooms = ds_rooms;
            this.no_rooms = no_rooms;
        }

        #region form_load
        private void AvailableBlockRooms_Load(object sender, EventArgs e)
        {

            dvList = new DataView(ds_rooms.tt_rooms);
            dvList.Sort = "sort_field";
            bs_rooms.DataSource = dvList;
        }
        #endregion 

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(dg_rooms.Rows.Count > 0)
            {
                int count = 0;
                foreach (DataGridViewRow row in dg_rooms.Rows)
                {
                    if (row.Cells[ckCopy.Name].Value != null && (bool)row.Cells[ckCopy.Name].Value)
                    {
                        count = count + 1;
                    }
                }

                if (count != no_rooms) MessageBox.Show("Please select " + no_rooms.ToString() + " room(s) to continue", "Error Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    foreach (DataGridViewRow row in dg_rooms.Rows)
                    {
                        if (row.Cells[ckCopy.Name].Value != null && (bool)row.Cells[ckCopy.Name].Value)
                        {
                            if (room_no != string.Empty && room_no != null) room_no = room_no + ",";
                            room_no = room_no + row.Cells[cn_roomno.Name].Value.ToString();                            
                        }
                    }
                    proceed = true;
                    this.Close();
                }
            }           
        }
        
        private void btn_clear_selection_Click(object sender, EventArgs e)
        {
            proceed = false;
            this.Close();
        }        

        

    }
}
