namespace RhodesControl
{
    partial class TaskInitializer
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
            this.lblInitializing = new System.Windows.Forms.Label();
            this.splitContainerInitializing = new System.Windows.Forms.SplitContainer();
            this.lkShowHideDetails = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.cStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.cTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerInitializing.Panel1.SuspendLayout();
            this.splitContainerInitializing.Panel2.SuspendLayout();
            this.splitContainerInitializing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInitializing
            // 
            this.lblInitializing.AutoSize = true;
            this.lblInitializing.Location = new System.Drawing.Point(12, 9);
            this.lblInitializing.Name = "lblInitializing";
            this.lblInitializing.Size = new System.Drawing.Size(150, 13);
            this.lblInitializing.TabIndex = 0;
            this.lblInitializing.Text = "Initializing Data. Please wait ...";
            // 
            // splitContainerInitializing
            // 
            this.splitContainerInitializing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInitializing.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerInitializing.IsSplitterFixed = true;
            this.splitContainerInitializing.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInitializing.Name = "splitContainerInitializing";
            this.splitContainerInitializing.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInitializing.Panel1
            // 
            this.splitContainerInitializing.Panel1.Controls.Add(this.lkShowHideDetails);
            this.splitContainerInitializing.Panel1.Controls.Add(this.progressBar);
            this.splitContainerInitializing.Panel1.Controls.Add(this.lblInitializing);
            // 
            // splitContainerInitializing.Panel2
            // 
            this.splitContainerInitializing.Panel2.Controls.Add(this.dgvTask);
            this.splitContainerInitializing.Size = new System.Drawing.Size(284, 224);
            this.splitContainerInitializing.SplitterDistance = 82;
            this.splitContainerInitializing.TabIndex = 1;
            // 
            // lkShowHideDetails
            // 
            this.lkShowHideDetails.AutoSize = true;
            this.lkShowHideDetails.Location = new System.Drawing.Point(13, 59);
            this.lkShowHideDetails.Name = "lkShowHideDetails";
            this.lkShowHideDetails.Size = new System.Drawing.Size(66, 13);
            this.lkShowHideDetails.TabIndex = 2;
            this.lkShowHideDetails.TabStop = true;
            this.lkShowHideDetails.Text = "ShowDetails";
            this.lkShowHideDetails.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lkShowHideDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowHideDetails_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 32);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(257, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStatus,
            this.cTask});
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 0);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.Size = new System.Drawing.Size(284, 138);
            this.dgvTask.TabIndex = 0;
            // 
            // cStatus
            // 
            this.cStatus.FillWeight = 30F;
            this.cStatus.HeaderText = "";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cStatus.Width = 30;
            // 
            // cTask
            // 
            this.cTask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTask.DataPropertyName = "TaskDescription";
            this.cTask.HeaderText = "Task Description";
            this.cTask.Name = "cTask";
            this.cTask.ReadOnly = true;
            this.cTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TaskInitializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.splitContainerInitializing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskInitializer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Initializer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskInitializer_Load);
            this.splitContainerInitializing.Panel1.ResumeLayout(false);
            this.splitContainerInitializing.Panel1.PerformLayout();
            this.splitContainerInitializing.Panel2.ResumeLayout(false);
            this.splitContainerInitializing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInitializing;
        private System.Windows.Forms.SplitContainer splitContainerInitializing;
        private System.Windows.Forms.LinkLabel lkShowHideDetails;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.DataGridViewImageColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTask;
    }
}