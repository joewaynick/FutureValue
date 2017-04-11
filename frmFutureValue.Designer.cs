namespace FutureValue
{
    partial class frmFutureValue
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
            this.lnlMthlySavingsAmt = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNumYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.txtMthlySavingsAmt = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lnlMthlySavingsAmt
            // 
            this.lnlMthlySavingsAmt.AutoSize = true;
            this.lnlMthlySavingsAmt.Location = new System.Drawing.Point(96, 77);
            this.lnlMthlySavingsAmt.Name = "lnlMthlySavingsAmt";
            this.lnlMthlySavingsAmt.Size = new System.Drawing.Size(167, 17);
            this.lnlMthlySavingsAmt.TabIndex = 0;
            this.lnlMthlySavingsAmt.Text = "Monthly Savings Amount:";
            this.lnlMthlySavingsAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(126, 108);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(141, 17);
            this.lblAnnualInterestRate.TabIndex = 1;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate:";
            this.lblAnnualInterestRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumYears
            // 
            this.lblNumYears.AutoSize = true;
            this.lblNumYears.Location = new System.Drawing.Point(141, 139);
            this.lblNumYears.Name = "lblNumYears";
            this.lblNumYears.Size = new System.Drawing.Size(122, 17);
            this.lblNumYears.TabIndex = 2;
            this.lblNumYears.Text = "Number Of Years:";
            this.lblNumYears.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Location = new System.Drawing.Point(170, 175);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(93, 17);
            this.lblFutureValue.TabIndex = 3;
            this.lblFutureValue.Text = "Future Value:";
            this.lblFutureValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMthlySavingsAmt
            // 
            this.txtMthlySavingsAmt.Location = new System.Drawing.Point(299, 72);
            this.txtMthlySavingsAmt.Name = "txtMthlySavingsAmt";
            this.txtMthlySavingsAmt.Size = new System.Drawing.Size(100, 22);
            this.txtMthlySavingsAmt.TabIndex = 1;
            this.txtMthlySavingsAmt.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(299, 103);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtAnnualInterestRate.TabIndex = 2;
            this.txtAnnualInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtNumYears
            // 
            this.txtNumYears.Location = new System.Drawing.Point(299, 136);
            this.txtNumYears.Name = "txtNumYears";
            this.txtNumYears.Size = new System.Drawing.Size(100, 22);
            this.txtNumYears.TabIndex = 3;
            this.txtNumYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(99, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTotals.Location = new System.Drawing.Point(211, 226);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(117, 23);
            this.btnClearTotals.TabIndex = 5;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Calculate the Future Value of Monthly Savings";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(345, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(299, 169);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 22);
            this.txtFutureValue.TabIndex = 14;
            this.txtFutureValue.TabStop = false;
            // 
            // frmFutureValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 292);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumYears);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.txtMthlySavingsAmt);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumYears);
            this.Controls.Add(this.lblAnnualInterestRate);
            this.Controls.Add(this.lnlMthlySavingsAmt);
            this.Name = "frmFutureValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.frmFutureValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlMthlySavingsAmt;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNumYears;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.TextBox txtMthlySavingsAmt;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtNumYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFutureValue;
    }
}

