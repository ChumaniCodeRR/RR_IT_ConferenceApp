﻿namespace ConferenceSys.ConferenceWardens
{
    partial class SearchGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGroups));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_groups = new CustomDataGridView();
            this.cn_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_grp_descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_groups = new System.Windows.Forms.BindingSource(this.components);
            this.txt_reference = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Group Name:";
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
            // dg_groups
            // 
            this.dg_groups.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_groups.AllowUserToAddRows = false;
            this.dg_groups.AllowUserToDeleteRows = false;
            this.dg_groups.AutoGenerateColumns = false;
            this.dg_groups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_group,
            this.cn_grp_descrip});
            this.dg_groups.DataSource = this.bs_groups;
            this.dg_groups.Location = new System.Drawing.Point(6, 39);
            this.dg_groups.MultiSelect = false;
            this.dg_groups.Name = "dg_groups";
            this.dg_groups.ReadOnly = true;
            this.dg_groups.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_groups.Size = new System.Drawing.Size(678, 319);
            this.dg_groups.TabIndex = 64;
            this.dg_groups.DoubleClick += new System.EventHandler(this.dg_folios_DoubleClick);
            // 
            // cn_group
            // 
            this.cn_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_group.DataPropertyName = "gcode";
            this.cn_group.HeaderText = "Group";
            this.cn_group.Name = "cn_group";
            this.cn_group.ReadOnly = true;
            this.cn_group.Width = 61;
            // 
            // cn_grp_descrip
            // 
            this.cn_grp_descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_grp_descrip.DataPropertyName = "group_name";
            this.cn_grp_descrip.HeaderText = "Description";
            this.cn_grp_descrip.Name = "cn_grp_descrip";
            this.cn_grp_descrip.ReadOnly = true;
            // 
            // bs_groups
            // 
            this.bs_groups.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conference_lookupDataSet.tt_groupDataTable);
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(154, 12);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(229, 20);
            this.txt_reference.TabIndex = 68;
            // 
            // SearchGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(695, 390);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_groups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Groups";
            this.Load += new System.EventHandler(this.SearchFolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_group_name;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dg_groups;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_grp_descrip;
        private System.Windows.Forms.BindingSource bs_groups;
        private System.Windows.Forms.TextBox txt_reference;
    }
}