using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferenceSys.ConferenceAdmin
{
    public partial class Discount : Form
    {

        string groupname = string.Empty;
        string mainfolio = string.Empty;

        public Discount(string groupname, string mainfolio)
        {
            InitializeComponent();
            this.groupname = groupname;
            this.mainfolio = mainfolio;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            lbl_group_name.Text = groupname;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            decimal discount = 0;
            try
            {
                discount = Decimal.Parse(txt_discount.Text);
                if (discount < 0 | discount > 100)
                {
                    MessageBox.Show("Discount should be between 0 and 100 percent", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

                }
                
                string feedback = Proxy.ConferenceAdmin.GROUP_DISCOUNT(mainfolio, discount);
                MessageBox.Show(feedback, "Group Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch { MessageBox.Show("Please enter a decimal value", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Stop); }            
        }
    }
}
