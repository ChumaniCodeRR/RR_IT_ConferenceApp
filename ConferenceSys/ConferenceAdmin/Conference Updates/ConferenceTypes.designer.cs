namespace ConferenceSys.ConferenceAdmin.ConferenceUpdate
{
    partial class ConferenceTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceTypes));
            this.bs_rates = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_detail = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_end_meal = new System.Windows.Forms.ComboBox();
            this.cb_start_meal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ck_show_web = new System.Windows.Forms.CheckBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_s_rate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_l_rate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_b_rate = new System.Windows.Forms.TextBox();
            this.chk_s_served = new System.Windows.Forms.CheckBox();
            this.chk_l_served = new System.Windows.Forms.CheckBox();
            this.chk_b_served = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_supper = new System.Windows.Forms.CheckBox();
            this.chk_lunch = new System.Windows.Forms.CheckBox();
            this.chk_breakfast = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rates)).BeginInit();
            this.pnl_detail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs_rates
            // 
            this.bs_rates.DataSource = typeof(NS_ConfAdmin.StrongTypesNS.ds_conf_infoDataSet.tt_conf_typeDataTable);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descrip";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "meal_rate1";
            this.dataGridViewTextBoxColumn3.HeaderText = "B/F Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "included1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Breakfast";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "served1";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Served";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "meal_rate2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lunch Rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "included2";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Lunch";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "served2";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Served";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "meal_rate3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Supper Rate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "included3";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Supper ";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "served3";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Served";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ADMIN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "admin_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(118, 269);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(203, 269);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_detail
            // 
            this.pnl_detail.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_detail.Controls.Add(this.groupBox3);
            this.pnl_detail.Controls.Add(this.groupBox2);
            this.pnl_detail.Controls.Add(this.groupBox1);
            this.pnl_detail.Controls.Add(this.btn_cancel);
            this.pnl_detail.Controls.Add(this.btn_save);
            this.pnl_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_detail.Location = new System.Drawing.Point(0, 0);
            this.pnl_detail.Name = "pnl_detail";
            this.pnl_detail.Size = new System.Drawing.Size(408, 306);
            this.pnl_detail.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_end_meal);
            this.groupBox1.Controls.Add(this.cb_start_meal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(10, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 55);
            this.groupBox1.TabIndex = 481;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First/Last Meal";
            // 
            // cb_end_meal
            // 
            this.cb_end_meal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "last_meal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_end_meal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_end_meal.FormattingEnabled = true;
            this.cb_end_meal.Location = new System.Drawing.Point(270, 19);
            this.cb_end_meal.Name = "cb_end_meal";
            this.cb_end_meal.Size = new System.Drawing.Size(79, 21);
            this.cb_end_meal.TabIndex = 465;
            // 
            // cb_start_meal
            // 
            this.cb_start_meal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "first_meal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_start_meal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_start_meal.FormattingEnabled = true;
            this.cb_start_meal.Location = new System.Drawing.Point(75, 19);
            this.cb_start_meal.Name = "cb_start_meal";
            this.cb_start_meal.Size = new System.Drawing.Size(79, 21);
            this.cb_start_meal.TabIndex = 464;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 463;
            this.label8.Text = "First Meal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 462;
            this.label9.Text = "Last Meal:";
            // 
            // ck_show_web
            // 
            this.ck_show_web.AutoSize = true;
            this.ck_show_web.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "show_web", true));
            this.ck_show_web.Location = new System.Drawing.Point(169, 51);
            this.ck_show_web.Name = "ck_show_web";
            this.ck_show_web.Size = new System.Drawing.Size(195, 17);
            this.ck_show_web.TabIndex = 480;
            this.ck_show_web.Text = "Show conference type on the web?";
            this.ck_show_web.UseVisualStyleBackColor = true;
            // 
            // txt_amount
            // 
            this.txt_amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "rate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_amount.Location = new System.Drawing.Point(86, 49);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(77, 20);
            this.txt_amount.TabIndex = 479;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 478;
            this.label1.Text = "Daily Rate:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 477;
            this.label16.Text = "Rate:";
            // 
            // txt_s_rate
            // 
            this.txt_s_rate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "srate", true));
            this.txt_s_rate.Location = new System.Drawing.Point(276, 75);
            this.txt_s_rate.Name = "txt_s_rate";
            this.txt_s_rate.Size = new System.Drawing.Size(68, 20);
            this.txt_s_rate.TabIndex = 476;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 475;
            this.label15.Text = "Rate:";
            // 
            // txt_l_rate
            // 
            this.txt_l_rate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "lrate", true));
            this.txt_l_rate.Location = new System.Drawing.Point(276, 49);
            this.txt_l_rate.Name = "txt_l_rate";
            this.txt_l_rate.Size = new System.Drawing.Size(68, 20);
            this.txt_l_rate.TabIndex = 474;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 473;
            this.label14.Text = "Rate:";
            // 
            // txt_b_rate
            // 
            this.txt_b_rate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "brate", true));
            this.txt_b_rate.Location = new System.Drawing.Point(276, 23);
            this.txt_b_rate.Name = "txt_b_rate";
            this.txt_b_rate.Size = new System.Drawing.Size(68, 20);
            this.txt_b_rate.TabIndex = 472;
            // 
            // chk_s_served
            // 
            this.chk_s_served.AutoSize = true;
            this.chk_s_served.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "supper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_s_served.Location = new System.Drawing.Point(171, 77);
            this.chk_s_served.Name = "chk_s_served";
            this.chk_s_served.Size = new System.Drawing.Size(60, 17);
            this.chk_s_served.TabIndex = 471;
            this.chk_s_served.Text = "Served";
            this.chk_s_served.UseVisualStyleBackColor = true;
            // 
            // chk_l_served
            // 
            this.chk_l_served.AutoSize = true;
            this.chk_l_served.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "lunch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_l_served.Location = new System.Drawing.Point(171, 51);
            this.chk_l_served.Name = "chk_l_served";
            this.chk_l_served.Size = new System.Drawing.Size(60, 17);
            this.chk_l_served.TabIndex = 470;
            this.chk_l_served.Text = "Served";
            this.chk_l_served.UseVisualStyleBackColor = true;
            // 
            // chk_b_served
            // 
            this.chk_b_served.AutoSize = true;
            this.chk_b_served.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "breakfast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_b_served.Location = new System.Drawing.Point(171, 25);
            this.chk_b_served.Name = "chk_b_served";
            this.chk_b_served.Size = new System.Drawing.Size(60, 17);
            this.chk_b_served.TabIndex = 469;
            this.chk_b_served.Text = "Served";
            this.chk_b_served.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 468;
            this.label13.Text = "Lunch:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 467;
            this.label12.Text = "Supper:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 466;
            this.label10.Text = "Breakfast:";
            // 
            // chk_supper
            // 
            this.chk_supper.AutoSize = true;
            this.chk_supper.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "supp_in", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_supper.Location = new System.Drawing.Point(98, 77);
            this.chk_supper.Name = "chk_supper";
            this.chk_supper.Size = new System.Drawing.Size(67, 17);
            this.chk_supper.TabIndex = 461;
            this.chk_supper.Text = "Included";
            this.chk_supper.UseVisualStyleBackColor = true;
            this.chk_supper.CheckedChanged += new System.EventHandler(this.chk_supper_CheckedChanged);
            // 
            // chk_lunch
            // 
            this.chk_lunch.AutoSize = true;
            this.chk_lunch.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "lunch_in", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_lunch.Location = new System.Drawing.Point(98, 51);
            this.chk_lunch.Name = "chk_lunch";
            this.chk_lunch.Size = new System.Drawing.Size(67, 17);
            this.chk_lunch.TabIndex = 460;
            this.chk_lunch.Text = "Included";
            this.chk_lunch.UseVisualStyleBackColor = true;
            this.chk_lunch.CheckedChanged += new System.EventHandler(this.chk_lunch_CheckedChanged);
            // 
            // chk_breakfast
            // 
            this.chk_breakfast.AutoSize = true;
            this.chk_breakfast.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_rates, "bfast_in", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_breakfast.Location = new System.Drawing.Point(99, 25);
            this.chk_breakfast.Name = "chk_breakfast";
            this.chk_breakfast.Size = new System.Drawing.Size(67, 17);
            this.chk_breakfast.TabIndex = 459;
            this.chk_breakfast.Text = "Included";
            this.chk_breakfast.UseVisualStyleBackColor = true;
            this.chk_breakfast.CheckedChanged += new System.EventHandler(this.chk_breakfast_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 458;
            this.label7.Text = "Description:";
            // 
            // txt_descrip
            // 
            this.txt_descrip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_rates, "descrip", true));
            this.txt_descrip.Location = new System.Drawing.Point(86, 19);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(245, 20);
            this.txt_descrip.TabIndex = 457;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_s_rate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_l_rate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_b_rate);
            this.groupBox2.Controls.Add(this.chk_s_served);
            this.groupBox2.Controls.Add(this.chk_l_served);
            this.groupBox2.Controls.Add(this.chk_b_served);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chk_supper);
            this.groupBox2.Controls.Add(this.chk_lunch);
            this.groupBox2.Controls.Add(this.chk_breakfast);
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 109);
            this.groupBox2.TabIndex = 482;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meals Incl in Conf. Rate for meals not included but Served if Requested.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ck_show_web);
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_descrip);
            this.groupBox3.Location = new System.Drawing.Point(10, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 75);
            this.groupBox3.TabIndex = 483;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conference Type Details";
            // 
            // ConferenceTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 306);
            this.Controls.Add(this.pnl_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 340);
            this.Name = "ConferenceTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference Type";
            this.Load += new System.EventHandler(this.ConferenceTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_rates)).EndInit();
            this.pnl_detail.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_rates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_detail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_s_rate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_l_rate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_b_rate;
        private System.Windows.Forms.CheckBox chk_s_served;
        private System.Windows.Forms.CheckBox chk_l_served;
        private System.Windows.Forms.CheckBox chk_b_served;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_end_meal;
        private System.Windows.Forms.ComboBox cb_start_meal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_supper;
        private System.Windows.Forms.CheckBox chk_lunch;
        private System.Windows.Forms.CheckBox chk_breakfast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ck_show_web;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}