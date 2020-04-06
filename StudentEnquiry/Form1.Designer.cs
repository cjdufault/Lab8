namespace StudentEnquiry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.cbxHowDidYouHear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDegrees = new System.Windows.Forms.Label();
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "What department are you interested in?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "What degree programs are you interesteed in?";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(60, 91);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(564, 33);
            this.cbxDepartment.TabIndex = 0;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // cbxHowDidYouHear
            // 
            this.cbxHowDidYouHear.FormattingEnabled = true;
            this.cbxHowDidYouHear.Location = new System.Drawing.Point(60, 462);
            this.cbxHowDidYouHear.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHowDidYouHear.Name = "cbxHowDidYouHear";
            this.cbxHowDidYouHear.Size = new System.Drawing.Size(564, 33);
            this.cbxHowDidYouHear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "How did you hear about us?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 526);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 47);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDegrees
            // 
            this.lblDegrees.AutoSize = true;
            this.lblDegrees.Location = new System.Drawing.Point(512, 354);
            this.lblDegrees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegrees.Name = "lblDegrees";
            this.lblDegrees.Size = new System.Drawing.Size(114, 25);
            this.lblDegrees.TabIndex = 7;
            this.lblDegrees.Text = "0 Selected";
            this.lblDegrees.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstDegrees
            // 
            this.lstDegrees.FormattingEnabled = true;
            this.lstDegrees.ItemHeight = 25;
            this.lstDegrees.Location = new System.Drawing.Point(60, 217);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDegrees.Size = new System.Drawing.Size(566, 129);
            this.lstDegrees.TabIndex = 8;
            this.lstDegrees.SelectedIndexChanged += new System.EventHandler(this.lstDegrees_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 616);
            this.Controls.Add(this.lstDegrees);
            this.Controls.Add(this.lblDegrees);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxHowDidYouHear);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Enquiry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ComboBox cbxHowDidYouHear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDegrees;
        private System.Windows.Forms.ListBox lstDegrees;
    }
}

