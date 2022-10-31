namespace practice_6_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.Telephone = new System.Windows.Forms.TabPage();
            this.displayNumber = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TabPage();
            this.histoty = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputFilename = new System.Windows.Forms.TextBox();
            this.mainTab.SuspendLayout();
            this.Telephone.SuspendLayout();
            this.Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.Telephone);
            this.mainTab.Controls.Add(this.Log);
            this.mainTab.Location = new System.Drawing.Point(12, 12);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(776, 632);
            this.mainTab.TabIndex = 0;
            this.mainTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTab_KeyDown);
            this.mainTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainTab_KeyUp);
            // 
            // Telephone
            // 
            this.Telephone.Controls.Add(this.displayNumber);
            this.Telephone.Location = new System.Drawing.Point(4, 22);
            this.Telephone.Name = "Telephone";
            this.Telephone.Padding = new System.Windows.Forms.Padding(3);
            this.Telephone.Size = new System.Drawing.Size(768, 606);
            this.Telephone.TabIndex = 0;
            this.Telephone.Text = "Telephone";
            this.Telephone.UseVisualStyleBackColor = true;
            // 
            // displayNumber
            // 
            this.displayNumber.Location = new System.Drawing.Point(28, 17);
            this.displayNumber.Name = "displayNumber";
            this.displayNumber.Size = new System.Drawing.Size(734, 53);
            this.displayNumber.TabIndex = 0;
            this.displayNumber.Text = "Telephone";
            // 
            // Log
            // 
            this.Log.Controls.Add(this.histoty);
            this.Log.Controls.Add(this.btnSaveFile);
            this.Log.Controls.Add(this.label1);
            this.Log.Controls.Add(this.inputFilename);
            this.Log.Location = new System.Drawing.Point(4, 22);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(768, 606);
            this.Log.TabIndex = 1;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // histoty
            // 
            this.histoty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.histoty.Font = new System.Drawing.Font("新細明體", 14F);
            this.histoty.Location = new System.Drawing.Point(40, 87);
            this.histoty.Name = "histoty";
            this.histoty.Size = new System.Drawing.Size(693, 496);
            this.histoty.TabIndex = 3;
            this.histoty.Text = "label2";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSaveFile.Location = new System.Drawing.Point(658, 38);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "save";
            // 
            // inputFilename
            // 
            this.inputFilename.Location = new System.Drawing.Point(92, 40);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(538, 22);
            this.inputFilename.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTab.ResumeLayout(false);
            this.Telephone.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.Log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage Telephone;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.Label displayNumber;
        private System.Windows.Forms.TextBox inputFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label histoty;
    }
}

