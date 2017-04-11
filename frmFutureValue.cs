using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        int rowIndex = 0;
        string[,] strArray = new string[10, 4];

        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void frmFutureValue_Load(object sender, EventArgs e)
        {
            txtMthlySavingsAmt.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal mthlySavingsAmt = 0m;
            decimal annualInterestRate = 0;
            decimal monthlyInterestRate = 0;
            int numYears = 0;
            int numMonths = 0;
            decimal futureValue = 0m;

            if (IsValidData())
            {
                mthlySavingsAmt = Convert.ToDecimal(txtMthlySavingsAmt.Text);
                annualInterestRate = Convert.ToDecimal(txtAnnualInterestRate.Text);
                numYears = Convert.ToInt32(txtNumYears.Text);
                numMonths = numYears * 12;
                monthlyInterestRate = annualInterestRate / 12 / 100;

                for (var i = 0; i < numMonths; i++)
                {
                    futureValue = (futureValue + mthlySavingsAmt)
                        * (1 + monthlyInterestRate);
                }

                txtMthlySavingsAmt.Text = mthlySavingsAmt.ToString("c");
                txtAnnualInterestRate.Text = (annualInterestRate / 100).ToString("p1");
                txtNumYears.Text = numYears.ToString("");
                txtFutureValue.Text = futureValue.ToString("c");

                strArray[rowIndex, 0] = mthlySavingsAmt.ToString("c");
                strArray[rowIndex, 1] = (annualInterestRate / 100).ToString("p1");
                strArray[rowIndex, 2] = numYears.ToString("");
                strArray[rowIndex, 3] = futureValue.ToString("c");
                rowIndex++;

                btnClearTotals.Focus();
            }
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtMthlySavingsAmt, "Monthly Savings Amount") &&
                IsPresent(txtAnnualInterestRate, "Annual Interest Rate") &&
                IsPresent(txtNumYears, "Number of Years") &&

                IsNumeric(txtMthlySavingsAmt, "Monthly Savings Ammount") &&
                IsNumeric(txtAnnualInterestRate, "Annual Interest Rate") &&
                IsNumeric(txtNumYears, "Number of Years");
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Data Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsNumeric(TextBox textBox, string name)
        {
            decimal input = 0;
            try
            {
                if (textBox.Text == txtMthlySavingsAmt.Text)
                {
                    input = decimal.Parse(txtMthlySavingsAmt.Text, NumberStyles.Currency);
                    txtMthlySavingsAmt.Text = Convert.ToString(input);
                }
                else if (textBox.Text == txtAnnualInterestRate.Text || textBox.Text == txtNumYears.Text)
                {
                    input = Convert.ToDecimal(Regex.Match(textBox.Text, "\\d").Value);
                    textBox.Text = Convert.ToString(input);
                }
                return true;
            }
            catch
            {
                MessageBox.Show(name + " can only contain numbers.", "Data Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string strData = "";
            for (int i = 0; i < strArray.GetLength(0); i++)
            {
                for (int j = 0; j < strArray.GetLength(1); j++)
                {
                    strData += strArray[i, j] + "\t";
                }
                strData += "\n";
            }
            MessageBox.Show(strData, "Invoice History");

            this.Close();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            txtMthlySavingsAmt.Text = "";
            txtAnnualInterestRate.Text = "";
            txtNumYears.Text = "";
            txtFutureValue.Text = "";

            txtMthlySavingsAmt.Focus();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }
    }
}
