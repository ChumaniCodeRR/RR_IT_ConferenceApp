using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceAdmin.Conference_Updates
{
    public partial class Capture_Reciept : Form
    {
        NS_ConfAdmin.StrongTypesNS.ds_recieptDataSet ds_reciept = new NS_ConfAdmin.StrongTypesNS.ds_recieptDataSet();

        string trs_ref = string.Empty;
        int multi_payment = 0;

        public Capture_Reciept(string trs_ref, int multi_payment)
        {
            InitializeComponent();
            this.trs_ref = trs_ref;
            this.multi_payment = multi_payment;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            decimal total_amt = 0;
            try { total_amt = decimal.Parse(txt_amount.Text); }
            catch {
                MessageBox.Show("The amount entered is invalid","Invalid Amount",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            string feedback = Proxy.ConferenceAdmin.check_valid_receipt(txt_receipt.Text.ToString(), decimal.Parse(txt_amount.Text));

            if (feedback != string.Empty)
            {
                if (feedback.Contains("Error"))
                {
                    MessageBox.Show(feedback, "Error Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show(feedback, "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            }

            pnl_header.Enabled = false;
            pnl_reciepts.Enabled = true;
            lbl_remaining.Text = "Total Remaining: R" + txt_amount.Text.ToString(); 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_folio_Click(object sender, EventArgs e)
        {
            ConferenceSys.ConferenceWardens.SearchFolio frm_search = new ConferenceSys.ConferenceWardens.SearchFolio();
            frm_search.ShowDialog();

            if (frm_search.folio != "" & frm_search.folio != null)
            {
                txt_folio.Text = frm_search.folio;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            decimal total_pending = 0;
            try { total_pending = decimal.Parse(txt_folio_amt.Text); }
            catch
            {
                MessageBox.Show("The amount entered is invalid", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            string feedback = Proxy.ConferenceAdmin.multi_reciept_update(decimal.Parse(txt_amount.Text), txt_folio.Text, decimal.Parse(txt_folio_amt.Text), true, out total_pending, ref ds_reciept);
            if (feedback != string.Empty) MessageBox.Show(feedback, "Add Folio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                lbl_remaining.Text = "Total Remaining: R" + total_pending.ToString();
                txt_folio.Text = txt_folio_amt.Text = string.Empty;
            }
            ds_ttreciept.DataSource = ds_reciept.tt_multi_reciept;
            txt_folio.Focus();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_folios.SelectedRows.Count > 0)
            {
                
                decimal total_pending = 0;
                
                string feedback = Proxy.ConferenceAdmin.multi_reciept_update(decimal.Parse(txt_amount.Text), dgv_folios.SelectedRows[0].Cells[c_main_folio.Name].Value.ToString() , 0 , false, out total_pending, ref ds_reciept);
                if (feedback != string.Empty) MessageBox.Show(feedback, "Remove Folio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else { lbl_remaining.Text = "Total Remaining: R" + total_pending.ToString();
                txt_folio.Focus();
                }
                ds_ttreciept.DataSource = ds_reciept.tt_multi_reciept;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lbl_remaining.Text == "Total Remaining: R0")
            {
                string feedback = Proxy.ConferenceAdmin.create_multi_reciepts(txt_receipt.Text, txt_amount.Text, ds_reciept);
                MessageBox.Show(feedback, "Save Reciept", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!feedback.StartsWith("Error")) this.Close();
            }
            else { MessageBox.Show(lbl_remaining.Text + ". Unable to Save until all the money is allocated.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Capture_Reciept_Load(object sender, EventArgs e)
        {
            if (multi_payment != -1)
            {
                string feedback = string.Empty;
                decimal totalamt = 0;
                ds_reciept = Proxy.ConferenceAdmin.Fetch_Multi_Payments(multi_payment, out feedback, out totalamt);
                if (feedback != string.Empty)
                {
                    MessageBox.Show(feedback, "Fetch Linked Reservations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    ds_ttreciept.DataSource = ds_reciept.tt_multi_reciept;
                    txt_receipt.Text = trs_ref;
                    txt_amount.Text = totalamt.ToString();
                    lbl_remaining.Visible = false;
                    pnl_header.Enabled = false;
                    pnl_reciepts.Enabled = false;
                }
            }
        }
    }
}
