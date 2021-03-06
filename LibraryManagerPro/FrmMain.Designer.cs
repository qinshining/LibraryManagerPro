namespace LibraryManagerPro
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBookNew = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.btnReaderManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperationName = new System.Windows.Forms.Label();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.销售管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 88);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(26, 567);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(82, 41);
            this.btnModifyPwd.TabIndex = 1;
            this.btnModifyPwd.Text = "密码修改";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(126, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(126, 478);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(82, 41);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "图书归还";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBookNew
            // 
            this.btnBookNew.Image = ((System.Drawing.Image)(resources.GetObject("btnBookNew.Image")));
            this.btnBookNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookNew.Location = new System.Drawing.Point(126, 333);
            this.btnBookNew.Name = "btnBookNew";
            this.btnBookNew.Size = new System.Drawing.Size(82, 41);
            this.btnBookNew.TabIndex = 1;
            this.btnBookNew.Text = " 图书上架";
            this.btnBookNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookNew.UseVisualStyleBackColor = true;
            this.btnBookNew.Click += new System.EventHandler(this.btnBookNew_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBook.Image")));
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Location = new System.Drawing.Point(25, 478);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(82, 41);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "图书出借";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(26, 332);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(82, 41);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "新增图书";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 25);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.btnReaderManager);
            this.spContainer.Panel1.Controls.Add(this.label2);
            this.spContainer.Panel1.Controls.Add(this.label1);
            this.spContainer.Panel1.Controls.Add(this.lblOperationName);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            this.spContainer.Panel1.Controls.Add(this.btnModifyPwd);
            this.spContainer.Panel1.Controls.Add(this.btnExit);
            this.spContainer.Panel1.Controls.Add(this.btnReturnBook);
            this.spContainer.Panel1.Controls.Add(this.btnBookNew);
            this.spContainer.Panel1.Controls.Add(this.btnBorrowBook);
            this.spContainer.Panel1.Controls.Add(this.btnBookManage);
            this.spContainer.Panel1.Controls.Add(this.btnAddBook);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Size = new System.Drawing.Size(1264, 682);
            this.spContainer.SplitterDistance = 243;
            this.spContainer.TabIndex = 13;
            // 
            // btnReaderManager
            // 
            this.btnReaderManager.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderManager.Image")));
            this.btnReaderManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaderManager.Location = new System.Drawing.Point(127, 417);
            this.btnReaderManager.Name = "btnReaderManager";
            this.btnReaderManager.Size = new System.Drawing.Size(82, 41);
            this.btnReaderManager.TabIndex = 1;
            this.btnReaderManager.Text = "会员管理";
            this.btnReaderManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReaderManager.UseVisualStyleBackColor = true;
            this.btnReaderManager.Click += new System.EventHandler(this.btnReaderManager_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(24, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 3);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 3);
            this.label1.TabIndex = 0;
            // 
            // lblOperationName
            // 
            this.lblOperationName.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperationName.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperationName.Location = new System.Drawing.Point(10, 16);
            this.lblOperationName.Name = "lblOperationName";
            this.lblOperationName.Size = new System.Drawing.Size(220, 49);
            this.lblOperationName.TabIndex = 0;
            this.lblOperationName.Text = "欢迎使用";
            this.lblOperationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBookManage
            // 
            this.btnBookManage.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManage.Image")));
            this.btnBookManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManage.Location = new System.Drawing.Point(25, 417);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(82, 41);
            this.btnBookManage.TabIndex = 1;
            this.btnBookManage.Text = "图书维护";
            this.btnBookManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookManage.UseVisualStyleBackColor = true;
            this.btnBookManage.Click += new System.EventHandler(this.btnBookManage_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(80, 17);
            this.lblAdminName.Text = "【管理员】：";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel1.Text = "[图书借阅管理系统]  V2.0 ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblAdminName,
            this.tssl_AdminName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_AdminName
            // 
            this.tssl_AdminName.Name = "tssl_AdminName";
            this.tssl_AdminName.Size = new System.Drawing.Size(20, 17);
            this.tssl_AdminName.Text = "无";
            // 
            // 销售管理XToolStripMenuItem
            // 
            this.销售管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBorrowBook,
            this.tsmiReturnBook,
            this.tsmiMemberManage});
            this.销售管理XToolStripMenuItem.Name = "销售管理XToolStripMenuItem";
            this.销售管理XToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.销售管理XToolStripMenuItem.Text = "会员借还书(&B)";
            // 
            // tsmiBorrowBook
            // 
            this.tsmiBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBorrowBook.Image")));
            this.tsmiBorrowBook.Name = "tsmiBorrowBook";
            this.tsmiBorrowBook.Size = new System.Drawing.Size(180, 22);
            this.tsmiBorrowBook.Text = "图书出借(&B)";
            this.tsmiBorrowBook.Click += new System.EventHandler(this.TsmiBorrowBook_Click);
            // 
            // tsmiReturnBook
            // 
            this.tsmiReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturnBook.Image")));
            this.tsmiReturnBook.Name = "tsmiReturnBook";
            this.tsmiReturnBook.Size = new System.Drawing.Size(180, 22);
            this.tsmiReturnBook.Text = "图书归还(&R)";
            this.tsmiReturnBook.Click += new System.EventHandler(this.TsmiReturnBook_Click);
            // 
            // tsmiMemberManage
            // 
            this.tsmiMemberManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMemberManage.Image")));
            this.tsmiMemberManage.Name = "tsmiMemberManage";
            this.tsmiMemberManage.Size = new System.Drawing.Size(180, 22);
            this.tsmiMemberManage.Text = "会员管理(&M)";
            this.tsmiMemberManage.Click += new System.EventHandler(this.TsmiMemberManage_Click);
            // 
            // tsmiBookManage
            // 
            this.tsmiBookManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookManage.Image")));
            this.tsmiBookManage.Name = "tsmiBookManage";
            this.tsmiBookManage.Size = new System.Drawing.Size(180, 22);
            this.tsmiBookManage.Text = "图书信息维护(&M)";
            this.tsmiBookManage.Click += new System.EventHandler(this.TsmiBookManage_Click);
            // 
            // tsmiBookNew
            // 
            this.tsmiBookNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookNew.Image")));
            this.tsmiBookNew.Name = "tsmiBookNew";
            this.tsmiBookNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiBookNew.Text = "图书上架(&I)";
            this.tsmiBookNew.Click += new System.EventHandler(this.TsmiBookNew_Click);
            // 
            // tsmiAddBook
            // 
            this.tsmiAddBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddBook.Image")));
            this.tsmiAddBook.Name = "tsmiAddBook";
            this.tsmiAddBook.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddBook.Text = "添加新书(&A)";
            this.tsmiAddBook.Click += new System.EventHandler(this.TsmiAddBook_Click);
            // 
            // 商品管理PToolStripMenuItem
            // 
            this.商品管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddBook,
            this.tsmiBookNew,
            this.toolStripSeparator1,
            this.tsmiBookManage});
            this.商品管理PToolStripMenuItem.Name = "商品管理PToolStripMenuItem";
            this.商品管理PToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.商品管理PToolStripMenuItem.Text = "图书管理(&B)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "退出系统(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModifyPwd.Image")));
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyPwd.Text = "修改密码(&P)";
            this.tsmiModifyPwd.Click += new System.EventHandler(this.TsmiModifyPwd_Click);
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd,
            this.toolStripSeparator3,
            this.tsmiExit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.商品管理PToolStripMenuItem,
            this.销售管理XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[图书借阅管理系统]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookNew;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.ToolStripStatusLabel lblAdminName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 销售管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBook;
        private System.Windows.Forms.ToolStripMenuItem 商品管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblOperationName;
        private System.Windows.Forms.Button btnReaderManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AdminName;
      
    }
}

