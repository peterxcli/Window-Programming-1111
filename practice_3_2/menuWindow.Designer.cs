namespace practice_3_2
{
    partial class menuWindow
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
            this.displayInputStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inStack1 = new System.Windows.Forms.TextBox();
            this.inStack2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inStack3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inStack4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayInputStatus
            // 
            this.displayInputStatus.Location = new System.Drawing.Point(85, 31);
            this.displayInputStatus.Name = "displayInputStatus";
            this.displayInputStatus.ReadOnly = true;
            this.displayInputStatus.Size = new System.Drawing.Size(307, 27);
            this.displayInputStatus.TabIndex = 0;
            this.displayInputStatus.Text = "請輸入測資";
            this.displayInputStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "堆疊一";
            // 
            // inStack1
            // 
            this.inStack1.Location = new System.Drawing.Point(95, 131);
            this.inStack1.Name = "inStack1";
            this.inStack1.Size = new System.Drawing.Size(357, 27);
            this.inStack1.TabIndex = 2;
            // 
            // inStack2
            // 
            this.inStack2.Location = new System.Drawing.Point(95, 199);
            this.inStack2.Name = "inStack2";
            this.inStack2.Size = new System.Drawing.Size(357, 27);
            this.inStack2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "堆疊二";
            // 
            // inStack3
            // 
            this.inStack3.Location = new System.Drawing.Point(95, 261);
            this.inStack3.Name = "inStack3";
            this.inStack3.Size = new System.Drawing.Size(357, 27);
            this.inStack3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "堆疊三";
            // 
            // inStack4
            // 
            this.inStack4.Location = new System.Drawing.Point(95, 337);
            this.inStack4.Name = "inStack4";
            this.inStack4.Size = new System.Drawing.Size(357, 27);
            this.inStack4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "堆疊四";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(180, 388);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 43);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.inStack4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inStack3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inStack2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inStack1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayInputStatus);
            this.Name = "menuWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox displayInputStatus;
        private Label label1;
        private TextBox inStack1;
        private TextBox inStack2;
        private Label label2;
        private TextBox inStack3;
        private Label label3;
        private TextBox inStack4;
        private Label label4;
        private Button btnStart;
    }
}