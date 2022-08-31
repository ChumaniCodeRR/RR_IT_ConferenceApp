﻿namespace ConferenceSys.ConferenceWardens
{
    partial class QueryResRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryResRoom));
            this.txt_room = new System.Windows.Forms.TextBox();
            this.nlb_from = new ProjectMentor.Windows.Controls.NullableDateTimePicker();
            this.nlb_to = new ProjectMentor.Windows.Controls.NullableDateTimePicker();
            this.bs_hall = new System.Windows.Forms.BindingSource(this.components);
            this.cb_buliding = new System.Windows.Forms.ComboBox();
            this.bs_building = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bs_res = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_room
            // 
            this.txt_room.Location = new System.Drawing.Point(193, 65);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(55, 20);
            this.txt_room.TabIndex = 3;
            // 
            // nlb_from
            // 
            this.nlb_from.Location = new System.Drawing.Point(193, 39);
            this.nlb_from.Name = "nlb_from";
            this.nlb_from.Size = new System.Drawing.Size(246, 20);
            this.nlb_from.TabIndex = 4;
            this.nlb_from.Value = new System.DateTime(2013, 6, 19, 10, 11, 54, 374);
            // 
            // nlb_to
            // 
            this.nlb_to.Location = new System.Drawing.Point(477, 39);
            this.nlb_to.Name = "nlb_to";
            this.nlb_to.Size = new System.Drawing.Size(246, 20);
            this.nlb_to.TabIndex = 5;
            this.nlb_to.Value = new System.DateTime(2013, 6, 19, 10, 11, 54, 374);
            // 
            // bs_hall
            // 
            this.bs_hall.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_hallDataTable);
            // 
            // cb_buliding
            // 
            this.cb_buliding.DataSource = this.bs_building;
            this.cb_buliding.DisplayMember = "building_name";
            this.cb_buliding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buliding.FormattingEnabled = true;
            this.cb_buliding.Location = new System.Drawing.Point(193, 12);
            this.cb_buliding.Name = "cb_buliding";
            this.cb_buliding.Size = new System.Drawing.Size(246, 21);
            this.cb_buliding.TabIndex = 7;
            this.cb_buliding.ValueMember = "building";
            // 
            // bs_building
            // 
            this.bs_building.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.TT_CONF_BUILDINGDataTable);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Building:";
            // 
            // bs_res
            // 
            this.bs_res.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_resDataTable);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room Number(Leave Blank For All):";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(302, 94);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 23);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // QueryResRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 123);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_buliding);
            this.Controls.Add(this.nlb_to);
            this.Controls.Add(this.nlb_from);
            this.Controls.Add(this.txt_room);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryResRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query By Residence/Room";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_hall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_room;
        private ProjectMentor.Windows.Controls.NullableDateTimePicker nlb_from;
        private ProjectMentor.Windows.Controls.NullableDateTimePicker nlb_to;
        private System.Windows.Forms.ComboBox cb_buliding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.BindingSource bs_hall;
        private System.Windows.Forms.BindingSource bs_res;
        private System.Windows.Forms.BindingSource bs_building;
    }
}