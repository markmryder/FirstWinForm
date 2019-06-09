namespace MarkRyderAssignment1
{
	partial class Form1
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
			this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
			this.txtHours = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblHours = new System.Windows.Forms.Label();
			this.lblRate = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.grpResults = new System.Windows.Forms.GroupBox();
			this.txtNet = new System.Windows.Forms.TextBox();
			this.txtTaxes = new System.Windows.Forms.TextBox();
			this.txtGross = new System.Windows.Forms.TextBox();
			this.lblNetPay = new System.Windows.Forms.Label();
			this.lblTaxes = new System.Windows.Forms.Label();
			this.lblGross = new System.Windows.Forms.Label();
			this.lblEmployee = new System.Windows.Forms.Label();
			this.cmbEmployees = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.grpEmployeeInfo.SuspendLayout();
			this.grpResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpEmployeeInfo
			// 
			this.grpEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpEmployeeInfo.Controls.Add(this.txtHours);
			this.grpEmployeeInfo.Controls.Add(this.txtRate);
			this.grpEmployeeInfo.Controls.Add(this.txtName);
			this.grpEmployeeInfo.Controls.Add(this.lblHours);
			this.grpEmployeeInfo.Controls.Add(this.lblRate);
			this.grpEmployeeInfo.Controls.Add(this.lblName);
			this.grpEmployeeInfo.Location = new System.Drawing.Point(13, 13);
			this.grpEmployeeInfo.Name = "grpEmployeeInfo";
			this.grpEmployeeInfo.Size = new System.Drawing.Size(307, 107);
			this.grpEmployeeInfo.TabIndex = 0;
			this.grpEmployeeInfo.TabStop = false;
			this.grpEmployeeInfo.Text = "Employee Information";
			// 
			// txtHours
			// 
			this.txtHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHours.Location = new System.Drawing.Point(97, 82);
			this.txtHours.Name = "txtHours";
			this.txtHours.Size = new System.Drawing.Size(204, 20);
			this.txtHours.TabIndex = 5;
			// 
			// txtRate
			// 
			this.txtRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRate.Location = new System.Drawing.Point(97, 50);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(204, 20);
			this.txtRate.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(97, 20);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(204, 20);
			this.txtName.TabIndex = 3;
			// 
			// lblHours
			// 
			this.lblHours.AutoSize = true;
			this.lblHours.Location = new System.Drawing.Point(6, 85);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(76, 13);
			this.lblHours.TabIndex = 2;
			this.lblHours.Text = "Hours Worked";
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Location = new System.Drawing.Point(6, 53);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(81, 13);
			this.lblRate.TabIndex = 1;
			this.lblRate.Text = "Hourly Rate ($):";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 23);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(13, 148);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(245, 148);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// grpResults
			// 
			this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.grpResults.Controls.Add(this.txtNet);
			this.grpResults.Controls.Add(this.txtTaxes);
			this.grpResults.Controls.Add(this.txtGross);
			this.grpResults.Controls.Add(this.lblNetPay);
			this.grpResults.Controls.Add(this.lblTaxes);
			this.grpResults.Controls.Add(this.lblGross);
			this.grpResults.Location = new System.Drawing.Point(12, 203);
			this.grpResults.Name = "grpResults";
			this.grpResults.Size = new System.Drawing.Size(308, 120);
			this.grpResults.TabIndex = 3;
			this.grpResults.TabStop = false;
			this.grpResults.Text = "Calculated Wage";
			// 
			// txtNet
			// 
			this.txtNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNet.Location = new System.Drawing.Point(98, 85);
			this.txtNet.Name = "txtNet";
			this.txtNet.Size = new System.Drawing.Size(204, 20);
			this.txtNet.TabIndex = 11;
			// 
			// txtTaxes
			// 
			this.txtTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTaxes.Location = new System.Drawing.Point(98, 53);
			this.txtTaxes.Name = "txtTaxes";
			this.txtTaxes.Size = new System.Drawing.Size(204, 20);
			this.txtTaxes.TabIndex = 10;
			// 
			// txtGross
			// 
			this.txtGross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGross.Location = new System.Drawing.Point(98, 23);
			this.txtGross.Name = "txtGross";
			this.txtGross.Size = new System.Drawing.Size(204, 20);
			this.txtGross.TabIndex = 9;
			// 
			// lblNetPay
			// 
			this.lblNetPay.AutoSize = true;
			this.lblNetPay.Location = new System.Drawing.Point(7, 88);
			this.lblNetPay.Name = "lblNetPay";
			this.lblNetPay.Size = new System.Drawing.Size(63, 13);
			this.lblNetPay.TabIndex = 8;
			this.lblNetPay.Text = "Net Pay ($):";
			// 
			// lblTaxes
			// 
			this.lblTaxes.AutoSize = true;
			this.lblTaxes.Location = new System.Drawing.Point(7, 56);
			this.lblTaxes.Name = "lblTaxes";
			this.lblTaxes.Size = new System.Drawing.Size(54, 13);
			this.lblTaxes.TabIndex = 7;
			this.lblTaxes.Text = "Taxes ($):";
			// 
			// lblGross
			// 
			this.lblGross.AutoSize = true;
			this.lblGross.Location = new System.Drawing.Point(7, 26);
			this.lblGross.Name = "lblGross";
			this.lblGross.Size = new System.Drawing.Size(73, 13);
			this.lblGross.TabIndex = 6;
			this.lblGross.Text = "Gross Pay ($):";
			// 
			// lblEmployee
			// 
			this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.Location = new System.Drawing.Point(22, 373);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(56, 13);
			this.lblEmployee.TabIndex = 4;
			this.lblEmployee.Text = "Employee:";
			// 
			// cmbEmployees
			// 
			this.cmbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbEmployees.FormattingEnabled = true;
			this.cmbEmployees.Location = new System.Drawing.Point(110, 370);
			this.cmbEmployees.Name = "cmbEmployees";
			this.cmbEmployees.Size = new System.Drawing.Size(204, 21);
			this.cmbEmployees.TabIndex = 5;
			this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(245, 415);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.cmbEmployees);
			this.Controls.Add(this.lblEmployee);
			this.Controls.Add(this.grpResults);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.grpEmployeeInfo);
			this.Name = "Form1";
			this.Text = "Wage Calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
			this.grpEmployeeInfo.ResumeLayout(false);
			this.grpEmployeeInfo.PerformLayout();
			this.grpResults.ResumeLayout(false);
			this.grpResults.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpEmployeeInfo;
		private System.Windows.Forms.TextBox txtHours;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label lblRate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.GroupBox grpResults;
		private System.Windows.Forms.TextBox txtNet;
		private System.Windows.Forms.TextBox txtTaxes;
		private System.Windows.Forms.TextBox txtGross;
		private System.Windows.Forms.Label lblNetPay;
		private System.Windows.Forms.Label lblTaxes;
		private System.Windows.Forms.Label lblGross;
		private System.Windows.Forms.Label lblEmployee;
		private System.Windows.Forms.ComboBox cmbEmployees;
		private System.Windows.Forms.Button btnClose;
	}
}

