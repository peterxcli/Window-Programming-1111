namespace practice_5_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputWord = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.displayAnswer = new System.Windows.Forms.Label();
            this.displayErrorTime = new System.Windows.Forms.Label();
            this.displayTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(314, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(314, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入要猜的英文單字:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputWord
            // 
            this.inputWord.Location = new System.Drawing.Point(334, 227);
            this.inputWord.Name = "inputWord";
            this.inputWord.Size = new System.Drawing.Size(139, 22);
            this.inputWord.TabIndex = 2;
            this.inputWord.TextChanged += new System.EventHandler(this.inputWord_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(334, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 66);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // displayAnswer
            // 
            this.displayAnswer.Location = new System.Drawing.Point(21, 289);
            this.displayAnswer.Name = "displayAnswer";
            this.displayAnswer.Size = new System.Drawing.Size(776, 68);
            this.displayAnswer.TabIndex = 4;
            this.displayAnswer.Text = "label3";
            this.displayAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayErrorTime
            // 
            this.displayErrorTime.AutoSize = true;
            this.displayErrorTime.Location = new System.Drawing.Point(663, 117);
            this.displayErrorTime.Name = "displayErrorTime";
            this.displayErrorTime.Size = new System.Drawing.Size(33, 12);
            this.displayErrorTime.TabIndex = 5;
            this.displayErrorTime.Text = "label4";
            // 
            // displayTime
            // 
            this.displayTime.AutoSize = true;
            this.displayTime.Location = new System.Drawing.Point(665, 75);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(33, 12);
            this.displayTime.TabIndex = 6;
            this.displayTime.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTime);
            this.Controls.Add(this.displayErrorTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.inputWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputWord;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label displayAnswer;
        private System.Windows.Forms.Label displayErrorTime;
        private System.Windows.Forms.Label displayTime;
        private System.Windows.Forms.Timer timer1;
    }
}

