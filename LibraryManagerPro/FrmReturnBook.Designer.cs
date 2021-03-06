namespace LibraryManagerPro
{
    partial class FrmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbReaderImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.dgvNonReturnList = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NonReturnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lbl_Remainder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorrowCount = new System.Windows.Forms.Label();
            this.txtReadingCard = new System.Windows.Forms.TextBox();
            this.lblAllowCounts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReturnList = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCount_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReturnCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonReturnList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnList)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReaderImage
            // 
            this.pbReaderImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderImage.Location = new System.Drawing.Point(734, 18);
            this.pbReaderImage.Name = "pbReaderImage";
            this.pbReaderImage.Size = new System.Drawing.Size(110, 107);
            this.pbReaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReaderImage.TabIndex = 34;
            this.pbReaderImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(884, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭窗口 ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmReturn.Image")));
            this.btnConfirmReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmReturn.Location = new System.Drawing.Point(831, 623);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(142, 37);
            this.btnConfirmReturn.TabIndex = 0;
            this.btnConfirmReturn.Text = "确认图书归还   ";
            this.btnConfirmReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmReturn.UseVisualStyleBackColor = true;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click);
            // 
            // dgvNonReturnList
            // 
            this.dgvNonReturnList.AllowUserToAddRows = false;
            this.dgvNonReturnList.AllowUserToDeleteRows = false;
            this.dgvNonReturnList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNonReturnList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNonReturnList.ColumnHeadersHeight = 28;
            this.dgvNonReturnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BorrowDate,
            this.Expire,
            this.BorrowCount,
            this.ReturnCount,
            this.NonReturnCount,
            this.StatusDesc,
            this.BorrowDetailId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNonReturnList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNonReturnList.Location = new System.Drawing.Point(28, 175);
            this.dgvNonReturnList.Name = "dgvNonReturnList";
            this.dgvNonReturnList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNonReturnList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNonReturnList.RowTemplate.Height = 23;
            this.dgvNonReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNonReturnList.Size = new System.Drawing.Size(945, 214);
            this.dgvNonReturnList.TabIndex = 31;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BorrowDate
            // 
            this.BorrowDate.DataPropertyName = "BorrowDate";
            this.BorrowDate.HeaderText = "借书时间";
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.ReadOnly = true;
            this.BorrowDate.Width = 150;
            // 
            // Expire
            // 
            this.Expire.DataPropertyName = "Expire";
            this.Expire.HeaderText = "到期时间";
            this.Expire.Name = "Expire";
            this.Expire.ReadOnly = true;
            this.Expire.Width = 150;
            // 
            // BorrowCount
            // 
            this.BorrowCount.DataPropertyName = "BorrowCount";
            this.BorrowCount.HeaderText = "借阅总数";
            this.BorrowCount.Name = "BorrowCount";
            this.BorrowCount.ReadOnly = true;
            this.BorrowCount.Width = 80;
            // 
            // ReturnCount
            // 
            this.ReturnCount.DataPropertyName = "ReturnCount";
            this.ReturnCount.HeaderText = "已还总数";
            this.ReturnCount.Name = "ReturnCount";
            this.ReturnCount.ReadOnly = true;
            // 
            // NonReturnCount
            // 
            this.NonReturnCount.DataPropertyName = "NonReturnCount";
            this.NonReturnCount.HeaderText = "未还总数";
            this.NonReturnCount.Name = "NonReturnCount";
            this.NonReturnCount.ReadOnly = true;
            // 
            // StatusDesc
            // 
            this.StatusDesc.DataPropertyName = "StatusDesc";
            this.StatusDesc.HeaderText = "借书状态";
            this.StatusDesc.Name = "StatusDesc";
            this.StatusDesc.ReadOnly = true;
            // 
            // BorrowDetailId
            // 
            this.BorrowDetailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BorrowDetailId.DataPropertyName = "BorrowDetailId";
            this.BorrowDetailId.HeaderText = "借阅详细编号";
            this.BorrowDetailId.Name = "BorrowDetailId";
            this.BorrowDetailId.ReadOnly = true;
            this.BorrowDetailId.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(762, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "[图书条码]：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarCode.Location = new System.Drawing.Point(767, 447);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(206, 35);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(269, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "该借阅证所借图书列表：（按借书时间分组显示）";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRoleName);
            this.groupBox1.Controls.Add(this.lbl_Remainder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBorrowCount);
            this.groupBox1.Controls.Add(this.txtReadingCard);
            this.groupBox1.Controls.Add(this.lblAllowCounts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblReaderName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[读者信息]";
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRoleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoleName.Location = new System.Drawing.Point(546, 26);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(109, 24);
            this.lblRoleName.TabIndex = 4;
            this.lblRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Remainder
            // 
            this.lbl_Remainder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Remainder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Remainder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Remainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Remainder.Location = new System.Drawing.Point(546, 67);
            this.lbl_Remainder.Name = "lbl_Remainder";
            this.lbl_Remainder.Size = new System.Drawing.Size(109, 24);
            this.lbl_Remainder.TabIndex = 4;
            this.lbl_Remainder.Text = "0";
            this.lbl_Remainder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "借书证号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "剩借总数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "读者姓名：";
            // 
            // lblBorrowCount
            // 
            this.lblBorrowCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBorrowCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorrowCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowCount.Location = new System.Drawing.Point(329, 67);
            this.lblBorrowCount.Name = "lblBorrowCount";
            this.lblBorrowCount.Size = new System.Drawing.Size(115, 24);
            this.lblBorrowCount.TabIndex = 4;
            this.lblBorrowCount.Text = "0";
            this.lblBorrowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReadingCard
            // 
            this.txtReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadingCard.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReadingCard.Location = new System.Drawing.Point(81, 28);
            this.txtReadingCard.Name = "txtReadingCard";
            this.txtReadingCard.Size = new System.Drawing.Size(142, 21);
            this.txtReadingCard.TabIndex = 0;
            this.txtReadingCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtReadingCard_KeyDown);
            // 
            // lblAllowCounts
            // 
            this.lblAllowCounts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAllowCounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAllowCounts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAllowCounts.Location = new System.Drawing.Point(81, 67);
            this.lblAllowCounts.Name = "lblAllowCounts";
            this.lblAllowCounts.Size = new System.Drawing.Size(142, 24);
            this.lblAllowCounts.TabIndex = 4;
            this.lblAllowCounts.Text = "0";
            this.lblAllowCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "会员角色：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "已借总数：";
            // 
            // lblReaderName
            // 
            this.lblReaderName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReaderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderName.Location = new System.Drawing.Point(329, 26);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(115, 24);
            this.lblReaderName.TabIndex = 4;
            this.lblReaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "可借总数：";
            // 
            // dgvReturnList
            // 
            this.dgvReturnList.AllowUserToAddRows = false;
            this.dgvReturnList.AllowUserToDeleteRows = false;
            this.dgvReturnList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReturnList.ColumnHeadersHeight = 28;
            this.dgvReturnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.BookName_,
            this.ReturnCount_});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReturnList.Location = new System.Drawing.Point(28, 424);
            this.dgvReturnList.Name = "dgvReturnList";
            this.dgvReturnList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReturnList.RowTemplate.Height = 23;
            this.dgvReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnList.Size = new System.Drawing.Size(696, 243);
            this.dgvReturnList.TabIndex = 42;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "图书条码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 150;
            // 
            // BookName_
            // 
            this.BookName_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName_.DataPropertyName = "BookName";
            this.BookName_.HeaderText = "图书名称";
            this.BookName_.Name = "BookName_";
            this.BookName_.ReadOnly = true;
            // 
            // ReturnCount_
            // 
            this.ReturnCount_.DataPropertyName = "ReturnCount";
            this.ReturnCount_.HeaderText = "本次还书总数";
            this.ReturnCount_.Name = "ReturnCount_";
            this.ReturnCount_.ReadOnly = true;
            this.ReturnCount_.Width = 150;
            // 
            // lblReturnCount
            // 
            this.lblReturnCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReturnCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReturnCount.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReturnCount.Location = new System.Drawing.Point(767, 534);
            this.lblReturnCount.Name = "lblReturnCount";
            this.lblReturnCount.Size = new System.Drawing.Size(206, 64);
            this.lblReturnCount.TabIndex = 4;
            this.lblReturnCount.Text = "0";
            this.lblReturnCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(762, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "[还书总数]：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "本次还书统计列表：";
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 681);
            this.Controls.Add(this.dgvReturnList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbReaderImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirmReturn);
            this.Controls.Add(this.lblReturnCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgvNonReturnList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBarCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReturnBook";
            this.Text = "[图书归还]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReturnBook_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonReturnList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReaderImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.DataGridView dgvNonReturnList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lbl_Remainder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBorrowCount;
        private System.Windows.Forms.TextBox txtReadingCard;
        private System.Windows.Forms.Label lblAllowCounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReturnList;
        private System.Windows.Forms.Label lblReturnCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonReturnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnCount_;
    }
}