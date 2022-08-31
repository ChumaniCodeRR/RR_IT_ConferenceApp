using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ConferenceSys.SRC
{
    public partial class SrcMain : Form
    {

        bool AddNew;
        DataView dvList;

        public SrcMain()
        {
            InitializeComponent();
        }

        private void SrcMain_Load(object sender, EventArgs e)
        {
            for (int x = DateTime.Today.Year; x <= DateTime.Today.Year + 1; x++)
            {
                cb_yr.Items.Add(x);
            }
            cb_yr.SelectedIndex = cb_yr.FindString((DateTime.Today.Year).ToString());
                     
            sc_src.Panel1.Enabled = true;
            sc_src.Panel2Collapsed = true;           
        }


        private void get_list()
        {
            try
            {           
                int tempyr = Int32.Parse(cb_yr.Text.ToString());
                NS_ConfAdmin.StrongTypesNS.DS_SRCDataSet ds_src = Proxy.ConferenceAdmin.get_src_list(tempyr);
                dvList = new DataView(ds_src.TT_SRC);
                dvList.Sort = "NAMESTR";
                bs_list.DataSource = dvList;
          
                pnl_budget.Enabled = true;
                sc_src.Panel1.Enabled = true;
                sc_src.Panel2Collapsed = true;
             }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        private void btn_cancel_amt_Click(object sender, EventArgs e)
        {
            sc_src.Panel1.Enabled = true;
            sc_src.Panel2Collapsed = true;
        }

        private void btn_save_amt_Click(object sender, EventArgs e)
        {
           {
               try
               {
                   if (txt_stuno.Text ==  string.Empty) MessageBox.Show("Error - Please select a student to continue","Error Stuno",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   else if (txt_role.Text == string.Empty) MessageBox.Show("Error - Please enter src role to continue", "Error Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   else
                   {
                        int tempyr = Int32.Parse(cb_yr.Text.ToString());
                        string feedback = Proxy.ConferenceAdmin.update_src_list(AddNew,tempyr,txt_stuno.Text.ToString(),txt_role.Text.ToString());
                        MessageBox.Show(feedback, "Update List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!feedback.Contains("Error")) get_list();                    
                   }
                }
                catch (Exception ex)
                {
                    Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_amounts_DoubleClick(object sender, EventArgs e)
        {
            if (dg_amounts.SelectedRows.Count > 0)
            {
                AddNew = false;
                btn_search.Enabled = false;
                txt_stuno.Text = dg_amounts.SelectedRows[0].Cells[cn_stuno.Name].Value.ToString();
                txt_name.Text = dg_amounts.SelectedRows[0].Cells[cn_name.Name].Value.ToString();
                txt_role.Text = dg_amounts.SelectedRows[0].Cells[cn_role.Name].Value.ToString();
                sc_src.Panel1.Enabled = false;
                sc_src.Panel2Collapsed = false;              
            }
        }

        private void cb_yr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_yr.SelectedIndex > -1) get_list();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNew = true;
            btn_search.Enabled = true;
            txt_stuno.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_role.Text = string.Empty;
            sc_src.Panel1.Enabled = false;
            sc_src.Panel2Collapsed = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dg_amounts.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete " + dg_amounts.SelectedRows[0].Cells[cn_name.Name].Value.ToString() + " from the SRC list?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int tempyr = Int32.Parse(cb_yr.Text.ToString());
                        string feedback = Proxy.ConferenceAdmin.delete_src(tempyr, dg_amounts.SelectedRows[0].Cells[cn_stuno.Name].Value.ToString());
                        if (feedback != "") MessageBox.Show(feedback, "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else get_list();
                    }
                 }
                catch (Exception ex)
                {
                    Utils.HandleException(ExceptionSource.DMU, ex);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search_Grid_Students.Search_Grid_Students frmSearch = new Search_Grid_Students.Search_Grid_Students(true);
            frmSearch.ShowDialog();
            if (frmSearch.Stuno != "")
            {
                txt_stuno.Text = frmSearch.Stuno.ToString();
                txt_name.Text = frmSearch.Surname.ToString() + ", " + frmSearch.First_Name.ToString();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dg_amounts.RowCount > 0)
            {
                string title = "SRC Executive List " + cb_yr.Text.ToString();
                Reports frmReport = new Reports(false, "SRCList", dvList, title);
                frmReport.Show();

            }
        }    
    }
}
