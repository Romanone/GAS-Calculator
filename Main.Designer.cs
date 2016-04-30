namespace GAS_Calculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.nudPetrolPrice = new System.Windows.Forms.NumericUpDown();
            this.nudGASPrice = new System.Windows.Forms.NumericUpDown();
            this.nudPetrolRate = new System.Windows.Forms.NumericUpDown();
            this.nudGASRate = new System.Windows.Forms.NumericUpDown();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.lblGAS = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.gbPetrolRate = new System.Windows.Forms.GroupBox();
            this.pbTip = new System.Windows.Forms.PictureBox();
            this.gbDistanceRate = new System.Windows.Forms.GroupBox();
            this.tbGASPerOne = new System.Windows.Forms.TextBox();
            this.tbPetrolPerOne = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbPriceCalculator = new System.Windows.Forms.GroupBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSaving = new System.Windows.Forms.Label();
            this.tbSavings = new System.Windows.Forms.TextBox();
            this.tbGASPerDistance = new System.Windows.Forms.TextBox();
            this.tbPetrolPerDistance = new System.Windows.Forms.TextBox();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.lblEquipmentCost = new System.Windows.Forms.Label();
            this.nudPriceForParts = new System.Windows.Forms.NumericUpDown();
            this.tbDistanceForZero = new System.Windows.Forms.TextBox();
            this.lblEquipmentRePaid = new System.Windows.Forms.Label();
            this.gbDistanceForZero = new System.Windows.Forms.GroupBox();
            this.lblDistance2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbPump = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPetrolPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGASPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPetrolRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGASRate)).BeginInit();
            this.gbPrice.SuspendLayout();
            this.gbPetrolRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTip)).BeginInit();
            this.gbDistanceRate.SuspendLayout();
            this.gbPriceCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceForParts)).BeginInit();
            this.gbDistanceForZero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPetrolPrice
            // 
            this.nudPetrolPrice.DecimalPlaces = 2;
            this.nudPetrolPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudPetrolPrice.Location = new System.Drawing.Point(6, 20);
            this.nudPetrolPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPetrolPrice.Name = "nudPetrolPrice";
            this.nudPetrolPrice.Size = new System.Drawing.Size(119, 21);
            this.nudPetrolPrice.TabIndex = 0;
            this.nudPetrolPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPetrolPrice.Value = new decimal(new int[] {
            185,
            0,
            0,
            65536});
            // 
            // nudGASPrice
            // 
            this.nudGASPrice.DecimalPlaces = 2;
            this.nudGASPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudGASPrice.Location = new System.Drawing.Point(135, 20);
            this.nudGASPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGASPrice.Name = "nudGASPrice";
            this.nudGASPrice.Size = new System.Drawing.Size(119, 21);
            this.nudGASPrice.TabIndex = 1;
            this.nudGASPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGASPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGASPrice.Value = new decimal(new int[] {
            750,
            0,
            0,
            131072});
            // 
            // nudPetrolRate
            // 
            this.nudPetrolRate.DecimalPlaces = 1;
            this.nudPetrolRate.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudPetrolRate.Location = new System.Drawing.Point(6, 20);
            this.nudPetrolRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPetrolRate.Name = "nudPetrolRate";
            this.nudPetrolRate.Size = new System.Drawing.Size(119, 21);
            this.nudPetrolRate.TabIndex = 2;
            this.nudPetrolRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPetrolRate.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPetrolRate.ValueChanged += new System.EventHandler(this.nudPetrolRate_ValueChanged);
            // 
            // nudGASRate
            // 
            this.nudGASRate.DecimalPlaces = 1;
            this.nudGASRate.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudGASRate.Location = new System.Drawing.Point(135, 20);
            this.nudGASRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGASRate.Name = "nudGASRate";
            this.nudGASRate.Size = new System.Drawing.Size(95, 21);
            this.nudGASRate.TabIndex = 3;
            this.nudGASRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGASRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGASRate.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.nudPetrolPrice);
            this.gbPrice.Controls.Add(this.nudGASPrice);
            this.gbPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPrice.Location = new System.Drawing.Point(12, 42);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(260, 51);
            this.gbPrice.TabIndex = 4;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Price per 1 liter of fuel";
            // 
            // lblGAS
            // 
            this.lblGAS.AutoSize = true;
            this.lblGAS.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblGAS.Location = new System.Drawing.Point(212, 9);
            this.lblGAS.Name = "lblGAS";
            this.lblGAS.Size = new System.Drawing.Size(60, 30);
            this.lblGAS.TabIndex = 3;
            this.lblGAS.Text = "Gas";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblPetrol.Location = new System.Drawing.Point(12, 9);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(80, 30);
            this.lblPetrol.TabIndex = 2;
            this.lblPetrol.Text = "Petrol";
            // 
            // gbPetrolRate
            // 
            this.gbPetrolRate.Controls.Add(this.pbTip);
            this.gbPetrolRate.Controls.Add(this.nudPetrolRate);
            this.gbPetrolRate.Controls.Add(this.nudGASRate);
            this.gbPetrolRate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPetrolRate.Location = new System.Drawing.Point(12, 99);
            this.gbPetrolRate.Name = "gbPetrolRate";
            this.gbPetrolRate.Size = new System.Drawing.Size(260, 51);
            this.gbPetrolRate.TabIndex = 5;
            this.gbPetrolRate.TabStop = false;
            this.gbPetrolRate.Text = "Consumption of fuel per 100 kilometers";
            // 
            // pbTip
            // 
            this.pbTip.Image = global::GAS_Calculator.Properties.Resources.help;
            this.pbTip.Location = new System.Drawing.Point(236, 20);
            this.pbTip.Name = "pbTip";
            this.pbTip.Size = new System.Drawing.Size(18, 21);
            this.pbTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTip.TabIndex = 4;
            this.pbTip.TabStop = false;
            this.toolTip.SetToolTip(this.pbTip, "Consumption of propane is usually 1-2 liters larger than the consumption of gasol" +
        "ine");
            // 
            // gbDistanceRate
            // 
            this.gbDistanceRate.Controls.Add(this.tbGASPerOne);
            this.gbDistanceRate.Controls.Add(this.tbPetrolPerOne);
            this.gbDistanceRate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDistanceRate.Location = new System.Drawing.Point(12, 156);
            this.gbDistanceRate.Name = "gbDistanceRate";
            this.gbDistanceRate.Size = new System.Drawing.Size(260, 51);
            this.gbDistanceRate.TabIndex = 6;
            this.gbDistanceRate.TabStop = false;
            this.gbDistanceRate.Text = "The cost of 1 kilometer";
            // 
            // tbGASPerOne
            // 
            this.tbGASPerOne.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbGASPerOne.Location = new System.Drawing.Point(136, 20);
            this.tbGASPerOne.Name = "tbGASPerOne";
            this.tbGASPerOne.ReadOnly = true;
            this.tbGASPerOne.Size = new System.Drawing.Size(118, 21);
            this.tbGASPerOne.TabIndex = 8;
            this.tbGASPerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPetrolPerOne
            // 
            this.tbPetrolPerOne.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbPetrolPerOne.Location = new System.Drawing.Point(6, 20);
            this.tbPetrolPerOne.Name = "tbPetrolPerOne";
            this.tbPetrolPerOne.ReadOnly = true;
            this.tbPetrolPerOne.Size = new System.Drawing.Size(119, 21);
            this.tbPetrolPerOne.TabIndex = 7;
            this.tbPetrolPerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnCalculate.Location = new System.Drawing.Point(122, 438);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 26);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbPriceCalculator
            // 
            this.gbPriceCalculator.Controls.Add(this.lblDistance);
            this.gbPriceCalculator.Controls.Add(this.lblCost);
            this.gbPriceCalculator.Controls.Add(this.lblSaving);
            this.gbPriceCalculator.Controls.Add(this.tbSavings);
            this.gbPriceCalculator.Controls.Add(this.tbGASPerDistance);
            this.gbPriceCalculator.Controls.Add(this.tbPetrolPerDistance);
            this.gbPriceCalculator.Controls.Add(this.nudDistance);
            this.gbPriceCalculator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPriceCalculator.Location = new System.Drawing.Point(12, 213);
            this.gbPriceCalculator.Name = "gbPriceCalculator";
            this.gbPriceCalculator.Size = new System.Drawing.Size(260, 121);
            this.gbPriceCalculator.TabIndex = 10;
            this.gbPriceCalculator.TabStop = false;
            this.gbPriceCalculator.Text = "Calculating the cost of mileage";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblDistance.Location = new System.Drawing.Point(221, 22);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(26, 16);
            this.lblDistance.TabIndex = 14;
            this.lblDistance.Text = "km.";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblCost.Location = new System.Drawing.Point(6, 22);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 16);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "The cost of";
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblSaving.Location = new System.Drawing.Point(95, 71);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(46, 16);
            this.lblSaving.TabIndex = 12;
            this.lblSaving.Text = "Saving";
            // 
            // tbSavings
            // 
            this.tbSavings.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbSavings.Location = new System.Drawing.Point(6, 90);
            this.tbSavings.Name = "tbSavings";
            this.tbSavings.ReadOnly = true;
            this.tbSavings.Size = new System.Drawing.Size(248, 21);
            this.tbSavings.TabIndex = 11;
            this.tbSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGASPerDistance
            // 
            this.tbGASPerDistance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbGASPerDistance.Location = new System.Drawing.Point(136, 47);
            this.tbGASPerDistance.Name = "tbGASPerDistance";
            this.tbGASPerDistance.ReadOnly = true;
            this.tbGASPerDistance.Size = new System.Drawing.Size(118, 21);
            this.tbGASPerDistance.TabIndex = 10;
            this.tbGASPerDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPetrolPerDistance
            // 
            this.tbPetrolPerDistance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbPetrolPerDistance.Location = new System.Drawing.Point(6, 47);
            this.tbPetrolPerDistance.Name = "tbPetrolPerDistance";
            this.tbPetrolPerDistance.ReadOnly = true;
            this.tbPetrolPerDistance.Size = new System.Drawing.Size(119, 21);
            this.tbPetrolPerDistance.TabIndex = 9;
            this.tbPetrolPerDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDistance
            // 
            this.nudDistance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudDistance.Location = new System.Drawing.Point(73, 20);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(119, 21);
            this.nudDistance.TabIndex = 0;
            this.nudDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDistance.ValueChanged += new System.EventHandler(this.nudDistance_ValueChanged);
            // 
            // lblEquipmentCost
            // 
            this.lblEquipmentCost.AutoSize = true;
            this.lblEquipmentCost.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblEquipmentCost.Location = new System.Drawing.Point(6, 21);
            this.lblEquipmentCost.Name = "lblEquipmentCost";
            this.lblEquipmentCost.Size = new System.Drawing.Size(108, 16);
            this.lblEquipmentCost.TabIndex = 12;
            this.lblEquipmentCost.Text = "Cost of equipment";
            // 
            // nudPriceForParts
            // 
            this.nudPriceForParts.DecimalPlaces = 2;
            this.nudPriceForParts.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nudPriceForParts.Location = new System.Drawing.Point(159, 20);
            this.nudPriceForParts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPriceForParts.Name = "nudPriceForParts";
            this.nudPriceForParts.Size = new System.Drawing.Size(95, 21);
            this.nudPriceForParts.TabIndex = 11;
            this.nudPriceForParts.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tbDistanceForZero
            // 
            this.tbDistanceForZero.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tbDistanceForZero.Location = new System.Drawing.Point(73, 63);
            this.tbDistanceForZero.Name = "tbDistanceForZero";
            this.tbDistanceForZero.ReadOnly = true;
            this.tbDistanceForZero.Size = new System.Drawing.Size(119, 21);
            this.tbDistanceForZero.TabIndex = 13;
            this.tbDistanceForZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEquipmentRePaid
            // 
            this.lblEquipmentRePaid.AutoSize = true;
            this.lblEquipmentRePaid.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblEquipmentRePaid.Location = new System.Drawing.Point(42, 44);
            this.lblEquipmentRePaid.Name = "lblEquipmentRePaid";
            this.lblEquipmentRePaid.Size = new System.Drawing.Size(188, 16);
            this.lblEquipmentRePaid.TabIndex = 14;
            this.lblEquipmentRePaid.Text = "Equipment will be repaid through";
            // 
            // gbDistanceForZero
            // 
            this.gbDistanceForZero.Controls.Add(this.lblDistance2);
            this.gbDistanceForZero.Controls.Add(this.lblEquipmentCost);
            this.gbDistanceForZero.Controls.Add(this.nudPriceForParts);
            this.gbDistanceForZero.Controls.Add(this.tbDistanceForZero);
            this.gbDistanceForZero.Controls.Add(this.lblEquipmentRePaid);
            this.gbDistanceForZero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDistanceForZero.Location = new System.Drawing.Point(12, 340);
            this.gbDistanceForZero.Name = "gbDistanceForZero";
            this.gbDistanceForZero.Size = new System.Drawing.Size(260, 92);
            this.gbDistanceForZero.TabIndex = 15;
            this.gbDistanceForZero.TabStop = false;
            this.gbDistanceForZero.Text = "Calculating payback";
            // 
            // lblDistance2
            // 
            this.lblDistance2.AutoSize = true;
            this.lblDistance2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblDistance2.Location = new System.Drawing.Point(227, 66);
            this.lblDistance2.Name = "lblDistance2";
            this.lblDistance2.Size = new System.Drawing.Size(26, 16);
            this.lblDistance2.TabIndex = 15;
            this.lblDistance2.Text = "km.";
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnSettings.Location = new System.Drawing.Point(12, 438);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(104, 26);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbPump
            // 
            this.pbPump.Image = global::GAS_Calculator.Properties.Resources.pump;
            this.pbPump.InitialImage = null;
            this.pbPump.Location = new System.Drawing.Point(124, 6);
            this.pbPump.Name = "pbPump";
            this.pbPump.Size = new System.Drawing.Size(51, 33);
            this.pbPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPump.TabIndex = 16;
            this.pbPump.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 475);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pbPump);
            this.Controls.Add(this.gbDistanceForZero);
            this.Controls.Add(this.lblGAS);
            this.Controls.Add(this.gbDistanceRate);
            this.Controls.Add(this.gbPetrolRate);
            this.Controls.Add(this.lblPetrol);
            this.Controls.Add(this.gbPriceCalculator);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gas Calculator";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPetrolPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGASPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPetrolRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGASRate)).EndInit();
            this.gbPrice.ResumeLayout(false);
            this.gbPetrolRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTip)).EndInit();
            this.gbDistanceRate.ResumeLayout(false);
            this.gbDistanceRate.PerformLayout();
            this.gbPriceCalculator.ResumeLayout(false);
            this.gbPriceCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceForParts)).EndInit();
            this.gbDistanceForZero.ResumeLayout(false);
            this.gbDistanceForZero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPetrolPrice;
        private System.Windows.Forms.NumericUpDown nudGASPrice;
        private System.Windows.Forms.NumericUpDown nudPetrolRate;
        private System.Windows.Forms.NumericUpDown nudGASRate;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.Label lblGAS;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.GroupBox gbPetrolRate;
        private System.Windows.Forms.GroupBox gbDistanceRate;
        private System.Windows.Forms.TextBox tbGASPerOne;
        private System.Windows.Forms.TextBox tbPetrolPerOne;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbPriceCalculator;
        private System.Windows.Forms.TextBox tbGASPerDistance;
        private System.Windows.Forms.TextBox tbPetrolPerDistance;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label lblSaving;
        private System.Windows.Forms.TextBox tbSavings;
        private System.Windows.Forms.Label lblEquipmentCost;
        private System.Windows.Forms.NumericUpDown nudPriceForParts;
        private System.Windows.Forms.TextBox tbDistanceForZero;
        private System.Windows.Forms.Label lblEquipmentRePaid;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox gbDistanceForZero;
        private System.Windows.Forms.Label lblDistance2;
        private System.Windows.Forms.PictureBox pbPump;
        private System.Windows.Forms.PictureBox pbTip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSettings;
    }
}

