namespace ConferenceSys.ConferenceAdmin
{
    partial class GuestsByHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsByHall));
            this.cbHall = new System.Windows.Forms.ComboBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.pnl_dininghall = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_dininghall.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHall
            // 
            this.cbHall.DisplayMember = "detail";
            this.cbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHall.FormattingEnabled = true;
            this.cbHall.Location = new System.Drawing.Point(93, 3);
            this.cbHall.Name = "cbHall";
            this.cbHall.Size = new System.Drawing.Size(220, 21);
            this.cbHall.TabIndex = 39;
            this.cbHall.ValueMember = "dhall";
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(213, 92);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 40;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // pnl_dininghall
            // 
            this.pnl_dininghall.Controls.Add(this.label3);
            this.pnl_dininghall.Controls.Add(this.cbHall);
            this.pnl_dininghall.Location = new System.Drawing.Point(25, 12);
            this.pnl_dininghall.Name = "pnl_dininghall";
            this.pnl_dininghall.Size = new System.Drawing.Size(340, 35);
            this.pnl_dininghall.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(358, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(294, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Hall:";
            // 
            // GuestsByHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(582, 128);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnl_dininghall);
            this.Controls.Add(this.btn_proceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestsByHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guests By Dinning Hall";
            this.Load += new System.EventHandler(this.GuestsByHall_Load);
            this.pnl_dininghall.ResumeLayout(false);
            this.pnl_dininghall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHall;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Panel pnl_dininghall;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;

    }
}