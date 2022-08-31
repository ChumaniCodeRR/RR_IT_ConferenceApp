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
    public partial class MultipleAdd : Form
    {
        public bool proceed;
        public int tot_num;

        public MultipleAdd()
        {
            InitializeComponent();
        }

        private void MultipleAdd_Load(object sender, EventArgs e)
        {
            txt_no.Text = "2";
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == string.Empty)
            {
                proceed = false;
                tot_num = 0;
            }
            else
            {
                proceed = true;
                tot_num = Int32.Parse(txt_no.Text.ToString()) + 1;
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            proceed = false;
            this.Close();
        }
    }
}
