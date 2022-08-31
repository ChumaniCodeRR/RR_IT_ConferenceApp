using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using NS_Conference.StrongTypesNS;

namespace ConferenceSys
{
    public partial class SelectFolio : Form
    {
        List<string> folios;
        string _folio;

        public SelectFolio(List<string> _folios)
        {
            InitializeComponent();

            folios = _folios;
        }

        private void SelectFolio_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string f in folios)
                {
                    int index = new BindingSource(Global.Global.ds_bookings, "tt_booking_summary").Find("folio", f);
                    if (index < 0) throw new ApplicationException("Folio not found");

                    ds_booking_summaryDataSet.tt_booking_summaryRow booking = Global.Global.ds_bookings.tt_booking_summary[index];
                    string guest = string.Format("{0} {1} {2}", booking.titl, booking.initials, booking.surn);
                    dgvSelectFolio.Rows.Add(false, booking.folio, guest);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        void SelectFolio_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult.Equals(DialogResult.OK))
                {
                    DataGridViewCheckBoxCell checkCell;
                    //Check if there's any selected folio
                    foreach (DataGridViewRow row in dgvSelectFolio.Rows)
                    {
                        checkCell = (DataGridViewCheckBoxCell)row.Cells[cCheck.Name];
                        if (checkCell.Value != null && (bool)checkCell.Value) return;
                    }

                    MessageBox.Show("You have to select a folio number first.", "Select Folio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        void dgvSelectFolio_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(dgvSelectFolio.Columns[cCheck.Name].Index) &&
                    dgvSelectFolio[e.ColumnIndex, e.RowIndex].Value != null &&
                    (bool)dgvSelectFolio[e.ColumnIndex, e.RowIndex].Value)
                {
                    DataGridViewCheckBoxCell checkCell;
                    foreach (DataGridViewRow row in dgvSelectFolio.Rows)
                    {
                        if (!row.Index.Equals(e.RowIndex))
                        {
                            checkCell = (DataGridViewCheckBoxCell)row.Cells[cCheck.Name];
                            checkCell.Value = false;
                        }
                    }
                    _folio = dgvSelectFolio["cFolio", e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ConferenceSystem, ex);
            }
        }

        void dgvSelectFolio_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dgvSelectFolio.IsCurrentCellDirty)
            {
                dgvSelectFolio.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        public string Folio
        {
            get { return _folio; }
        }
    }
}
