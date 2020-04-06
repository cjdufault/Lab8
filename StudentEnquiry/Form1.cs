using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnquiry
{
    public partial class Form1 : Form
    {
        SortedList<string, string[]> programs;

        string[] ITPrograms = { "Programming", "Security", "Networking" };
        string[] EngineeringPrograms = { "Electrical", "Mechanical" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programs = new SortedList<string, string[]>
            {
                { "Information Technology", ITPrograms },
                { "Engineering", EngineeringPrograms }
            };

            cbxDepartment.Items.AddRange(programs.Keys.ToArray());
            cbxDepartment.SelectedIndex = 0;

            cbxHowDidYouHear.Items.Add("Another Student");
            cbxHowDidYouHear.Items.Add("Another School");
            cbxHowDidYouHear.Items.Add("Web Search");
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department = cbxDepartment.Text;

            lstDegrees.Items.Clear();

            if (department != null)
            {
                string[] degrees = programs[department];
                lstDegrees.Items.AddRange(degrees);
            }

            // reset lblDegrees to say 0 selected
            UpdateSelectedCount();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (cbxDepartment.SelectedIndex == -1)
            {
                errors.Add("Select a department");
            }

            if (lstDegrees.SelectedIndex == -1)
            {
                errors.Add("Select at least one degree");
            }

            if (String.IsNullOrEmpty(cbxHowDidYouHear.Text))
            {
                errors.Add("Type or select how you heard about us");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(String.Join("\n", errors), "Error");
                return;
            }

            StringBuilder summaryBuilder = new StringBuilder();
            int selectedCount = lstDegrees.SelectedItems.Count;

            summaryBuilder.Append("Summary\n\nDepartment: ");
            summaryBuilder.Append(cbxDepartment.Text);
            summaryBuilder.Append($"\n\nPrograms: {selectedCount} selected\n");

            foreach (string degree in lstDegrees.SelectedItems)
            {
                summaryBuilder.Append(degree);
                summaryBuilder.Append("\n");
            }

            summaryBuilder.Append("You heard about us from: ");
            summaryBuilder.Append(cbxHowDidYouHear.Text);

            string summary = summaryBuilder.ToString();

            MessageBox.Show(summary, "Thank You!");
            this.Close();
        }

        private void lstDegrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedCount();
        }

        // updates lblDegrees to reflect the number of items selected
        private void UpdateSelectedCount()
        {
            int selectedCount = lstDegrees.SelectedItems.Count;
            lblDegrees.Text = $"{selectedCount} selected";
        }
    }
}
