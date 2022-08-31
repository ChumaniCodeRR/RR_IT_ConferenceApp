namespace ConferenceSys.ConferenceAdmin.Group_Updates
{
    partial class Transactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bs_transactions = new System.Windows.Forms.BindingSource(this.components);
            this.sc_transactions = new System.Windows.Forms.SplitContainer();
            this.btn_write_off = new System.Windows.Forms.Button();
            this.btn_reverse_refund = new System.Windows.Forms.Button();
            this.btn_refund = new System.Windows.Forms.Button();
            this.btn_reverse_receipt = new System.Windows.Forms.Button();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.btn_reverse_charge = new System.Windows.Forms.Button();
            this.btn_add_charge = new System.Windows.Forms.Button();
            this.dg_transactions = new CustomDataGridView();
            this.tRSDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPNARRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDESCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_narr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_receipt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_transactions)).BeginInit();
            this.sc_transactions.Panel1.SuspendLayout();
            this.sc_transactions.Panel2.SuspendLayout();
            this.sc_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_transactions
            // 
            this.bs_transactions.DataSource = typeof(NS_ConfAdmin.StrongTypesNS.ds_reservationDataSet.tt_cnftrsDataTable);
            // 
            // sc_transactions
            // 
            this.sc_transactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc_transactions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc_transactions.Location = new System.Drawing.Point(2, 2);
            this.sc_transactions.Name = "sc_transactions";
            this.sc_transactions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_transactions.Panel1
            // 
            this.sc_transactions.Panel1.Controls.Add(this.btn_write_off);
            this.sc_transactions.Panel1.Controls.Add(this.btn_reverse_refund);
            this.sc_transactions.Panel1.Controls.Add(this.btn_refund);
            this.sc_transactions.Panel1.Controls.Add(this.btn_reverse_receipt);
            this.sc_transactions.Panel1.Controls.Add(this.btn_receipt);
            this.sc_transactions.Panel1.Controls.Add(this.btn_reverse_charge);
            this.sc_transactions.Panel1.Controls.Add(this.btn_add_charge);
            this.sc_transactions.Panel1.Controls.Add(this.dg_transactions);
            // 
            // sc_transactions.Panel2
            // 
            this.sc_transactions.Panel2.Controls.Add(this.txt_narr);
            this.sc_transactions.Panel2.Controls.Add(this.label2);
            this.sc_transactions.Panel2.Controls.Add(this.txt_receipt);
            this.sc_transactions.Panel2.Controls.Add(this.label1);
            this.sc_transactions.Panel2.Controls.Add(this.txt_amount);
            this.sc_transactions.Panel2.Controls.Add(this.label6);
            this.sc_transactions.Panel2.Controls.Add(this.btn_cancel);
            this.sc_transactions.Panel2.Controls.Add(this.btn_save);
            this.sc_transactions.Size = new System.Drawing.Size(852, 503);
            this.sc_transactions.SplitterDistance = 425;
            this.sc_transactions.TabIndex = 12;
            // 
            // btn_write_off
            // 
            this.btn_write_off.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_write_off.Location = new System.Drawing.Point(728, 386);
            this.btn_write_off.Name = "btn_write_off";
            this.btn_write_off.Size = new System.Drawing.Size(116, 23);
            this.btn_write_off.TabIndex = 44;
            this.btn_write_off.Text = "Write Off An Amount";
            this.btn_write_off.UseVisualStyleBackColor = true;
            this.btn_write_off.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_reverse_refund
            // 
            this.btn_reverse_refund.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_reverse_refund.Location = new System.Drawing.Point(606, 386);
            this.btn_reverse_refund.Name = "btn_reverse_refund";
            this.btn_reverse_refund.Size = new System.Drawing.Size(116, 23);
            this.btn_reverse_refund.TabIndex = 43;
            this.btn_reverse_refund.Text = "Reverse A Refund";
            this.btn_reverse_refund.UseVisualStyleBackColor = true;
            this.btn_reverse_refund.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_refund
            // 
            this.btn_refund.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refund.Location = new System.Drawing.Point(484, 386);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(116, 23);
            this.btn_refund.TabIndex = 42;
            this.btn_refund.Text = "Refund";
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reverse_receipt
            // 
            this.btn_reverse_receipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_reverse_receipt.Location = new System.Drawing.Point(362, 386);
            this.btn_reverse_receipt.Name = "btn_reverse_receipt";
            this.btn_reverse_receipt.Size = new System.Drawing.Size(116, 23);
            this.btn_reverse_receipt.TabIndex = 41;
            this.btn_reverse_receipt.Text = "Reverse A Receipt";
            this.btn_reverse_receipt.UseVisualStyleBackColor = true;
            this.btn_reverse_receipt.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_receipt.Location = new System.Drawing.Point(240, 386);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(116, 23);
            this.btn_receipt.TabIndex = 40;
            this.btn_receipt.Text = "Receipt";
            this.btn_receipt.UseVisualStyleBackColor = true;
            this.btn_receipt.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reverse_charge
            // 
            this.btn_reverse_charge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_reverse_charge.Location = new System.Drawing.Point(118, 386);
            this.btn_reverse_charge.Name = "btn_reverse_charge";
            this.btn_reverse_charge.Size = new System.Drawing.Size(116, 23);
            this.btn_reverse_charge.TabIndex = 30;
            this.btn_reverse_charge.Text = "Reverse A Charge";
            this.btn_reverse_charge.UseVisualStyleBackColor = true;
            this.btn_reverse_charge.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_charge
            // 
            this.btn_add_charge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add_charge.Location = new System.Drawing.Point(6, 386);
            this.btn_add_charge.Name = "btn_add_charge";
            this.btn_add_charge.Size = new System.Drawing.Size(110, 23);
            this.btn_add_charge.TabIndex = 20;
            this.btn_add_charge.Text = "Add Extra Charge";
            this.btn_add_charge.UseVisualStyleBackColor = true;
            this.btn_add_charge.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dg_transactions
            // 
            this.dg_transactions.AllowUserToAddRows = false;
            this.dg_transactions.AllowUserToDeleteRows = false;
            this.dg_transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_transactions.AutoGenerateColumns = false;
            this.dg_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRSDATEDataGridViewTextBoxColumn,
            this.tEMPNARRDataGridViewTextBoxColumn,
            this.tAMOUNTDataGridViewTextBoxColumn,
            this.tDESCRDataGridViewTextBoxColumn});
            this.dg_transactions.DataSource = this.bs_transactions;
            this.dg_transactions.Location = new System.Drawing.Point(5, 3);
            this.dg_transactions.MultiSelect = false;
            this.dg_transactions.Name = "dg_transactions";
            this.dg_transactions.ReadOnly = true;
            this.dg_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_transactions.Size = new System.Drawing.Size(842, 377);
            this.dg_transactions.TabIndex = 10;
            // 
            // tRSDATEDataGridViewTextBoxColumn
            // 
            this.tRSDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tRSDATEDataGridViewTextBoxColumn.DataPropertyName = "TRS_DATE";
            this.tRSDATEDataGridViewTextBoxColumn.HeaderText = "Transaction Date";
            this.tRSDATEDataGridViewTextBoxColumn.Name = "tRSDATEDataGridViewTextBoxColumn";
            this.tRSDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRSDATEDataGridViewTextBoxColumn.Width = 105;
            // 
            // tEMPNARRDataGridViewTextBoxColumn
            // 
            this.tEMPNARRDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tEMPNARRDataGridViewTextBoxColumn.DataPropertyName = "TEMPNARR";
            this.tEMPNARRDataGridViewTextBoxColumn.HeaderText = "Narrative";
            this.tEMPNARRDataGridViewTextBoxColumn.Name = "tEMPNARRDataGridViewTextBoxColumn";
            this.tEMPNARRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAMOUNTDataGridViewTextBoxColumn
            // 
            this.tAMOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TAMOUNT";
            this.tAMOUNTDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.tAMOUNTDataGridViewTextBoxColumn.Name = "tAMOUNTDataGridViewTextBoxColumn";
            this.tAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAMOUNTDataGridViewTextBoxColumn.Width = 68;
            // 
            // tDESCRDataGridViewTextBoxColumn
            // 
            this.tDESCRDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tDESCRDataGridViewTextBoxColumn.DataPropertyName = "TDESCR";
            this.tDESCRDataGridViewTextBoxColumn.HeaderText = "Description";
            this.tDESCRDataGridViewTextBoxColumn.Name = "tDESCRDataGridViewTextBoxColumn";
            this.tDESCRDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDESCRDataGridViewTextBoxColumn.Width = 85;
            // 
            // txt_narr
            // 
            this.txt_narr.Location = new System.Drawing.Point(406, 12);
            this.txt_narr.Name = "txt_narr";
            this.txt_narr.Size = new System.Drawing.Size(438, 20);
            this.txt_narr.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 184;
            this.label2.Text = "Narrative:";
            // 
            // txt_receipt
            // 
            this.txt_receipt.Location = new System.Drawing.Point(222, 12);
            this.txt_receipt.Name = "txt_receipt";
            this.txt_receipt.Size = new System.Drawing.Size(119, 20);
            this.txt_receipt.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 182;
            this.label1.Text = "Receipt:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(61, 12);
            this.txt_amount.Mask = "000000000000000000";
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(102, 20);
            this.txt_amount.TabIndex = 181;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Amount:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(428, 39);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 180;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(347, 39);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 170;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(860, 507);
            this.Controls.Add(this.sc_transactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_transactions)).EndInit();
            this.sc_transactions.Panel1.ResumeLayout(false);
            this.sc_transactions.Panel2.ResumeLayout(false);
            this.sc_transactions.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_transactions)).EndInit();
            this.sc_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_transactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_transactions;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Button btn_reverse_charge;
        private System.Windows.Forms.Button btn_add_charge;
        private CustomDataGridView dg_transactions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reverse_refund;
        private System.Windows.Forms.Button btn_refund;
        private System.Windows.Forms.Button btn_reverse_receipt;
        private System.Windows.Forms.Button btn_write_off;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRSDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPNARRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDESCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_transactions;
        private System.Windows.Forms.TextBox txt_narr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_amount;
    }
}