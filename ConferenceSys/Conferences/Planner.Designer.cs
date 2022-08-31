namespace ConferenceSys
{
    partial class Planner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblResidencePlannng = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.cbHall = new System.Windows.Forms.ComboBox();
            this.bsHall = new System.Windows.Forms.BindingSource(this.components);
            this.cbHouse = new System.Windows.Forms.ComboBox();
            this.bsHouse = new System.Windows.Forms.BindingSource(this.components);
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDateFilters = new System.Windows.Forms.Label();
            this.lblDateFromTo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.cFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAFBEDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.bsBuilding = new System.Windows.Forms.BindingSource(this.components);
            this.lblTodayLegend = new System.Windows.Forms.Label();
            this.ckSpecificDay = new System.Windows.Forms.CheckBox();
            this.lblDoubleClickMsg = new System.Windows.Forms.Label();
            this.lblPH = new System.Windows.Forms.Label();
            this.lblSelectionHeader = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.lblSelectionDetails = new System.Windows.Forms.Label();
            this.picBuilding = new System.Windows.Forms.PictureBox();
            this.picRhodesCrest = new System.Windows.Forms.PictureBox();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_folio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRhodesCrest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResidencePlannng
            // 
            this.lblResidencePlannng.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResidencePlannng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidencePlannng.Location = new System.Drawing.Point(182, 9);
            this.lblResidencePlannng.Name = "lblResidencePlannng";
            this.lblResidencePlannng.Size = new System.Drawing.Size(638, 24);
            this.lblResidencePlannng.TabIndex = 3;
            this.lblResidencePlannng.Text = "Conference Booking System";
            this.lblResidencePlannng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResidencePlannng.Click += new System.EventHandler(this.lblResidencePlannng_Click);
            // 
            // lblHall
            // 
            this.lblHall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(166, 55);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(25, 13);
            this.lblHall.TabIndex = 4;
            this.lblHall.Text = "Hall";
            // 
            // cbHall
            // 
            this.cbHall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHall.DataSource = this.bsHall;
            this.cbHall.DisplayMember = "hallname";
            this.cbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHall.FormattingEnabled = true;
            this.cbHall.Location = new System.Drawing.Point(197, 52);
            this.cbHall.Name = "cbHall";
            this.cbHall.Size = new System.Drawing.Size(154, 21);
            this.cbHall.TabIndex = 5;
            this.cbHall.ValueMember = "hall";
            this.cbHall.SelectedIndexChanged += new System.EventHandler(this.cbHall_SelectedIndexChanged);
            // 
            // bsHall
            // 
            this.bsHall.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conf_codesDataSet.tt_conf_hallDataTable);
            // 
            // cbHouse
            // 
            this.cbHouse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHouse.DataSource = this.bsHouse;
            this.cbHouse.DisplayMember = "RESNAME";
            this.cbHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHouse.FormattingEnabled = true;
            this.cbHouse.Location = new System.Drawing.Point(389, 52);
            this.cbHouse.Name = "cbHouse";
            this.cbHouse.Size = new System.Drawing.Size(152, 21);
            this.cbHouse.TabIndex = 6;
            this.cbHouse.ValueMember = "RES";
            this.cbHouse.SelectedIndexChanged += new System.EventHandler(this.cbHouse_SelectedIndexChanged);
            // 
            // bsHouse
            // 
            this.bsHouse.DataSource = typeof(NS_System.StrongTypesNS.DS_RESCODESDataSet.TT_RESDataTable);
            // 
            // lblHouse
            // 
            this.lblHouse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(357, 55);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(26, 13);
            this.lblHouse.TabIndex = 7;
            this.lblHouse.Text = "Res";
            // 
            // lblLine1
            // 
            this.lblLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine1.Location = new System.Drawing.Point(160, 32);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(699, 10);
            this.lblLine1.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(179, 106);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartDate.Location = new System.Drawing.Point(240, 104);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(187, 20);
            this.dtpStartDate.TabIndex = 12;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(455, 106);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.Location = new System.Drawing.Point(516, 104);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(187, 20);
            this.dtpEndDate.TabIndex = 14;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblLine2
            // 
            this.lblLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine2.Location = new System.Drawing.Point(16, 130);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(972, 2);
            this.lblLine2.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Location = new System.Drawing.Point(731, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh Dates";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDateFilters
            // 
            this.lblDateFilters.AutoSize = true;
            this.lblDateFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFilters.Location = new System.Drawing.Point(12, 142);
            this.lblDateFilters.Name = "lblDateFilters";
            this.lblDateFilters.Size = new System.Drawing.Size(70, 13);
            this.lblDateFilters.TabIndex = 17;
            this.lblDateFilters.Text = "Date Filter:";
            // 
            // lblDateFromTo
            // 
            this.lblDateFromTo.AutoSize = true;
            this.lblDateFromTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFromTo.Location = new System.Drawing.Point(88, 142);
            this.lblDateFromTo.Name = "lblDateFromTo";
            this.lblDateFromTo.Size = new System.Drawing.Size(84, 13);
            this.lblDateFromTo.TabIndex = 18;
            this.lblDateFromTo.Text = "Date From To";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AllowUserToResizeColumns = false;
            this.dgvBookings.AllowUserToResizeRows = false;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFloor,
            this.cRoomNo,
            this.cBeds,
            this.cNAFBEDS,
            this.cNotes});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookings.Location = new System.Drawing.Point(13, 159);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookings.Size = new System.Drawing.Size(975, 321);
            this.dgvBookings.TabIndex = 19;
            this.dgvBookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellDoubleClick);
            this.dgvBookings.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBookings_CellPainting);
            this.dgvBookings.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBookings_DataBindingComplete);
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);
            // 
            // cFloor
            // 
            this.cFloor.DataPropertyName = "SECTION_NAME";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.cFloor.DefaultCellStyle = dataGridViewCellStyle1;
            this.cFloor.HeaderText = "Floor";
            this.cFloor.Name = "cFloor";
            this.cFloor.ReadOnly = true;
            this.cFloor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cFloor.Width = 36;
            // 
            // cRoomNo
            // 
            this.cRoomNo.DataPropertyName = "ROOM_NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            this.cRoomNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRoomNo.HeaderText = "Room No.";
            this.cRoomNo.Name = "cRoomNo";
            this.cRoomNo.ReadOnly = true;
            this.cRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRoomNo.Width = 61;
            // 
            // cBeds
            // 
            this.cBeds.DataPropertyName = "BEDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            this.cBeds.DefaultCellStyle = dataGridViewCellStyle3;
            this.cBeds.HeaderText = "No. of Beds";
            this.cBeds.Name = "cBeds";
            this.cBeds.ReadOnly = true;
            this.cBeds.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cBeds.Width = 69;
            // 
            // cNAFBEDS
            // 
            this.cNAFBEDS.DataPropertyName = "NAF_BEDS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            this.cNAFBEDS.DefaultCellStyle = dataGridViewCellStyle4;
            this.cNAFBEDS.HeaderText = "NAF Beds";
            this.cNAFBEDS.Name = "cNAFBEDS";
            this.cNAFBEDS.ReadOnly = true;
            this.cNAFBEDS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNAFBEDS.Width = 61;
            // 
            // cNotes
            // 
            this.cNotes.DataPropertyName = "Notes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            this.cNotes.DefaultCellStyle = dataGridViewCellStyle5;
            this.cNotes.HeaderText = "Notes";
            this.cNotes.MinimumWidth = 100;
            this.cNotes.Name = "cNotes";
            this.cNotes.ReadOnly = true;
            this.cNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblBuilding
            // 
            this.lblBuilding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(547, 55);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(44, 13);
            this.lblBuilding.TabIndex = 20;
            this.lblBuilding.Text = "Building";
            // 
            // cbBuilding
            // 
            this.cbBuilding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBuilding.DataSource = this.bsBuilding;
            this.cbBuilding.DisplayMember = "BUILDING_NAME";
            this.cbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Location = new System.Drawing.Point(597, 52);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(262, 21);
            this.cbBuilding.TabIndex = 21;
            this.cbBuilding.ValueMember = "BUILDING";
            this.cbBuilding.SelectedIndexChanged += new System.EventHandler(this.cbBuilding_SelectedIndexChanged);
            // 
            // bsBuilding
            // 
            this.bsBuilding.DataSource = typeof(NS_System.StrongTypesNS.DS_BUILDINGSDataSet.TT_BUILDINGDataTable);
            // 
            // lblTodayLegend
            // 
            this.lblTodayLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayLegend.AutoSize = true;
            this.lblTodayLegend.BackColor = System.Drawing.Color.LightGreen;
            this.lblTodayLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTodayLegend.Location = new System.Drawing.Point(867, 142);
            this.lblTodayLegend.Name = "lblTodayLegend";
            this.lblTodayLegend.Size = new System.Drawing.Size(39, 15);
            this.lblTodayLegend.TabIndex = 22;
            this.lblTodayLegend.Text = "Today";
            // 
            // ckSpecificDay
            // 
            this.ckSpecificDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckSpecificDay.AutoSize = true;
            this.ckSpecificDay.Location = new System.Drawing.Point(240, 81);
            this.ckSpecificDay.Name = "ckSpecificDay";
            this.ckSpecificDay.Size = new System.Drawing.Size(118, 17);
            this.ckSpecificDay.TabIndex = 24;
            this.ckSpecificDay.Text = "Specific Single Day";
            this.ckSpecificDay.UseVisualStyleBackColor = true;
            this.ckSpecificDay.CheckedChanged += new System.EventHandler(this.ckSpecificDay_CheckedChanged);
            // 
            // lblDoubleClickMsg
            // 
            this.lblDoubleClickMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoubleClickMsg.AutoSize = true;
            this.lblDoubleClickMsg.Location = new System.Drawing.Point(425, 143);
            this.lblDoubleClickMsg.Name = "lblDoubleClickMsg";
            this.lblDoubleClickMsg.Size = new System.Drawing.Size(177, 13);
            this.lblDoubleClickMsg.TabIndex = 25;
            this.lblDoubleClickMsg.Text = "Double click to view booking details";
            // 
            // lblPH
            // 
            this.lblPH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPH.AutoSize = true;
            this.lblPH.BackColor = System.Drawing.Color.Thistle;
            this.lblPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH.Location = new System.Drawing.Point(912, 142);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(76, 15);
            this.lblPH.TabIndex = 26;
            this.lblPH.Text = "Public Holiday";
            // 
            // lblSelectionHeader
            // 
            this.lblSelectionHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectionHeader.AutoSize = true;
            this.lblSelectionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionHeader.Location = new System.Drawing.Point(10, 491);
            this.lblSelectionHeader.Name = "lblSelectionHeader";
            this.lblSelectionHeader.Size = new System.Drawing.Size(64, 13);
            this.lblSelectionHeader.TabIndex = 27;
            this.lblSelectionHeader.Text = "Selection:";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateBooking.Location = new System.Drawing.Point(899, 486);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(89, 23);
            this.btnCreateBooking.TabIndex = 28;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // lblSelectionDetails
            // 
            this.lblSelectionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectionDetails.AutoSize = true;
            this.lblSelectionDetails.Location = new System.Drawing.Point(80, 491);
            this.lblSelectionDetails.Name = "lblSelectionDetails";
            this.lblSelectionDetails.Size = new System.Drawing.Size(111, 13);
            this.lblSelectionDetails.TabIndex = 29;
            this.lblSelectionDetails.Text = "0 room(s) and 0 day(s)";
            // 
            // picBuilding
            // 
            this.picBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBuilding.InitialImage = null;
            this.picBuilding.Location = new System.Drawing.Point(867, 12);
            this.picBuilding.Name = "picBuilding";
            this.picBuilding.Size = new System.Drawing.Size(121, 107);
            this.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuilding.TabIndex = 34;
            this.picBuilding.TabStop = false;
            // 
            // picRhodesCrest
            // 
            this.picRhodesCrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRhodesCrest.InitialImage = null;
            this.picRhodesCrest.Location = new System.Drawing.Point(15, 12);
            this.picRhodesCrest.Name = "picRhodesCrest";
            this.picRhodesCrest.Size = new System.Drawing.Size(139, 107);
            this.picRhodesCrest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRhodesCrest.TabIndex = 33;
            this.picRhodesCrest.TabStop = false;
            // 
            // txt_folio
            // 
            this.txt_folio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_folio.Location = new System.Drawing.Point(548, 488);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(100, 20);
            this.txt_folio.TabIndex = 35;
            this.txt_folio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_folio_KeyDown);
            this.txt_folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_folio_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Type in a folio number and press enter:";
            // 
            // btn_search_folio
            // 
            this.btn_search_folio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_search_folio.Location = new System.Drawing.Point(654, 486);
            this.btn_search_folio.Name = "btn_search_folio";
            this.btn_search_folio.Size = new System.Drawing.Size(26, 23);
            this.btn_search_folio.TabIndex = 39;
            this.btn_search_folio.Text = "...";
            this.btn_search_folio.UseVisualStyleBackColor = true;
            this.btn_search_folio.Click += new System.EventHandler(this.btn_search_folio_Click);
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 521);
            this.Controls.Add(this.btn_search_folio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_folio);
            this.Controls.Add(this.picBuilding);
            this.Controls.Add(this.picRhodesCrest);
            this.Controls.Add(this.lblSelectionDetails);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.lblSelectionHeader);
            this.Controls.Add(this.lblPH);
            this.Controls.Add(this.lblDoubleClickMsg);
            this.Controls.Add(this.ckSpecificDay);
            this.Controls.Add(this.lblTodayLegend);
            this.Controls.Add(this.cbBuilding);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.lblDateFromTo);
            this.Controls.Add(this.lblDateFilters);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.cbHouse);
            this.Controls.Add(this.cbHall);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.lblResidencePlannng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Planner";
            this.Text = "ResPlanner";
            this.Load += new System.EventHandler(this.ResPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRhodesCrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResidencePlannng;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.ComboBox cbHall;
        private System.Windows.Forms.ComboBox cbHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDateFilters;
        private System.Windows.Forms.Label lblDateFromTo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.Label lblTodayLegend;
        private System.Windows.Forms.CheckBox ckSpecificDay;
        private System.Windows.Forms.Label lblDoubleClickMsg;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.BindingSource bsHouse;
        private System.Windows.Forms.BindingSource bsBuilding;
        private System.Windows.Forms.Label lblSelectionDetails;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Label lblSelectionHeader;
        private System.Windows.Forms.PictureBox picBuilding;
        private System.Windows.Forms.PictureBox picRhodesCrest;
        private System.Windows.Forms.BindingSource bsHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Button btn_search_folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAFBEDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNotes;
    }
}