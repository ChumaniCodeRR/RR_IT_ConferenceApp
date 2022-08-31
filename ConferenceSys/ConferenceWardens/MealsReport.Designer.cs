﻿namespace ConferenceSys.ConferenceWardens
{
    partial class MealsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealsReport));
            this.cb_hall = new System.Windows.Forms.ComboBox();
            this.cb_buliding = new System.Windows.Forms.ComboBox();
            this.txt_conf_code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_res = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_search_conf = new System.Windows.Forms.Button();
            this.txt_conf_descrip = new System.Windows.Forms.TextBox();
            this.pnl_changes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_breakfast = new System.Windows.Forms.RadioButton();
            this.rb_lunch = new System.Windows.Forms.RadioButton();
            this.rb_supper = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nlb_tempdte = new ProjectMentor.Windows.Controls.NullableDateTimePicker();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.pnl_changes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_hall
            // 
            this.cb_hall.DisplayMember = "hall";
            this.cb_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hall.FormattingEnabled = true;
            this.cb_hall.Location = new System.Drawing.Point(366, 39);
            this.cb_hall.Name = "cb_hall";
            this.cb_hall.Size = new System.Drawing.Size(222, 21);
            this.cb_hall.TabIndex = 6;
            this.cb_hall.ValueMember = "hall";         
            // 
            // cb_buliding
            // 
            this.cb_buliding.DisplayMember = "building";
            this.cb_buliding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buliding.FormattingEnabled = true;
            this.cb_buliding.Location = new System.Drawing.Point(430, 67);
            this.cb_buliding.Name = "cb_buliding";
            this.cb_buliding.Size = new System.Drawing.Size(277, 21);
            this.cb_buliding.TabIndex = 7;
            this.cb_buliding.ValueMember = "building";
            this.cb_buliding.Visible = false;
            // 
            // txt_conf_code
            // 
            this.txt_conf_code.Location = new System.Drawing.Point(111, 11);
            this.txt_conf_code.Name = "txt_conf_code";
            this.txt_conf_code.ReadOnly = true;
            this.txt_conf_code.Size = new System.Drawing.Size(129, 20);
            this.txt_conf_code.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Building:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hall:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Conference Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Residence:";
            this.label2.Visible = false;
            // 
            // cb_res
            // 
            this.cb_res.DisplayMember = "res";
            this.cb_res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_res.FormattingEnabled = true;
            this.cb_res.Location = new System.Drawing.Point(83, 64);
            this.cb_res.Name = "cb_res";
            this.cb_res.Size = new System.Drawing.Size(277, 21);
            this.cb_res.TabIndex = 28;
            this.cb_res.ValueMember = "res";
            this.cb_res.Visible = false;
            this.cb_res.SelectedIndexChanged += new System.EventHandler(this.cb_res_SelectedIndexChanged);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(294, 134);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 23);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Print Register";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_search_conf
            // 
            this.btn_search_conf.Location = new System.Drawing.Point(247, 9);
            this.btn_search_conf.Name = "btn_search_conf";
            this.btn_search_conf.Size = new System.Drawing.Size(26, 23);
            this.btn_search_conf.TabIndex = 36;
            this.btn_search_conf.Text = "...";
            this.btn_search_conf.UseVisualStyleBackColor = true;
            this.btn_search_conf.Click += new System.EventHandler(this.btn_search_conf_Click);
            // 
            // txt_conf_descrip
            // 
            this.txt_conf_descrip.Location = new System.Drawing.Point(366, 11);
            this.txt_conf_descrip.Name = "txt_conf_descrip";
            this.txt_conf_descrip.ReadOnly = true;
            this.txt_conf_descrip.Size = new System.Drawing.Size(341, 20);
            this.txt_conf_descrip.TabIndex = 37;
            // 
            // pnl_changes
            // 
            this.pnl_changes.Controls.Add(this.label1);
            this.pnl_changes.Controls.Add(this.rb_all);
            this.pnl_changes.Controls.Add(this.rb_breakfast);
            this.pnl_changes.Controls.Add(this.rb_lunch);
            this.pnl_changes.Controls.Add(this.rb_supper);
            this.pnl_changes.Location = new System.Drawing.Point(2, 94);
            this.pnl_changes.Name = "pnl_changes";
            this.pnl_changes.Size = new System.Drawing.Size(713, 34);
            this.pnl_changes.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Meal Times:";
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(147, 9);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(36, 17);
            this.rb_all.TabIndex = 3;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // rb_breakfast
            // 
            this.rb_breakfast.AutoSize = true;
            this.rb_breakfast.Location = new System.Drawing.Point(189, 9);
            this.rb_breakfast.Name = "rb_breakfast";
            this.rb_breakfast.Size = new System.Drawing.Size(70, 17);
            this.rb_breakfast.TabIndex = 2;
            this.rb_breakfast.Text = "Breakfast";
            this.rb_breakfast.UseVisualStyleBackColor = true;
            // 
            // rb_lunch
            // 
            this.rb_lunch.AutoSize = true;
            this.rb_lunch.Location = new System.Drawing.Point(265, 9);
            this.rb_lunch.Name = "rb_lunch";
            this.rb_lunch.Size = new System.Drawing.Size(55, 17);
            this.rb_lunch.TabIndex = 1;
            this.rb_lunch.Text = "Lunch";
            this.rb_lunch.UseVisualStyleBackColor = true;
            // 
            // rb_supper
            // 
            this.rb_supper.AutoSize = true;
            this.rb_supper.Location = new System.Drawing.Point(326, 9);
            this.rb_supper.Name = "rb_supper";
            this.rb_supper.Size = new System.Drawing.Size(59, 17);
            this.rb_supper.TabIndex = 0;
            this.rb_supper.Text = "Supper";
            this.rb_supper.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Date:";
            // 
            // nlb_tempdte
            // 
            this.nlb_tempdte.Location = new System.Drawing.Point(111, 38);
            this.nlb_tempdte.Name = "nlb_tempdte";
            this.nlb_tempdte.Size = new System.Drawing.Size(162, 20);
            this.nlb_tempdte.TabIndex = 44;
            this.nlb_tempdte.Value = new System.DateTime(2013, 6, 19, 10, 11, 54, 374);
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Location = new System.Drawing.Point(279, 14);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(81, 17);
            this.chk_all.TabIndex = 46;
            this.chk_all.Text = "Click For All";
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // MealsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(719, 162);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nlb_tempdte);
            this.Controls.Add(this.pnl_changes);
            this.Controls.Add(this.txt_conf_descrip);
            this.Controls.Add(this.btn_search_conf);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_res);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_conf_code);
            this.Controls.Add(this.cb_buliding);
            this.Controls.Add(this.cb_hall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MealsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meals Report";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pnl_changes.ResumeLayout(false);
            this.pnl_changes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_hall;
        private System.Windows.Forms.ComboBox cb_buliding;
        private System.Windows.Forms.TextBox txt_conf_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_res;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_search_conf;
        private System.Windows.Forms.TextBox txt_conf_descrip;
        private System.Windows.Forms.Panel pnl_changes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_breakfast;
        private System.Windows.Forms.RadioButton rb_lunch;
        private System.Windows.Forms.RadioButton rb_supper;
        private System.Windows.Forms.Label label4;
        private ProjectMentor.Windows.Controls.NullableDateTimePicker nlb_tempdte;
        private System.Windows.Forms.CheckBox chk_all;
    }
}