﻿namespace ConferenceSys.ConferenceAdmin
{
    partial class ResetBookDates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetBookDates));
            this.label1 = new System.Windows.Forms.Label();
            this.chk_recreate = new System.Windows.Forms.CheckBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dte_new_end = new System.Windows.Forms.DateTimePicker();
            this.dte_new_start = new System.Windows.Forms.DateTimePicker();
            this.dte_old_end = new System.Windows.Forms.DateTimePicker();
            this.dte_old_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bs_buildings = new System.Windows.Forms.BindingSource(this.components);
            this.dS_CCODEDataSet = new NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bs_buildings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_CCODEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Recreate meals?";
            // 
            // chk_recreate
            // 
            this.chk_recreate.AutoSize = true;
            this.chk_recreate.Location = new System.Drawing.Point(333, 72);
            this.chk_recreate.Name = "chk_recreate";
            this.chk_recreate.Size = new System.Drawing.Size(15, 14);
            this.chk_recreate.TabIndex = 29;
            this.chk_recreate.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(220, 102);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 30;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dte_new_end
            // 
            this.dte_new_end.Location = new System.Drawing.Point(393, 38);
            this.dte_new_end.Name = "dte_new_end";
            this.dte_new_end.Size = new System.Drawing.Size(191, 20);
            this.dte_new_end.TabIndex = 32;
            // 
            // dte_new_start
            // 
            this.dte_new_start.Location = new System.Drawing.Point(101, 38);
            this.dte_new_start.Name = "dte_new_start";
            this.dte_new_start.Size = new System.Drawing.Size(191, 20);
            this.dte_new_start.TabIndex = 33;
            // 
            // dte_old_end
            // 
            this.dte_old_end.Enabled = false;
            this.dte_old_end.Location = new System.Drawing.Point(393, 12);
            this.dte_old_end.Name = "dte_old_end";
            this.dte_old_end.Size = new System.Drawing.Size(191, 20);
            this.dte_old_end.TabIndex = 34;
            // 
            // dte_old_start
            // 
            this.dte_old_start.Enabled = false;
            this.dte_old_start.Location = new System.Drawing.Point(101, 12);
            this.dte_old_start.Name = "dte_old_start";
            this.dte_old_start.Size = new System.Drawing.Size(191, 20);
            this.dte_old_start.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "New Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "New End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Old End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Old Start Date:";
            // 
            // bs_buildings
            // 
            this.bs_buildings.DataMember = "tt_ccode_build";
            this.bs_buildings.DataSource = this.dS_CCODEDataSet;
            // 
            // dS_CCODEDataSet
            // 
            this.dS_CCODEDataSet.DataSetName = "DS_CCODEDataSet";
            this.dS_CCODEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResetBookDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(596, 131);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dte_old_start);
            this.Controls.Add(this.dte_old_end);
            this.Controls.Add(this.dte_new_start);
            this.Controls.Add(this.dte_new_end);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.chk_recreate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetBookDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset dates";
            this.Load += new System.EventHandler(this.ResetBookDates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_buildings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_CCODEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_buildings;
        private NS_ConfAdmin.StrongTypesNS.DS_CCODEDataSet dS_CCODEDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_recreate;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dte_new_end;
        private System.Windows.Forms.DateTimePicker dte_new_start;
        private System.Windows.Forms.DateTimePicker dte_old_end;
        private System.Windows.Forms.DateTimePicker dte_old_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}