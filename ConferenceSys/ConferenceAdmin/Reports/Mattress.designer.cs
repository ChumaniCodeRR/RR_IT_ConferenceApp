namespace ConferenceSys.ConferenceAdmin
{
    partial class Mattress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mattress));
            this.bs_gradcon = new System.Windows.Forms.BindingSource(this.components);
            this.txt_ccode = new System.Windows.Forms.TextBox();
            this.txt_conference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search_conf = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gradcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ccode
            // 
            this.txt_ccode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_gradcon, "ccode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_ccode.Location = new System.Drawing.Point(128, 13);
            this.txt_ccode.Name = "txt_ccode";
            this.txt_ccode.ReadOnly = true;
            this.txt_ccode.Size = new System.Drawing.Size(100, 20);
            this.txt_ccode.TabIndex = 20;
            // 
            // txt_conference
            // 
            this.txt_conference.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_gradcon, "grad_ball", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_conference.Location = new System.Drawing.Point(277, 12);
            this.txt_conference.Name = "txt_conference";
            this.txt_conference.ReadOnly = true;
            this.txt_conference.Size = new System.Drawing.Size(374, 20);
            this.txt_conference.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Conference Code:";
            // 
            // btn_search_conf
            // 
            this.btn_search_conf.Location = new System.Drawing.Point(234, 12);
            this.btn_search_conf.Name = "btn_search_conf";
            this.btn_search_conf.Size = new System.Drawing.Size(37, 21);
            this.btn_search_conf.TabIndex = 14;
            this.btn_search_conf.Text = "...";
            this.btn_search_conf.UseVisualStyleBackColor = true;
            this.btn_search_conf.Click += new System.EventHandler(this.btn_search_conf_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(343, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 90;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(262, 91);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 80;
            this.btn_save.Text = "Proceed";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // Mattress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(681, 127);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_search_conf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_conference);
            this.Controls.Add(this.txt_ccode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mattress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mattress Report ";
            ((System.ComponentModel.ISupportInitialize)(this.bs_gradcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_gradcon;
        private System.Windows.Forms.TextBox txt_ccode;
        private System.Windows.Forms.TextBox txt_conference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_search_conf;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}