namespace practice_7_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayUnfinushed = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuQuit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(122, 22);
            this.menuNew.Text = "新增";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(122, 22);
            this.menuOpen.Text = "開啟";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(122, 22);
            this.menuSave.Text = "儲存";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(122, 22);
            this.menuSaveAs.Text = "另存新檔";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(122, 22);
            this.menuQuit.Text = "離開";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.menuDisplayAll,
            this.menuDisplayUnfinushed});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(146, 22);
            this.menuFont.Text = "字型大小";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // menuDisplayAll
            // 
            this.menuDisplayAll.Name = "menuDisplayAll";
            this.menuDisplayAll.Size = new System.Drawing.Size(146, 22);
            this.menuDisplayAll.Text = "顯示完成事項";
            this.menuDisplayAll.Click += new System.EventHandler(this.menuDisplayAll_Click);
            // 
            // menuDisplayUnfinushed
            // 
            this.menuDisplayUnfinushed.Name = "menuDisplayUnfinushed";
            this.menuDisplayUnfinushed.Size = new System.Drawing.Size(146, 22);
            this.menuDisplayUnfinushed.Text = "隱藏完成事項";
            this.menuDisplayUnfinushed.Click += new System.EventHandler(this.menuDisplayUnfinushed_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFind,
            this.menuAdd,
            this.menuFinish,
            this.menuDelete});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(122, 22);
            this.menuFind.Text = "尋找";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(122, 22);
            this.menuAdd.Text = "新增事項";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuFinish
            // 
            this.menuFinish.Name = "menuFinish";
            this.menuFinish.Size = new System.Drawing.Size(122, 22);
            this.menuFinish.Text = "完成事項";
            this.menuFinish.Click += new System.EventHandler(this.menuFinish_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(122, 22);
            this.menuDelete.Text = "刪除事項";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // txtToDo
            // 
            this.txtToDo.Location = new System.Drawing.Point(9, 38);
            this.txtToDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtToDo.Multiline = true;
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.ReadOnly = true;
            this.txtToDo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToDo.Size = new System.Drawing.Size(583, 280);
            this.txtToDo.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 334);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增事項";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(421, 334);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(77, 34);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "完成事項";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.Location = new System.Drawing.Point(515, 385);
            this.btnCloseSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(77, 34);
            this.btnCloseSearch.TabIndex = 4;
            this.btnCloseSearch.Text = "關閉搜尋";
            this.btnCloseSearch.UseVisualStyleBackColor = true;
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 430);
            this.Controls.Add(this.btnCloseSearch);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtToDo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "practice7 - 代辦清單";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayAll;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayUnfinushed;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuFinish;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.Button btnCloseSearch;
    }
}

