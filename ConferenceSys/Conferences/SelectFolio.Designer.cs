namespace ConferenceSys
{
    partial class SelectFolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFolio));
            this.lblResidencePlannng = new System.Windows.Forms.Label();
            this.dgvSelectFolio = new System.Windows.Forms.DataGridView();
            this.cCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFolio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResidencePlannng
            // 
            this.lblResidencePlannng.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResidencePlannng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidencePlannng.Location = new System.Drawing.Point(34, 9);
            this.lblResidencePlannng.Name = "lblResidencePlannng";
            this.lblResidencePlannng.Size = new System.Drawing.Size(291, 24);
            this.lblResidencePlannng.TabIndex = 4;
            this.lblResidencePlannng.Text = "Select Folio Number";
            this.lblResidencePlannng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSelectFolio
            // 
            this.dgvSelectFolio.AllowUserToAddRows = false;
            this.dgvSelectFolio.AllowUserToDeleteRows = false;
            this.dgvSelectFolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectFolio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCheck,
            this.cFolio,
            this.cName});
            this.dgvSelectFolio.Location = new System.Drawing.Point(13, 37);
            this.dgvSelectFolio.MultiSelect = false;
            this.dgvSelectFolio.Name = "dgvSelectFolio";
            this.dgvSelectFolio.RowHeadersVisible = false;
            this.dgvSelectFolio.Size = new System.Drawing.Size(334, 126);
            this.dgvSelectFolio.TabIndex = 5;
            this.dgvSelectFolio.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectFolio_CellValueChanged);
            this.dgvSelectFolio.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSelectFolio_CurrentCellDirtyStateChanged);
            // 
            // cCheck
            // 
            this.cCheck.HeaderText = "";
            this.cCheck.Name = "cCheck";
            this.cCheck.Width = 30;
            // 
            // cFolio
            // 
            this.cFolio.HeaderText = "Folio";
            this.cFolio.Name = "cFolio";
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(105, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(186, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SelectFolio
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvSelectFolio);
            this.Controls.Add(this.lblResidencePlannng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Folio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectFolio_FormClosing);
            this.Load += new System.EventHandler(this.SelectFolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResidencePlannng;
        private System.Windows.Forms.DataGridView dgvSelectFolio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}