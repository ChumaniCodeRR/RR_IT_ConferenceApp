using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Utilities;

namespace ResOps.ConferenceAdmin
{
    public partial class FinancialReport : Form
    {
        string sort_order;
        bool print_zeros;
        string parentfolio = "*";
        bool det_sum;

        public FinancialReport()
        {
            InitializeComponent();
        }

        private void FinancialReport_Load(object sender, EventArgs e)
        {
            

        }

        private void get_conference_details()
        {
            if (txt_ccode.Text != "")
            {
                string feedback = "";
                bool conf_admin;
                NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet ds_conf_details = Proxy.ConferenceAdmin.get_conference(false, txt_ccode.Text, out conf_admin, out feedback);

                DataRow NewBuilding = ds_conf_details.tt_conf_build.NewRow();
                NewBuilding["building"] = "*";
                NewBuilding["building_descrip"] = " All Buildings";
                ds_conf_details.tt_conf_build.Rows.InsertAt(NewBuilding, 0);

                DataView dvBuild = new DataView(ds_conf_details.tt_conf_build);
                dvBuild.Sort = "building_descrip";

                cbBuilding.DataSource = dvBuild;
                cbBuilding.DisplayMember = "building_descrip";
                cbBuilding.ValueMember = "building";
                cbBuilding.SelectedIndex = 0;

                DataRow Newtype = ds_conf_details.tt_conf_type.NewRow();
                Newtype["tcode"] = "*";
                Newtype["descrip"] = "All Types";
                ds_conf_details.tt_conf_type.Rows.InsertAt(Newtype, 0);

                DataView dvTypes = new DataView(ds_conf_details.tt_conf_type);
                dvTypes.Sort =  "descrip";

                cb_conf_types.DataSource = dvTypes ;
                cb_conf_types.DisplayMember = "descrip";
                cb_conf_types.ValueMember = "tcode";
                cb_conf_types.SelectedIndex = 0;
            }
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ccode.Text == string.Empty & txt_main_folio.Text == string.Empty) MessageBox.Show("Please select a Conference and or Main Foilio to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    if (txt_main_folio.Text == "" | txt_main_folio.Text == "*") parentfolio = "*";
                    else parentfolio = txt_main_folio.Text.ToString();

                    det_sum = rb_detailed.Checked;

                    string conf_descrip = "Conference = All Conferences";
                    if (txt_conference.Text != string.Empty) conf_descrip = "Conference = " + txt_ccode.Text + " " + txt_conference.Text.ToString();

                    print_zeros = chk_zeros.Checked;

                    string tempbuilding = "*";
                    if (cbBuilding.SelectedIndex != -1) tempbuilding = cbBuilding.SelectedValue.ToString();


                    string tempconftype = "*";
                    if (cb_conf_types.SelectedIndex != -1) tempconftype = cb_conf_types.SelectedValue.ToString();


                    string feedback = "";
                    NS_Conference.StrongTypesNS.ds_financialDataSet ds_financial = Proxy.ConferenceSystem.financial_report(txt_ccode.Text.ToString(),tempbuilding, parentfolio, tempconftype, chk_zeros.Checked, out feedback);
                    if (feedback != "") MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (ds_financial.BOOKFILE.Rows.Count < 1) MessageBox.Show("Your query returned no data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        try
                        {
                            string filename = System.IO.Path.GetTempPath() + "Financial.xls";

                            FileInfo fi1 = new FileInfo(filename);
                            if (File.Exists(filename) && Utils.IsFileLocked(fi1))
                            {
                                MessageBox.Show("Error - The file " + filename + " is already in use. Please close it or save the open file with a different name before running this extract", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }

                            RhodesControl.ThinkManager.StartThink("Generating Excel File - Please Wait");

                            try
                            {

                                Excel.Application oXL;
                                Excel.Workbook oWB;
                                Excel.Worksheet oSheet;
                                Excel.Range oRange;

                                // Start Excel and get Application object.
                                oXL = new Excel.Application();

                                // Set some properties
                                oXL.DisplayAlerts = false;

                                // Get a new workbook.
                                oWB = oXL.Workbooks.Add(Missing.Value);

                                // Get the active sheet
                                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                                oSheet.Name = "Financial";

                                // Process the DataTable
                                DataTable dt1 = ds_financial.BOOKFILE1;
                                DataTable dt2 = ds_financial.MONEYFILE;



                                oSheet.Cells[1, 1] = "Financial Report";
                                oSheet.Cells[1, 3] = conf_descrip;
                                oSheet.Cells[2, 3] = "Main Folio: " + parentfolio.ToString();

                                int rowCount = 0;
                                if (det_sum == false)
                                {
                                    oSheet.Cells[3, 1] = "Reference";
                                    oSheet.Cells[3, 2] = "Details";                                   
                                    oSheet.Cells[3, 3] = "Total";
                                    rowCount = 3;
                                    int x = 1;
                                    foreach (DataRow dr in dt1.Rows)
                                    {
                                        if (dr[3].ToString() == "Main")
                                        {
                                            dr[3] = "";
                                            rowCount += 1;
                                            for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                            {
                                            if (i == 1 | i == 2 |  i == 23)
                                                {
                                                    oSheet.Cells[rowCount, x] = dr[i - 1].ToString();
                                                    x = x + 1;
                                                }
                                            }

                                        }

                                    }
                                }

                                if (det_sum == true)
                                {
                                    oSheet.Cells[3, 1] = "FOLIO";
                                    oSheet.Cells[3, 2] = "NAME";
                                    oSheet.Cells[3, 3] = "BUILDING";
                                    oSheet.Cells[3, 4] = "ROOM";
                                    oSheet.Cells[3, 5] = "START DATE";
                                    oSheet.Cells[3, 6] = "END DATE";
                                    oSheet.Cells[3, 7] = "RATE";
                                    oSheet.Cells[3, 8] = "Cancelled";
                                    oSheet.Cells[3, 9] = "Totals";
                                    oSheet.Cells[3, 10] = "Extra Meals";
                                    oSheet.Cells[3, 11] = "B";
                                    oSheet.Cells[3, 12] = "L";
                                    oSheet.Cells[3, 13] = "S";
                                    oSheet.Cells[3, 14] = "PD/ADJ";
                                    oSheet.Cells[3, 15] = "Write Off";
                                    oSheet.Cells[3, 16] = "Refund";
                                    oSheet.Cells[3, 17] = "Balance";

                                    rowCount = 3;

                                    int ColCount = 0;

                                    foreach (DataRow dr in dt1.Rows)
                                    {
                                        if (dr[0].ToString() == dr[15].ToString() && dr[3].ToString() == "Main")
                                        {
                                            if (rowCount > 3) rowCount += 2;
                                            rowCount += 1;
                                            for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                            {
                                                if (i == 1 | i == 2 | i == 8 | i == 9 | i == 20 | i == 21 | i == 22 | i == 23 | i == 25)
                                                {
                                                    ColCount = i;
                                                    if (i == 25) ColCount = 14;
                                                    if (i == 20) ColCount = 15;
                                                    if (i == 21) ColCount = 16;
                                                    if (i == 22) ColCount = 17;
                                                    if (i == 23) ColCount = 18;
                                                    oSheet.Cells[rowCount, ColCount] = dr[i - 1].ToString();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            rowCount += 1;
                                            for (int i = 1; i < dt1.Columns.Count + 1; i++)
                                            {
                                                if (dr[3].ToString() != "CNFTRS")
                                                {
                                                    ColCount = i;
                                                    if (i == 9) ColCount = 14;
                                                    if (i == 14) break;

                                                    oSheet.Cells[rowCount, i] = dr[ColCount - 1].ToString();
                                                }

                                                if (dr[3].ToString() == "CNFTRS")
                                                {
                                                    if (i == 1 | i == 2 | i == 20 | i == 21 | i == 22 | i == 25)
                                                    {
                                                        ColCount = i;
                                                        if (i == 25) ColCount = 14;
                                                        if (i == 20) ColCount = 15;
                                                        if (i == 21) ColCount = 16;
                                                        if (i == 22) ColCount = 17;
                                                        oSheet.Cells[rowCount, ColCount] = dr[i - 1].ToString();

                                                    }
                                                }

                                            }
                                        }

                                    }

                                    // Resize the columns
                                    oRange = oSheet.Range[oSheet.Cells[1, 1],
                                    oSheet.Cells[rowCount, dt2.Columns.Count]];
                                    oRange.EntireColumn.AutoFit();

                                    // Save the sheet and close
                                    oSheet = null;
                                    oRange = null;

                                    oWB.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal,
                                      Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                      Excel.XlSaveAsAccessMode.xlExclusive,
                                      Missing.Value, Missing.Value, Missing.Value,
                                      Missing.Value, Missing.Value);

                                    oWB = null;
                                    oXL.Visible = true;

                                    // Clean up
                                    // NOTE: When in release mode, this does the trick
                                    GC.WaitForPendingFinalizers();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    GC.Collect();
                                }
                            }
                            catch (Exception Ex)
                            {
                                MessageBox.Show(Ex.Message, "Error with Export", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        finally
                        {
                            RhodesControl.ThinkManager.EndThink();
                            this.BringToFront();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(Utilities.ExceptionSource.ResOps, ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_ccode.Text != string.Empty)
            {
                ConferenceSys.ConferenceAdmin.SearchMainReserv frmMain = new ConferenceSys.ConferenceAdmin.SearchMainReserv(txt_ccode.Text.ToString(),txt_conference.Text.ToString());
                frmMain.ShowDialog();
                if (frmMain.Mainfolio != "") txt_main_folio.Text = frmMain.Mainfolio;
                else txt_main_folio.Text = "";
            }
            else
            {
                ConferenceSys.ConferenceWardens.SearchFolio frm_search = new ConferenceSys.ConferenceWardens.SearchFolio();
                frm_search.ShowDialog();

                if (frm_search.folio != "") txt_main_folio.Text = frm_search.folio;
                else txt_main_folio.Text = "";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_con_Click(object sender, EventArgs e)
        {
            try
            {
                ConferenceSys.ConferenceWardens.SearchConference frm_search = new ConferenceSys.ConferenceWardens.SearchConference();
                frm_search.ShowDialog();

                if (frm_search.conference != "")
                {
                    txt_ccode.Text = frm_search.conference;
                    txt_conference.Text = frm_search.descrip;
                    txt_main_folio.Text = "";
                    get_conference_details();
                }
            }

            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResOps, ex);
            }
        }
    
    }
}
