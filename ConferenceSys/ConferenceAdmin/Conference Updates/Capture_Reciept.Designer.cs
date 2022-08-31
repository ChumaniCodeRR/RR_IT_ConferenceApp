namespace ConferenceSys.ConferenceAdmin.Conference_Updates
{
    partial class Capture_Reciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capture_Reciept));
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_receipt = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_reciepts = new System.Windows.Forms.Panel();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.dgv_folios = new CustomDataGridView();
            this.c_main_folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMESTRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_ttreciept = new System.Windows.Forms.BindingSource(this.components);
            this.ds_recieptDataSet = new NS_ConfAdmin.StrongTypesNS.ds_recieptDataSet();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_folio_amt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search_folio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_reciepts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ttreciept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_recieptDataSet)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(354, 10);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(92, 20);
            this.txt_amount.TabIndex = 10;
            // 
            // txt_receipt
            // 
            this.txt_receipt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_receipt.Location = new System.Drawing.Point(153, 10);
            this.txt_receipt.Name = "txt_receipt";
            this.txt_receipt.Size = new System.Drawing.Size(132, 20);
            this.txt_receipt.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(99, 13);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 13);
            this.label36.TabIndex = 230;
            this.label36.Text = "Receipt:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancel.Location = new System.Drawing.Point(275, 41);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 233;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_proceed.Location = new System.Drawing.Point(194, 41);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 232;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(291, 13);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 13);
            this.label37.TabIndex = 229;
            this.label37.Text = "Amount: R";
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Location = new System.Drawing.Point(273, 300);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 40;
            this.btn_next.Text = "Cancel";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Location = new System.Drawing.Point(192, 300);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_reciepts
            // 
            this.pnl_reciepts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_reciepts.Controls.Add(this.lbl_remaining);
            this.pnl_reciepts.Controls.Add(this.dgv_folios);
            this.pnl_reciepts.Controls.Add(this.btn_remove);
            this.pnl_reciepts.Controls.Add(this.btn_add);
            this.pnl_reciepts.Controls.Add(this.txt_folio_amt);
            this.pnl_reciepts.Controls.Add(this.label2);
            this.pnl_reciepts.Controls.Add(this.btn_search_folio);
            this.pnl_reciepts.Controls.Add(this.label1);
            this.pnl_reciepts.Controls.Add(this.txt_folio);
            this.pnl_reciepts.Controls.Add(this.btn_next);
            this.pnl_reciepts.Controls.Add(this.btn_save);
            this.pnl_reciepts.Enabled = false;
            this.pnl_reciepts.Location = new System.Drawing.Point(-1, 72);
            this.pnl_reciepts.Name = "pnl_reciepts";
            this.pnl_reciepts.Size = new System.Drawing.Size(544, 339);
            this.pnl_reciepts.TabIndex = 237;
            this.pnl_reciepts.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.AutoSize = true;
            this.lbl_remaining.Location = new System.Drawing.Point(326, 270);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(87, 13);
            this.lbl_remaining.TabIndex = 245;
            this.lbl_remaining.Text = "Total Remaining:";
            // 
            // dgv_folios
            // 
            this.dgv_folios.AllowUserToAddRows = false;
            this.dgv_folios.AllowUserToDeleteRows = false;
            this.dgv_folios.AutoGenerateColumns = false;
            this.dgv_folios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_folios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_main_folio,
            this.nAMESTRDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgv_folios.DataSource = this.ds_ttreciept;
            this.dgv_folios.Location = new System.Drawing.Point(11, 69);
            this.dgv_folios.Name = "dgv_folios";
            this.dgv_folios.ReadOnly = true;
            this.dgv_folios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_folios.Size = new System.Drawing.Size(519, 198);
            this.dgv_folios.TabIndex = 244;
            // 
            // c_main_folio
            // 
            this.c_main_folio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.c_main_folio.DataPropertyName = "parentfolio";
            this.c_main_folio.HeaderText = "Main Folio";
            this.c_main_folio.Name = "c_main_folio";
            this.c_main_folio.ReadOnly = true;
            this.c_main_folio.Width = 74;
            // 
            // nAMESTRDataGridViewTextBoxColumn
            // 
            this.nAMESTRDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMESTRDataGridViewTextBoxColumn.DataPropertyName = "NAMESTR";
            this.nAMESTRDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMESTRDataGridViewTextBoxColumn.Name = "nAMESTRDataGridViewTextBoxColumn";
            this.nAMESTRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Reciept Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 99;
            // 
            // ds_ttreciept
            // 
            this.ds_ttreciept.DataMember = "tt_multi_reciept";
            this.ds_ttreciept.DataSource = this.ds_recieptDataSet;
            // 
            // ds_recieptDataSet
            // 
            this.ds_recieptDataSet.DataSetName = "ds_recieptDataSet";
            this.ds_recieptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_remove.Location = new System.Drawing.Point(273, 40);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 30;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.Location = new System.Drawing.Point(192, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_folio_amt
            // 
            this.txt_folio_amt.Location = new System.Drawing.Point(350, 14);
            this.txt_folio_amt.Name = "txt_folio_amt";
            this.txt_folio_amt.Size = new System.Drawing.Size(92, 20);
            this.txt_folio_amt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 240;
            this.label2.Text = "Amount: R";
            // 
            // btn_search_folio
            // 
            this.btn_search_folio.Location = new System.Drawing.Point(258, 11);
            this.btn_search_folio.Name = "btn_search_folio";
            this.btn_search_folio.Size = new System.Drawing.Size(26, 23);
            this.btn_search_folio.TabIndex = 239;
            this.btn_search_folio.Text = "...";
            this.btn_search_folio.UseVisualStyleBackColor = true;
            this.btn_search_folio.Click += new System.EventHandler(this.btn_search_folio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 238;
            this.label1.Text = "Main Folio:";
            // 
            // txt_folio
            // 
            this.txt_folio.Location = new System.Drawing.Point(152, 14);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(100, 20);
            this.txt_folio.TabIndex = 15;
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.txt_amount);
            this.pnl_header.Controls.Add(this.txt_receipt);
            this.pnl_header.Controls.Add(this.label36);
            this.pnl_header.Controls.Add(this.btn_cancel);
            this.pnl_header.Controls.Add(this.btn_proceed);
            this.pnl_header.Controls.Add(this.label37);
            this.pnl_header.Location = new System.Drawing.Point(-1, 2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(544, 70);
            this.pnl_header.TabIndex = 238;
            // 
            // Capture_Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(543, 409);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_reciepts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(559, 443);
            this.MinimumSize = new System.Drawing.Size(559, 443);
            this.Name = "Capture_Reciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reciept Management";
            this.Load += new System.EventHandler(this.Capture_Reciept_Load);
            this.pnl_reciepts.ResumeLayout(false);
            this.pnl_reciepts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ttreciept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_recieptDataSet)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_receipt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_reciepts;
        private System.Windows.Forms.Button btn_search_folio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_folio;
        private CustomDataGridView dgv_folios;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_folio_amt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.BindingSource ds_ttreciept;
        private NS_ConfAdmin.StrongTypesNS.ds_recieptDataSet ds_recieptDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_main_folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMESTRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_remaining;
    }
}