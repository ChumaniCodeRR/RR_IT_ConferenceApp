﻿namespace ConferenceSys.ConferenceWardens
{
    partial class QuerySurnName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuerySurnName));
            this.txt_MainFolio = new System.Windows.Forms.TextBox();
            this.bs_hall = new System.Windows.Forms.BindingSource(this.components);
            this.bs_building = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.bs_res = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.rb_surn = new System.Windows.Forms.RadioButton();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search_groups = new System.Windows.Forms.Button();
            this.txt_grp_descrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_yr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MainFolio
            // 
            this.txt_MainFolio.Location = new System.Drawing.Point(157, 38);
            this.txt_MainFolio.Name = "txt_MainFolio";
            this.txt_MainFolio.Size = new System.Drawing.Size(55, 20);
            this.txt_MainFolio.TabIndex = 3;
            this.txt_MainFolio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_group_KeyDown);
            this.txt_MainFolio.Leave += new System.EventHandler(this.txt_group_Leave);
            // 
            // bs_hall
            // 
            this.bs_hall.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_hallDataTable);
            // 
            // bs_building
            // 
            this.bs_building.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.TT_CONF_BUILDINGDataTable);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search By:";
            // 
            // bs_res
            // 
            this.bs_res.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_resDataTable);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Group(Leave Blank For All):";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(248, 91);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 23);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // rb_surn
            // 
            this.rb_surn.AutoSize = true;
            this.rb_surn.Checked = true;
            this.rb_surn.Location = new System.Drawing.Point(157, 13);
            this.rb_surn.Name = "rb_surn";
            this.rb_surn.Size = new System.Drawing.Size(67, 17);
            this.rb_surn.TabIndex = 33;
            this.rb_surn.TabStop = true;
            this.rb_surn.Text = "Surname";
            this.rb_surn.UseVisualStyleBackColor = true;
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Location = new System.Drawing.Point(226, 13);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(53, 17);
            this.rb_name.TabIndex = 34;
            this.rb_name.Text = "Name";
            this.rb_name.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(285, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(320, 20);
            this.txt_search.TabIndex = 35;
            // 
            // btn_search_groups
            // 
            this.btn_search_groups.Location = new System.Drawing.Point(216, 37);
            this.btn_search_groups.Name = "btn_search_groups";
            this.btn_search_groups.Size = new System.Drawing.Size(26, 23);
            this.btn_search_groups.TabIndex = 37;
            this.btn_search_groups.Text = "...";
            this.btn_search_groups.UseVisualStyleBackColor = true;
            this.btn_search_groups.Click += new System.EventHandler(this.btn_search_groups_Click);
            // 
            // txt_grp_descrip
            // 
            this.txt_grp_descrip.Location = new System.Drawing.Point(248, 38);
            this.txt_grp_descrip.Name = "txt_grp_descrip";
            this.txt_grp_descrip.ReadOnly = true;
            this.txt_grp_descrip.Size = new System.Drawing.Size(357, 20);
            this.txt_grp_descrip.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Year:";
            // 
            // cb_yr
            // 
            this.cb_yr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yr.FormattingEnabled = true;
            this.cb_yr.Location = new System.Drawing.Point(157, 64);
            this.cb_yr.Name = "cb_yr";
            this.cb_yr.Size = new System.Drawing.Size(55, 21);
            this.cb_yr.TabIndex = 39;
            // 
            // QuerySurnName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(618, 122);
            this.Controls.Add(this.cb_yr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search_groups);
            this.Controls.Add(this.txt_grp_descrip);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.rb_surn);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MainFolio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuerySurnName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query By Surname/Name/Group";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MainFolio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.BindingSource bs_hall;
        private System.Windows.Forms.BindingSource bs_res;
        private System.Windows.Forms.BindingSource bs_building;
        private System.Windows.Forms.RadioButton rb_surn;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search_groups;
        private System.Windows.Forms.TextBox txt_grp_descrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_yr;
    }
}