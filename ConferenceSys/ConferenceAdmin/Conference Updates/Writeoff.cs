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
    public partial class Writeoff : Form
    {
        public Writeoff()
        {
            InitializeComponent();
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

        private void Writeoff_Load(object sender, EventArgs e)
        {

        }

        private void btn_writeoff_Click(object sender, EventArgs e)
        {
            if (txt_folio.Text == string.Empty) MessageBox.Show("Please enter group or single folio number to continue", "Error Folio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_reason.Text == string.Empty) MessageBox.Show("Please enter the reason for the writeoff", "Error Reason", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string feedback = Proxy.ConferenceAdmin.check_writeoff_reservation(rb_group.Checked, txt_folio.Text.ToString());
                if(feedback != string.Empty)
                {
                    if (feedback.Contains("Error")) MessageBox.Show(feedback, "Error Writeoff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (MessageBox.Show(feedback, "Writeoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            feedback = string.Empty;
                            feedback = Proxy.ConferenceAdmin.create_writeoff_list(rb_group.Checked, txt_folio.Text, txt_reason.Text);
                            MessageBox.Show(feedback, "Write Off", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!feedback.Contains("Error"))
                            {
                                txt_reason.Text = string.Empty; txt_folio.Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
