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
    public partial class FormSpecialRequests : Form
    {
        private bool Saved = false;

        public FormSpecialRequests()
        {
            InitializeComponent();
        }

        private void FormSpecialRequests_Load(object sender, EventArgs e)
        {
            txtRequests.Text = Tag.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // store requests in form's Tag property, set DialogResult to OK, and exit
            Tag = txtRequests.Text;
            // set Saved to show changes are saved
            Saved = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // checks to make sure user wants to discard any unsaved changes
        private void frmSpecialRequests_Close(object sender, FormClosingEventArgs e)
        {
            // check if anything has changed
            bool userMadeChanges = Tag.ToString() != txtRequests.Text;

            // if unsaved and there are changes
            if (!Saved && userMadeChanges)
            {
                DialogResult closeResult = MessageBox.Show("There are unsaved changes. Close anyway?",
                    "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (closeResult == DialogResult.No)
                {
                    e.Cancel = true; // stops form from closing
                }
            }

            // if there are no unsaved changes or the user chooses not to saved changes, 
            // allow the form to close
        }
    }
}
