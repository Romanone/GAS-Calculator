namespace GAS_Calculator
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbLanguageSelector = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMeasurementSystem = new System.Windows.Forms.Label();
            this.cbMeasurementSystem = new System.Windows.Forms.ComboBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(210, 78);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 78);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbLanguageSelector
            // 
            this.cbLanguageSelector.DisplayMember = "1";
            this.cbLanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguageSelector.FormattingEnabled = true;
            this.cbLanguageSelector.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский"});
            this.cbLanguageSelector.Location = new System.Drawing.Point(157, 13);
            this.cbLanguageSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLanguageSelector.Name = "cbLanguageSelector";
            this.cbLanguageSelector.Size = new System.Drawing.Size(140, 24);
            this.cbLanguageSelector.TabIndex = 2;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 16);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(64, 16);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "Language";
            // 
            // lblMeasurementSystem
            // 
            this.lblMeasurementSystem.AutoSize = true;
            this.lblMeasurementSystem.Location = new System.Drawing.Point(12, 48);
            this.lblMeasurementSystem.Name = "lblMeasurementSystem";
            this.lblMeasurementSystem.Size = new System.Drawing.Size(102, 16);
            this.lblMeasurementSystem.TabIndex = 5;
            this.lblMeasurementSystem.Text = "Measuring system";
            // 
            // cbMeasurementSystem
            // 
            this.cbMeasurementSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbMeasurementSystem.Enabled = false;
            this.cbMeasurementSystem.FormattingEnabled = true;
            this.cbMeasurementSystem.Location = new System.Drawing.Point(157, 45);
            this.cbMeasurementSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMeasurementSystem.Name = "cbMeasurementSystem";
            this.cbMeasurementSystem.Size = new System.Drawing.Size(140, 24);
            this.cbMeasurementSystem.TabIndex = 4;
            this.cbMeasurementSystem.Text = "Under development";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.Location = new System.Drawing.Point(12, 78);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(28, 28);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 113);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblMeasurementSystem);
            this.Controls.Add(this.cbMeasurementSystem);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbLanguageSelector);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gas Calculator - Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.Label lblMeasurementSystem;
        public System.Windows.Forms.ComboBox cbMeasurementSystem;
        private System.Windows.Forms.ComboBox cbLanguageSelector;
    }
}