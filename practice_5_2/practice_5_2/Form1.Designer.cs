namespace practice_5_2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.displayP1Turn = new System.Windows.Forms.Label();
            this.displayP2Turn = new System.Windows.Forms.Label();
            this.displayTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.displayP1Status = new System.Windows.Forms.Label();
            this.displayP2Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(319, 162);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 114);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // displayP1Turn
            // 
            this.displayP1Turn.Location = new System.Drawing.Point(68, 75);
            this.displayP1Turn.Name = "displayP1Turn";
            this.displayP1Turn.Size = new System.Drawing.Size(100, 42);
            this.displayP1Turn.TabIndex = 1;
            this.displayP1Turn.Text = "label1";
            this.displayP1Turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayP2Turn
            // 
            this.displayP2Turn.Location = new System.Drawing.Point(649, 75);
            this.displayP2Turn.Name = "displayP2Turn";
            this.displayP2Turn.Size = new System.Drawing.Size(100, 42);
            this.displayP2Turn.TabIndex = 2;
            this.displayP2Turn.Text = "label2";
            this.displayP2Turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayTimer
            // 
            this.displayTimer.Location = new System.Drawing.Point(371, 9);
            this.displayTimer.Name = "displayTimer";
            this.displayTimer.Size = new System.Drawing.Size(100, 23);
            this.displayTimer.TabIndex = 3;
            this.displayTimer.Text = "label3";
            this.displayTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // displayP1Status
            // 
            this.displayP1Status.Location = new System.Drawing.Point(68, 136);
            this.displayP1Status.Name = "displayP1Status";
            this.displayP1Status.Size = new System.Drawing.Size(100, 132);
            this.displayP1Status.TabIndex = 4;
            this.displayP1Status.Text = "label1";
            // 
            // displayP2Status
            // 
            this.displayP2Status.Location = new System.Drawing.Point(649, 136);
            this.displayP2Status.Name = "displayP2Status";
            this.displayP2Status.Size = new System.Drawing.Size(100, 132);
            this.displayP2Status.TabIndex = 5;
            this.displayP2Status.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTimer);
            this.Controls.Add(this.displayP2Turn);
            this.Controls.Add(this.displayP1Turn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.displayP1Status);
            this.Controls.Add(this.displayP2Status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label displayP1Turn;
        private System.Windows.Forms.Label displayP2Turn;
        private System.Windows.Forms.Label displayTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label displayP1Status;
        private System.Windows.Forms.Label displayP2Status;
    }
}

