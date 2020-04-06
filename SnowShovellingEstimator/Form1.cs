using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowShovellingEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // configure date picker
            dteAppointmentDate.MinDate = DateTime.Today;
            dteAppointmentDate.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnSpecialRequests_Click(object sender, EventArgs e)
        {
            FormSpecialRequests frmSpecialRequests = new FormSpecialRequests();
            frmSpecialRequests.Tag = lblSpecialRequests.Text;
            DialogResult specialRequestsResults = frmSpecialRequests.ShowDialog();

            if (specialRequestsResults == DialogResult.OK &&
                frmSpecialRequests.Tag is string specialRequests)
            {
                lblSpecialRequests.Text = specialRequests;
            }
        }

        private void btnGetEstimate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            DateTime date = dteAppointmentDate.Value;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || date == null)
            {
                MessageBox.Show("All fields must be filled in", "Error");
                return;
            }

            double price;
            if (rdoSingle.Checked)
            {
                price = 20;
            }
            else
            {
                price = 30;
            }

            // $5 premium for same-day service
            if (date.Date == DateTime.Today)
            {
                price += 5;
            }

            txtEstPrice.Text = $"{price:c}";
        }
    }
}
