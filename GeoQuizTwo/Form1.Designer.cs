namespace GeoQuizTwo
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.btnCheat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(58, 58);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(590, 133);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question goes here";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(58, 202);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.txtAnswer.MaxLength = 20;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(358, 31);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(478, 196);
            this.btnCheckAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(170, 44);
            this.btnCheckAnswer.TabIndex = 2;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(478, 259);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(170, 45);
            this.btnCheat.TabIndex = 3;
            this.btnCheat.Text = "Cheat!";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheckAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 344);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = " Geography Quiz: Return of the Maps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button btnCheat;
    }
}

