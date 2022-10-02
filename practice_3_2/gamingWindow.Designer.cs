namespace practice_3_2
{
    partial class gamingWindow
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
            this.btnStack0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stack0 = new System.Windows.Forms.TextBox();
            this.stack1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stack2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stack3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStack1 = new System.Windows.Forms.Button();
            this.btnStack2 = new System.Windows.Forms.Button();
            this.btnStack3 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.displayResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStack0
            // 
            this.btnStack0.Location = new System.Drawing.Point(27, 402);
            this.btnStack0.Name = "btnStack0";
            this.btnStack0.Size = new System.Drawing.Size(59, 38);
            this.btnStack0.TabIndex = 0;
            this.btnStack0.Text = "選取";
            this.btnStack0.UseVisualStyleBackColor = true;
            this.btnStack0.Click += new System.EventHandler(this.btnStack0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "堆疊一";
            // 
            // stack0
            // 
            this.stack0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stack0.Location = new System.Drawing.Point(27, 62);
            this.stack0.Multiline = true;
            this.stack0.Name = "stack0";
            this.stack0.ReadOnly = true;
            this.stack0.Size = new System.Drawing.Size(60, 310);
            this.stack0.TabIndex = 2;
            // 
            // stack1
            // 
            this.stack1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stack1.Location = new System.Drawing.Point(144, 62);
            this.stack1.Multiline = true;
            this.stack1.Name = "stack1";
            this.stack1.ReadOnly = true;
            this.stack1.Size = new System.Drawing.Size(60, 310);
            this.stack1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "堆疊二";
            // 
            // stack2
            // 
            this.stack2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stack2.Location = new System.Drawing.Point(262, 62);
            this.stack2.Multiline = true;
            this.stack2.Name = "stack2";
            this.stack2.ReadOnly = true;
            this.stack2.Size = new System.Drawing.Size(60, 310);
            this.stack2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "堆疊三";
            // 
            // stack3
            // 
            this.stack3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stack3.Location = new System.Drawing.Point(397, 62);
            this.stack3.Multiline = true;
            this.stack3.Name = "stack3";
            this.stack3.ReadOnly = true;
            this.stack3.Size = new System.Drawing.Size(60, 310);
            this.stack3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "堆疊四";
            // 
            // btnStack1
            // 
            this.btnStack1.Location = new System.Drawing.Point(144, 402);
            this.btnStack1.Name = "btnStack1";
            this.btnStack1.Size = new System.Drawing.Size(59, 38);
            this.btnStack1.TabIndex = 9;
            this.btnStack1.Text = "選取";
            this.btnStack1.UseVisualStyleBackColor = true;
            this.btnStack1.Click += new System.EventHandler(this.btnStack1_Click);
            // 
            // btnStack2
            // 
            this.btnStack2.Location = new System.Drawing.Point(262, 402);
            this.btnStack2.Name = "btnStack2";
            this.btnStack2.Size = new System.Drawing.Size(59, 38);
            this.btnStack2.TabIndex = 10;
            this.btnStack2.Text = "選取";
            this.btnStack2.UseVisualStyleBackColor = true;
            this.btnStack2.Click += new System.EventHandler(this.btnStack2_Click);
            // 
            // btnStack3
            // 
            this.btnStack3.Location = new System.Drawing.Point(397, 402);
            this.btnStack3.Name = "btnStack3";
            this.btnStack3.Size = new System.Drawing.Size(59, 38);
            this.btnStack3.TabIndex = 11;
            this.btnStack3.Text = "選取";
            this.btnStack3.UseVisualStyleBackColor = true;
            this.btnStack3.Click += new System.EventHandler(this.btnStack3_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(241, 502);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(173, 60);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "回主畫面";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // displayResult
            // 
            this.displayResult.Location = new System.Drawing.Point(27, 502);
            this.displayResult.Multiline = true;
            this.displayResult.Name = "displayResult";
            this.displayResult.Size = new System.Drawing.Size(193, 60);
            this.displayResult.TabIndex = 13;
            // 
            // gamingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.displayResult);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnStack3);
            this.Controls.Add(this.btnStack2);
            this.Controls.Add(this.btnStack1);
            this.Controls.Add(this.stack3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stack2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stack1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stack0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStack0);
            this.Name = "gamingWindow";
            this.Text = "game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStack0;
        private Label label1;
        private TextBox stack0;
        private TextBox stack1;
        private Label label2;
        private TextBox stack2;
        private Label label3;
        private TextBox stack3;
        private Label label4;
        private Button btnStack1;
        private Button btnStack2;
        private Button btnStack3;
        private Button btnMenu;
        private TextBox displayResult;
    }
}