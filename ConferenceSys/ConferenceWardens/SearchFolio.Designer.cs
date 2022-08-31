namespace ConferenceSys.ConferenceWardens
{
    partial class SearchFolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFolio));
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bs_folios = new System.Windows.Forms.BindingSource(this.components);
            this.dg_folios = new CustomDataGridView();
            this.cn_folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_folios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_folios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(523, 15);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(80, 13);
            this.lbl_search.TabIndex = 63;
            this.lbl_search.Text = "Click to search:";
            this.lbl_search.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(609, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 62;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Surname:";
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(136, 13);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(178, 20);
            this.txt_surn.TabIndex = 60;
            this.txt_surn.TextChanged += new System.EventHandler(this.txt_surn_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Filter By: ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(603, 364);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 23);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Double click on an item above to select it";
            // 
            // bs_folios
            // 
            this.bs_folios.DataSource = typeof(NS_Conference.StrongTypesNS.ds_bookingsDataSet.tt_reservationDataTable);
            // 
            // dg_folios
            // 
            this.dg_folios.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_folios.AllowUserToAddRows = false;
            this.dg_folios.AllowUserToDeleteRows = false;
            this.dg_folios.AutoGenerateColumns = false;
            this.dg_folios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_folios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_folios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_folio,
            this.cn_surn,
            this.cn_names});
            this.dg_folios.DataSource = this.bs_folios;
            this.dg_folios.Location = new System.Drawing.Point(6, 39);
            this.dg_folios.MultiSelect = false;
            this.dg_folios.Name = "dg_folios";
            this.dg_folios.ReadOnly = true;
            this.dg_folios.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_folios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_folios.Size = new System.Drawing.Size(678, 319);
            this.dg_folios.TabIndex = 64;
            this.dg_folios.DoubleClick += new System.EventHandler(this.dg_folios_DoubleClick);
            // 
            // cn_folio
            // 
            this.cn_folio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_folio.DataPropertyName = "folio";
            this.cn_folio.HeaderText = "Folio";
            this.cn_folio.Name = "cn_folio";
            this.cn_folio.ReadOnly = true;
            this.cn_folio.Width = 54;
            // 
            // cn_surn
            // 
            this.cn_surn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_surn.DataPropertyName = "surn";
            this.cn_surn.HeaderText = "Surname";
            this.cn_surn.Name = "cn_surn";
            this.cn_surn.ReadOnly = true;
            this.cn_surn.Width = 74;
            // 
            // cn_names
            // 
            this.cn_names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_names.DataPropertyName = "names";
            this.cn_names.HeaderText = "Names";
            this.cn_names.Name = "cn_names";
            this.cn_names.ReadOnly = true;
            // 
            // SearchFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(695, 390);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_folios);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_surn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchFolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Folio";
            this.Load += new System.EventHandler(this.SearchFolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_folios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_folios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_surn;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dg_folios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_names;
        private System.Windows.Forms.BindingSource bs_folios;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
    }
}