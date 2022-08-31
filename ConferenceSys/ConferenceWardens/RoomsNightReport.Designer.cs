﻿namespace ConferenceSys.ConferenceWardens
{
    partial class RoomsNightReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsNightReport));
            this.bs_hall = new System.Windows.Forms.BindingSource(this.components);
            this.bs_building = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.bs_res = new System.Windows.Forms.BindingSource(this.components);
            this.btn_print = new System.Windows.Forms.Button();
            this.nlb_from = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_conf_descrip = new System.Windows.Forms.TextBox();
            this.btn_search_conf = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_conf_code = new System.Windows.Forms.TextBox();
            this.nlb_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_res = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_hall = new System.Windows.Forms.ComboBox();
            this.ck_all = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_hall
            // 
            this.bs_hall.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_hallDataTable);
            // 
            // bs_building
            // 
            this.bs_building.DataSource = typeof(NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_conf_buildDataTable);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date From:";
            // 
            // bs_res
            // 
            this.bs_res.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_resDataTable);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(234, 131);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 23);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Proceed";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // nlb_from
            // 
            this.nlb_from.Location = new System.Drawing.Point(148, 89);
            this.nlb_from.Name = "nlb_from";
            this.nlb_from.Size = new System.Drawing.Size(200, 20);
            this.nlb_from.TabIndex = 35;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(370, 131);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 23);
            this.btn_cancel.TabIndex = 37;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_conf_descrip
            // 
            this.txt_conf_descrip.Location = new System.Drawing.Point(386, 35);
            this.txt_conf_descrip.Name = "txt_conf_descrip";
            this.txt_conf_descrip.ReadOnly = true;
            this.txt_conf_descrip.Size = new System.Drawing.Size(294, 20);
            this.txt_conf_descrip.TabIndex = 41;
            // 
            // btn_search_conf
            // 
            this.btn_search_conf.Location = new System.Drawing.Point(354, 33);
            this.btn_search_conf.Name = "btn_search_conf";
            this.btn_search_conf.Size = new System.Drawing.Size(26, 23);
            this.btn_search_conf.TabIndex = 40;
            this.btn_search_conf.Text = "...";
            this.btn_search_conf.UseVisualStyleBackColor = true;
            this.btn_search_conf.Click += new System.EventHandler(this.btn_search_conf_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Conference Code:";
            // 
            // txt_conf_code
            // 
            this.txt_conf_code.Location = new System.Drawing.Point(191, 35);
            this.txt_conf_code.Name = "txt_conf_code";
            this.txt_conf_code.ReadOnly = true;
            this.txt_conf_code.Size = new System.Drawing.Size(157, 20);
            this.txt_conf_code.TabIndex = 38;
            this.txt_conf_code.TextChanged += new System.EventHandler(this.txt_conf_code_TextChanged);
            // 
            // nlb_to
            // 
            this.nlb_to.Location = new System.Drawing.Point(391, 89);
            this.nlb_to.Name = "nlb_to";
            this.nlb_to.Size = new System.Drawing.Size(200, 20);
            this.nlb_to.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Until:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Residence:";
            // 
            // cb_res
            // 
            this.cb_res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_res.Enabled = false;
            this.cb_res.FormattingEnabled = true;
            this.cb_res.Location = new System.Drawing.Point(434, 62);
            this.cb_res.Name = "cb_res";
            this.cb_res.Size = new System.Drawing.Size(246, 21);
            this.cb_res.TabIndex = 48;
            this.cb_res.SelectedIndexChanged += new System.EventHandler(this.cb_res_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hall:";
            // 
            // cb_hall
            // 
            this.cb_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hall.FormattingEnabled = true;
            this.cb_hall.Location = new System.Drawing.Point(148, 62);
            this.cb_hall.Name = "cb_hall";
            this.cb_hall.Size = new System.Drawing.Size(213, 21);
            this.cb_hall.TabIndex = 46;
            this.cb_hall.SelectedIndexChanged += new System.EventHandler(this.cb_hall_SelectedIndexChanged);
            // 
            // ck_all
            // 
            this.ck_all.AutoSize = true;
            this.ck_all.Location = new System.Drawing.Point(148, 37);
            this.ck_all.Name = "ck_all";
            this.ck_all.Size = new System.Drawing.Size(37, 17);
            this.ck_all.TabIndex = 50;
            this.ck_all.Text = "All";
            this.ck_all.UseVisualStyleBackColor = true;
            this.ck_all.CheckedChanged += new System.EventHandler(this.ck_all_CheckedChanged);
            // 
            // RoomsNightReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(728, 161);
            this.Controls.Add(this.ck_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_res);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_hall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nlb_to);
            this.Controls.Add(this.txt_conf_descrip);
            this.Controls.Add(this.btn_search_conf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_conf_code);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.nlb_from);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomsNightReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Nights Report";
            this.Load += new System.EventHandler(this.RoomsNightReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.BindingSource bs_hall;
        private System.Windows.Forms.BindingSource bs_res;
        private System.Windows.Forms.BindingSource bs_building;
        private System.Windows.Forms.DateTimePicker nlb_from;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_conf_descrip;
        private System.Windows.Forms.Button btn_search_conf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_conf_code;
        private System.Windows.Forms.DateTimePicker nlb_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_res;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_hall;
        private System.Windows.Forms.CheckBox ck_all;
    }
}