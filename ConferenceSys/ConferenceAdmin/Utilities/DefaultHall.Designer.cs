namespace ConferenceSys.ConferenceAdmin
{
    partial class DefaultHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultHall));
            this.cbHall = new System.Windows.Forms.ComboBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.pnl_dininghall = new System.Windows.Forms.Panel();
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.ckbox_dininghall = new System.Windows.Forms.CheckBox();
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
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.Location = new System.Drawing.Point(14, 6);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(73, 13);
            this.lblHall.TabIndex = 38;
            this.lblHall.Text = "Dining Hall:";
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(143, 200);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 40;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Update Meals? ";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(28, 96);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(301, 17);
            this.rb_no.TabIndex = 44;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No changes to existing meals must be made for this person";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Location = new System.Drawing.Point(28, 73);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(161, 17);
            this.rb_yes.TabIndex = 45;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "Yes, reset this persons meals";
            this.rb_yes.UseVisualStyleBackColor = true;
            this.rb_yes.CheckedChanged += new System.EventHandler(this.rb_yes_CheckedChanged);
            // 
            // pnl_dininghall
            // 
            this.pnl_dininghall.Controls.Add(this.cbHall);
            this.pnl_dininghall.Controls.Add(this.lblHall);
            this.pnl_dininghall.Location = new System.Drawing.Point(11, 157);
            this.pnl_dininghall.Name = "pnl_dininghall";
            this.pnl_dininghall.Size = new System.Drawing.Size(340, 35);
            this.pnl_dininghall.TabIndex = 46;
            this.pnl_dininghall.Visible = false;
            // 
            // txt_feedback
            // 
            this.txt_feedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_feedback.Location = new System.Drawing.Point(12, 12);
            this.txt_feedback.Multiline = true;
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.Size = new System.Drawing.Size(339, 33);
            this.txt_feedback.TabIndex = 47;
            this.txt_feedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbox_dininghall
            // 
            this.ckbox_dininghall.AutoSize = true;
            this.ckbox_dininghall.Location = new System.Drawing.Point(28, 134);
            this.ckbox_dininghall.Name = "ckbox_dininghall";
            this.ckbox_dininghall.Size = new System.Drawing.Size(246, 17);
            this.ckbox_dininghall.TabIndex = 48;
            this.ckbox_dininghall.Text = "Do you want to change the default dining hall?";
            this.ckbox_dininghall.UseVisualStyleBackColor = true;
            this.ckbox_dininghall.Visible = false;
            this.ckbox_dininghall.CheckedChanged += new System.EventHandler(this.ckbox_dininghall_CheckedChanged);
            // 
            // DefaultHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(361, 233);
            this.Controls.Add(this.ckbox_dininghall);
            this.Controls.Add(this.txt_feedback);
            this.Controls.Add(this.pnl_dininghall);
            this.Controls.Add(this.rb_yes);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_proceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal Update";
            this.Load += new System.EventHandler(this.DefaultHall_Load);
            this.pnl_dininghall.ResumeLayout(false);
            this.pnl_dininghall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHall;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.Panel pnl_dininghall;
        private System.Windows.Forms.TextBox txt_feedback;
        private System.Windows.Forms.CheckBox ckbox_dininghall;

    }
}