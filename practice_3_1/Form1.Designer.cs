namespace practice_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchStringInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplayInsecure = new System.Windows.Forms.Button();
            this.displayZone = new System.Windows.Forms.TextBox();
            this.btnSwitchModify = new System.Windows.Forms.Button();
            this.btnSwitchHome = new System.Windows.Forms.Button();
            this.label4Link = new System.Windows.Forms.Label();
            this.modifyLinkInput = new System.Windows.Forms.TextBox();
            this.modifyUserInput = new System.Windows.Forms.TextBox();
            this.label4User = new System.Windows.Forms.Label();
            this.modifyPasswordInput = new System.Windows.Forms.TextBox();
            this.label4Password = new System.Windows.Forms.Label();
            this.displayModifyStatus = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            // 
            // searchStringInput
            // 
            this.searchStringInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.searchStringInput.Location = new System.Drawing.Point(136, 31);
            this.searchStringInput.Name = "searchStringInput";
            this.searchStringInput.Size = new System.Drawing.Size(505, 27);
            this.searchStringInput.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(663, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplayInsecure
            // 
            this.btnDisplayInsecure.Location = new System.Drawing.Point(56, 73);
            this.btnDisplayInsecure.Name = "btnDisplayInsecure";
            this.btnDisplayInsecure.Size = new System.Drawing.Size(701, 29);
            this.btnDisplayInsecure.TabIndex = 4;
            this.btnDisplayInsecure.Text = "風險帳號";
            this.btnDisplayInsecure.UseVisualStyleBackColor = true;
            this.btnDisplayInsecure.Click += new System.EventHandler(this.btnDisplayInsecure_Click);
            // 
            // displayZone
            // 
            this.displayZone.Location = new System.Drawing.Point(56, 143);
            this.displayZone.Multiline = true;
            this.displayZone.Name = "displayZone";
            this.displayZone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayZone.Size = new System.Drawing.Size(701, 295);
            this.displayZone.TabIndex = 5;
            this.displayZone.WordWrap = false;
            // 
            // btnSwitchModify
            // 
            this.btnSwitchModify.Location = new System.Drawing.Point(617, 108);
            this.btnSwitchModify.Name = "btnSwitchModify";
            this.btnSwitchModify.Size = new System.Drawing.Size(140, 29);
            this.btnSwitchModify.TabIndex = 6;
            this.btnSwitchModify.Text = "新增或刪除";
            this.btnSwitchModify.UseVisualStyleBackColor = true;
            this.btnSwitchModify.Click += new System.EventHandler(this.btnSwitchModify_Click);
            // 
            // btnSwitchHome
            // 
            this.btnSwitchHome.Location = new System.Drawing.Point(617, 108);
            this.btnSwitchHome.Name = "btnSwitchHome";
            this.btnSwitchHome.Size = new System.Drawing.Size(140, 29);
            this.btnSwitchHome.TabIndex = 7;
            this.btnSwitchHome.Text = "回主畫面";
            this.btnSwitchHome.UseVisualStyleBackColor = true;
            this.btnSwitchHome.Click += new System.EventHandler(this.btnSwitchHome_Click);
            // 
            // label4Link
            // 
            this.label4Link.AutoSize = true;
            this.label4Link.Location = new System.Drawing.Point(205, 218);
            this.label4Link.Name = "label4Link";
            this.label4Link.Size = new System.Drawing.Size(39, 19);
            this.label4Link.TabIndex = 8;
            this.label4Link.Text = "連結";
            // 
            // modifyLinkInput
            // 
            this.modifyLinkInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifyLinkInput.Location = new System.Drawing.Point(290, 215);
            this.modifyLinkInput.Name = "modifyLinkInput";
            this.modifyLinkInput.Size = new System.Drawing.Size(325, 27);
            this.modifyLinkInput.TabIndex = 9;
            this.modifyLinkInput.TextChanged += new System.EventHandler(this.modifyLinkInput_TextChanged);
            // 
            // modifyUserInput
            // 
            this.modifyUserInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifyUserInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modifyUserInput.Location = new System.Drawing.Point(290, 267);
            this.modifyUserInput.Name = "modifyUserInput";
            this.modifyUserInput.Size = new System.Drawing.Size(325, 27);
            this.modifyUserInput.TabIndex = 11;
            this.modifyUserInput.TextChanged += new System.EventHandler(this.modifyUserInput_TextChanged);
            // 
            // label4User
            // 
            this.label4User.AutoSize = true;
            this.label4User.Location = new System.Drawing.Point(205, 270);
            this.label4User.Name = "label4User";
            this.label4User.Size = new System.Drawing.Size(54, 19);
            this.label4User.TabIndex = 10;
            this.label4User.Text = "使用者";
            // 
            // modifyPasswordInput
            // 
            this.modifyPasswordInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifyPasswordInput.Location = new System.Drawing.Point(290, 318);
            this.modifyPasswordInput.Name = "modifyPasswordInput";
            this.modifyPasswordInput.Size = new System.Drawing.Size(325, 27);
            this.modifyPasswordInput.TabIndex = 13;
            this.modifyPasswordInput.TextChanged += new System.EventHandler(this.modifyPasswordInput_TextChanged);
            // 
            // label4Password
            // 
            this.label4Password.AutoSize = true;
            this.label4Password.Location = new System.Drawing.Point(205, 321);
            this.label4Password.Name = "label4Password";
            this.label4Password.Size = new System.Drawing.Size(39, 19);
            this.label4Password.TabIndex = 12;
            this.label4Password.Text = "密碼";
            // 
            // displayModifyStatus
            // 
            this.displayModifyStatus.Location = new System.Drawing.Point(237, 157);
            this.displayModifyStatus.Name = "displayModifyStatus";
            this.displayModifyStatus.ReadOnly = true;
            this.displayModifyStatus.Size = new System.Drawing.Size(343, 27);
            this.displayModifyStatus.TabIndex = 14;
            this.displayModifyStatus.Text = "等待指令";
            this.displayModifyStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(481, 374);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 29);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(551, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 29);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "刪除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.displayModifyStatus);
            this.Controls.Add(this.modifyPasswordInput);
            this.Controls.Add(this.label4Password);
            this.Controls.Add(this.modifyUserInput);
            this.Controls.Add(this.label4User);
            this.Controls.Add(this.modifyLinkInput);
            this.Controls.Add(this.label4Link);
            this.Controls.Add(this.btnSwitchHome);
            this.Controls.Add(this.btnSwitchModify);
            this.Controls.Add(this.displayZone);
            this.Controls.Add(this.btnDisplayInsecure);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchStringInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox searchStringInput;
        private Button btnSearch;
        private Button btnDisplayInsecure;
        private TextBox displayZone;
        private Button btnSwitchModify;
        private Button btnSwitchHome;
        private Label label4Link;
        private TextBox modifyLinkInput;
        private TextBox modifyUserInput;
        private Label label4User;
        private TextBox modifyPasswordInput;
        private Label label4Password;
        private TextBox displayModifyStatus;
        private Button btnInsert;
        private Button btnRemove;
    }
}