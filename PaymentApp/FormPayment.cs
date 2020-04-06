using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PaymentApp
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("MasterCard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months = {"Select a month...", "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"};
            cboMonth.Items.AddRange(months);
            cboMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
                DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if(lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a credit card type", "Error");
                    lstCreditCardType.Focus();
                    return false;
                }

                // check that there is a card number inputted and that it's a number
                if (String.IsNullOrEmpty(txtCardNumber.Text) || !int.TryParse(txtCardNumber.Text, out int result))
                {
                    MessageBox.Show("Enter a valid credit card number", "Error");
                    txtCardNumber.Focus();
                    return false;
                }

                if (cboMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("Select a month", "Error");
                    cboMonth.Focus();
                    return false;
                }

                if (cboYear.SelectedIndex == 0)
                {
                    MessageBox.Show("Select a year", "Error");
                    cboYear.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            // build a string with the customer's billing info
            StringBuilder billingDataBuilder = new StringBuilder();

            if (rdoCreditCard.Checked)
            {
                billingDataBuilder.Append("Charge to credit card.\n\n");
                billingDataBuilder.Append($"Card type: {lstCreditCardType.Text}\n");
                billingDataBuilder.Append($"Card number: {txtCardNumber.Text}\n");
                billingDataBuilder.Append($"Expiration date: {cboMonth.SelectedItem}/{cboYear.SelectedItem}\n");
            }
            else
            {
                billingDataBuilder.Append("Send bill to customer.\n\n");
            }

            bool makeDefault = chkDefault.Checked;
            billingDataBuilder.Append($"Default billing method: {makeDefault}");

            string billingData = billingDataBuilder.ToString();
            Tag = billingData;
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboMonth.Enabled = true;
            cboYear.Enabled = true;
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboMonth.Enabled = false;
            cboYear.Enabled = false;
        }
    }
}
