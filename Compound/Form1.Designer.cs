namespace Compound
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapi = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(554, 204);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(94, 29);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Principal:";
            // 
            // txtCapi
            // 
            this.txtCapi.Location = new System.Drawing.Point(191, 71);
            this.txtCapi.Name = "txtCapi";
            this.txtCapi.Size = new System.Drawing.Size(125, 27);
            this.txtCapi.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(523, 85);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 27);
            this.txtYear.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Years:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(191, 204);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(125, 27);
            this.txtRate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCal;
        private Label label1;
        private TextBox txtCapi;
        private TextBox txtYear;
        private Label label2;
        private TextBox txtRate;
        private Label label3;
        private Label label4;
    }
}