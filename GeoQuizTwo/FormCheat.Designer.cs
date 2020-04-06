namespace GeoQuizTwo
{
    partial class FormCheat
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(120, 83);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(185, 25);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer goes here";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(80, 154);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(113, 44);
            this.btnLazy.TabIndex = 1;
            this.btnLazy.Text = "I\'m Lazy!";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLazy);
            this.Controls.Add(this.lblAnswer);
            this.Name = "FormCheat";
            this.Text = "FormCheat";
            this.Load += new System.EventHandler(this.FormCheat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnClose;
    }
}