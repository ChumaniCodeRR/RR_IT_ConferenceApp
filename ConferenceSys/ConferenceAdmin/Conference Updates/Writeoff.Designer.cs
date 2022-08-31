namespace ConferenceSys.ConferenceAdmin.Conference_Updates
{
    partial class Writeoff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Writeoff));
            this.btn_search_folio = new System.Windows.Forms.Button();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_group = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.btn_writeoff = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_search_folio
            // 
            this.btn_search_folio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_search_folio.Location = new System.Drawing.Point(239, 38);
            this.btn_search_folio.Name = "btn_search_folio";
            this.btn_search_folio.Size = new System.Drawing.Size(26, 23);
            this.btn_search_folio.TabIndex = 40;
            this.btn_search_folio.Text = "...";
            this.btn_search_folio.UseVisualStyleBackColor = true;
            this.btn_search_folio.Click += new System.EventHandler(this.btn_search_folio_Click);
            // 
            // txt_folio
            // 
            this.txt_folio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_folio.Location = new System.Drawing.Point(132, 40);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(100, 20);
            this.txt_folio.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Type in a folio number:";
            // 
            // rb_group
            // 
            this.rb_group.AutoSize = true;
            this.rb_group.Checked = true;
            this.rb_group.Location = new System.Drawing.Point(132, 12);
            this.rb_group.Name = "rb_group";
            this.rb_group.Size = new System.Drawing.Size(54, 17);
            this.rb_group.TabIndex = 10;
            this.rb_group.TabStop = true;
            this.rb_group.Text = "Group";
            this.rb_group.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Location = new System.Drawing.Point(192, 12);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(54, 17);
            this.rb_single.TabIndex = 20;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Reservation Type:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Reason:";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(132, 66);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(348, 85);
            this.txt_reason.TabIndex = 50;
            // 
            // btn_writeoff
            // 
            this.btn_writeoff.Location = new System.Drawing.Point(168, 165);
            this.btn_writeoff.Name = "btn_writeoff";
            this.btn_writeoff.Size = new System.Drawing.Size(75, 23);
            this.btn_writeoff.TabIndex = 60;
            this.btn_writeoff.Text = "Writeoff";
            this.btn_writeoff.UseVisualStyleBackColor = true;
            this.btn_writeoff.Click += new System.EventHandler(this.btn_writeoff_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(249, 165);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 70;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Writeoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 200);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_writeoff);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_single);
            this.Controls.Add(this.rb_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search_folio);
            this.Controls.Add(this.txt_folio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Writeoff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Writeoff";
            this.Load += new System.EventHandler(this.Writeoff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search_folio;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_group;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Button btn_writeoff;
        private System.Windows.Forms.Button btn_cancel;
    }
}