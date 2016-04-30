namespace GAS_Calculator
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.btnWelcomeOK = new System.Windows.Forms.Button();
            this.cbWelcomeLanguage = new System.Windows.Forms.ComboBox();
            this.lblWelcomeLanguage = new System.Windows.Forms.Label();
            this.rtbWelcome = new System.Windows.Forms.RichTextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWelcomeOK
            // 
            this.btnWelcomeOK.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWelcomeOK.Location = new System.Drawing.Point(190, 149);
            this.btnWelcomeOK.Name = "btnWelcomeOK";
            this.btnWelcomeOK.Size = new System.Drawing.Size(75, 23);
            this.btnWelcomeOK.TabIndex = 0;
            this.btnWelcomeOK.Text = "OK";
            this.btnWelcomeOK.UseVisualStyleBackColor = true;
            this.btnWelcomeOK.Click += new System.EventHandler(this.btnWelcomeOK_Click);
            // 
            // cbWelcomeLanguage
            // 
            this.cbWelcomeLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWelcomeLanguage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWelcomeLanguage.FormattingEnabled = true;
            this.cbWelcomeLanguage.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский"});
            this.cbWelcomeLanguage.Location = new System.Drawing.Point(144, 119);
            this.cbWelcomeLanguage.Name = "cbWelcomeLanguage";
            this.cbWelcomeLanguage.Size = new System.Drawing.Size(121, 24);
            this.cbWelcomeLanguage.TabIndex = 1;
            this.cbWelcomeLanguage.SelectedIndexChanged += new System.EventHandler(this.cbWelcomeLanguage_SelectedIndexChanged);
            // 
            // lblWelcomeLanguage
            // 
            this.lblWelcomeLanguage.AutoSize = true;
            this.lblWelcomeLanguage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcomeLanguage.Location = new System.Drawing.Point(12, 122);
            this.lblWelcomeLanguage.Name = "lblWelcomeLanguage";
            this.lblWelcomeLanguage.Size = new System.Drawing.Size(64, 16);
            this.lblWelcomeLanguage.TabIndex = 2;
            this.lblWelcomeLanguage.Text = "Language";
            // 
            // rtbWelcome
            // 
            this.rtbWelcome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbWelcome.Location = new System.Drawing.Point(12, 12);
            this.rtbWelcome.Name = "rtbWelcome";
            this.rtbWelcome.ReadOnly = true;
            this.rtbWelcome.Size = new System.Drawing.Size(253, 101);
            this.rtbWelcome.TabIndex = 3;
            this.rtbWelcome.Text = "GAS Calculator is designed to calculate cost of petrol and gas mileage, compare i" +
    "t and get period of equipment payback.";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 179);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(149, 13);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "EasyBreezy Software ©  2016";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(205, 179);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version 1.0";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 201);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.rtbWelcome);
            this.Controls.Add(this.lblWelcomeLanguage);
            this.Controls.Add(this.cbWelcomeLanguage);
            this.Controls.Add(this.btnWelcomeOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gas Calculator";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWelcomeOK;
        private System.Windows.Forms.ComboBox cbWelcomeLanguage;
        private System.Windows.Forms.Label lblWelcomeLanguage;
        private System.Windows.Forms.RichTextBox rtbWelcome;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblVersion;
    }
}