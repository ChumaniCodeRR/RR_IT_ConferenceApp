namespace ConferenceSys.ConferenceAdmin.ConferenceUpdate
{
    partial class FullConferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullConferences));
            this.sc_conferences = new System.Windows.Forms.SplitContainer();
            this.btn_print = new System.Windows.Forms.Button();
            this.dg_conferences = new CustomDataGridView();
            this.cn_conference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_typedescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_full = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dte_conf_dte = new System.Windows.Forms.DateTimePicker();
            this.txt_conf_code = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.bs_types = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_conf_descrip = new System.Windows.Forms.TextBox();
            this.btn_search_conf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc_conferences)).BeginInit();
            this.sc_conferences.Panel1.SuspendLayout();
            this.sc_conferences.Panel2.SuspendLayout();
            this.sc_conferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_conferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_types)).BeginInit();
            this.SuspendLayout();
            // 
            // sc_conferences
            // 
            this.sc_conferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_conferences.Location = new System.Drawing.Point(0, 0);
            this.sc_conferences.Name = "sc_conferences";
            this.sc_conferences.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_conferences.Panel1
            // 
            this.sc_conferences.Panel1.Controls.Add(this.btn_print);
            this.sc_conferences.Panel1.Controls.Add(this.dg_conferences);
            this.sc_conferences.Panel1.Controls.Add(this.btn_add);
            this.sc_conferences.Panel1.Controls.Add(this.btn_delete);
            // 
            // sc_conferences.Panel2
            // 
            this.sc_conferences.Panel2.Controls.Add(this.btn_save);
            this.sc_conferences.Panel2.Controls.Add(this.btn_cancel);
            this.sc_conferences.Panel2.Controls.Add(this.label2);
            this.sc_conferences.Panel2.Controls.Add(this.dte_conf_dte);
            this.sc_conferences.Panel2.Controls.Add(this.txt_conf_code);
            this.sc_conferences.Panel2.Controls.Add(this.cb_type);
            this.sc_conferences.Panel2.Controls.Add(this.label1);
            this.sc_conferences.Panel2.Controls.Add(this.lbl1);
            this.sc_conferences.Panel2.Controls.Add(this.txt_conf_descrip);
            this.sc_conferences.Panel2.Controls.Add(this.btn_search_conf);
            this.sc_conferences.Size = new System.Drawing.Size(799, 531);
            this.sc_conferences.SplitterDistance = 431;
            this.sc_conferences.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.Location = new System.Drawing.Point(493, 402);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(176, 23);
            this.btn_print.TabIndex = 85;
            this.btn_print.Text = "Print Unbooked Reservations";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dg_conferences
            // 
            this.dg_conferences.AllowUserToAddRows = false;
            this.dg_conferences.AllowUserToDeleteRows = false;
            this.dg_conferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_conferences.AutoGenerateColumns = false;
            this.dg_conferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_conferences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_conference,
            this.cn_typedescrip,
            this.cn_confdte,
            this.cn_ccode,
            this.cn_tcode});
            this.dg_conferences.DataSource = this.bs_full;
            this.dg_conferences.Location = new System.Drawing.Point(12, 15);
            this.dg_conferences.MultiSelect = false;
            this.dg_conferences.Name = "dg_conferences";
            this.dg_conferences.ReadOnly = true;
            this.dg_conferences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_conferences.Size = new System.Drawing.Size(775, 381);
            this.dg_conferences.TabIndex = 82;
            // 
            // cn_conference
            // 
            this.cn_conference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_conference.DataPropertyName = "conference";
            this.cn_conference.HeaderText = "Conference";
            this.cn_conference.Name = "cn_conference";
            this.cn_conference.ReadOnly = true;
            // 
            // cn_typedescrip
            // 
            this.cn_typedescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_typedescrip.DataPropertyName = "type_descrip";
            this.cn_typedescrip.HeaderText = "Type";
            this.cn_typedescrip.Name = "cn_typedescrip";
            this.cn_typedescrip.ReadOnly = true;
            // 
            // cn_confdte
            // 
            this.cn_confdte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_confdte.DataPropertyName = "conf_dte";
            this.cn_confdte.HeaderText = "Date";
            this.cn_confdte.Name = "cn_confdte";
            this.cn_confdte.ReadOnly = true;
            this.cn_confdte.Width = 55;
            // 
            // cn_ccode
            // 
            this.cn_ccode.DataPropertyName = "ccode";
            this.cn_ccode.HeaderText = "ccode";
            this.cn_ccode.Name = "cn_ccode";
            this.cn_ccode.ReadOnly = true;
            this.cn_ccode.Visible = false;
            // 
            // cn_tcode
            // 
            this.cn_tcode.DataPropertyName = "tcode";
            this.cn_tcode.HeaderText = "tcode";
            this.cn_tcode.Name = "cn_tcode";
            this.cn_tcode.ReadOnly = true;
            this.cn_tcode.Visible = false;
            // 
            // bs_full
            // 
            this.bs_full.DataSource = typeof(NS_ConfAdmin.StrongTypesNS.ds_conf_fullDataSet.tt_conf_fullDataTable);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Location = new System.Drawing.Point(129, 402);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 23);
            this.btn_add.TabIndex = 83;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(311, 402);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(176, 23);
            this.btn_delete.TabIndex = 84;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(321, 67);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 85;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(402, 67);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 86;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date:";
            // 
            // dte_conf_dte
            // 
            this.dte_conf_dte.Location = new System.Drawing.Point(319, 41);
            this.dte_conf_dte.Name = "dte_conf_dte";
            this.dte_conf_dte.Size = new System.Drawing.Size(200, 20);
            this.dte_conf_dte.TabIndex = 48;
            // 
            // txt_conf_code
            // 
            this.txt_conf_code.Location = new System.Drawing.Point(83, 15);
            this.txt_conf_code.Name = "txt_conf_code";
            this.txt_conf_code.ReadOnly = true;
            this.txt_conf_code.Size = new System.Drawing.Size(129, 20);
            this.txt_conf_code.TabIndex = 47;
            // 
            // cb_type
            // 
            this.cb_type.DataSource = this.bs_types;
            this.cb_type.DisplayMember = "descrip";
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(609, 15);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(178, 21);
            this.cb_type.TabIndex = 46;
            this.cb_type.ValueMember = "tcode";
            // 
            // bs_types
            // 
            this.bs_types.DataSource = typeof(NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_conf_typeDataTable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Type:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 44;
            this.lbl1.Text = "Conference:";
            // 
            // txt_conf_descrip
            // 
            this.txt_conf_descrip.Location = new System.Drawing.Point(250, 15);
            this.txt_conf_descrip.Name = "txt_conf_descrip";
            this.txt_conf_descrip.ReadOnly = true;
            this.txt_conf_descrip.Size = new System.Drawing.Size(313, 20);
            this.txt_conf_descrip.TabIndex = 43;
            // 
            // btn_search_conf
            // 
            this.btn_search_conf.Location = new System.Drawing.Point(218, 13);
            this.btn_search_conf.Name = "btn_search_conf";
            this.btn_search_conf.Size = new System.Drawing.Size(26, 23);
            this.btn_search_conf.TabIndex = 42;
            this.btn_search_conf.Text = "...";
            this.btn_search_conf.UseVisualStyleBackColor = true;
            this.btn_search_conf.Click += new System.EventHandler(this.btn_search_conf_Click);
            // 
            // FullConferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 531);
            this.Controls.Add(this.sc_conferences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullConferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Conferences List";
            this.Load += new System.EventHandler(this.FullConferences_Load);
            this.sc_conferences.Panel1.ResumeLayout(false);
            this.sc_conferences.Panel2.ResumeLayout(false);
            this.sc_conferences.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_conferences)).EndInit();
            this.sc_conferences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_conferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_types)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn cn_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_descrip;
        private System.Windows.Forms.SplitContainer sc_conferences;
        private CustomDataGridView dg_conferences;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_conf_descrip;
        private System.Windows.Forms.Button btn_search_conf;
        private System.Windows.Forms.TextBox txt_conf_code;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dte_conf_dte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conference;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_typedescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tcode;
        private System.Windows.Forms.BindingSource bs_full;
        private System.Windows.Forms.BindingSource bs_types;
        private System.Windows.Forms.Button btn_print;
    }
}