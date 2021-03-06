namespace LibraryManagerPro
{
    partial class FrmBookManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BookPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_BookCategory = new System.Windows.Forms.ComboBox();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.lbl_BookCount = new System.Windows.Forms.Label();
            this.lbl_BookId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_Publisher = new System.Windows.Forms.ComboBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_PublishDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cameraControl = new Camera_NET.CameraControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBookName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBarCode);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[按照分类查询]";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(470, 29);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(138, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书名称：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Location = new System.Drawing.Point(270, 29);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(126, 21);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(632, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 37);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图书条码：";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(84, 30);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(117, 20);
            this.cboCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书分类：";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBookList.ColumnHeadersHeight = 28;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.BookName,
            this.PublisherName,
            this.Author,
            this.BookCount,
            this.Remainder,
            this.BookPosition});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.Location = new System.Drawing.Point(21, 106);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(963, 292);
            this.dgvBookList.TabIndex = 9;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "图书条码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 150;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 220;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "出版社";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            this.PublisherName.Width = 150;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "主编";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "收藏总数";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            this.BookCount.Width = 80;
            // 
            // Remainder
            // 
            this.Remainder.DataPropertyName = "Remainder";
            this.Remainder.HeaderText = "可借总数";
            this.Remainder.Name = "Remainder";
            this.Remainder.ReadOnly = true;
            this.Remainder.Width = 80;
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "书架位置";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(904, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(775, 43);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 37);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删  除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.Location = new System.Drawing.Point(109, 619);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(77, 39);
            this.btnCloseVideo.TabIndex = 49;
            this.btnCloseVideo.Text = "关闭摄像头";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            this.btnCloseVideo.Click += new System.EventHandler(this.BtnCloseVideo_Click);
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.Location = new System.Drawing.Point(283, 619);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(77, 39);
            this.btnChoseImage.TabIndex = 45;
            this.btnChoseImage.Text = "选择图片";
            this.btnChoseImage.UseVisualStyleBackColor = true;
            this.btnChoseImage.Click += new System.EventHandler(this.BtnChoseImage_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(196, 619);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(77, 39);
            this.btnTake.TabIndex = 43;
            this.btnTake.Text = "开始拍照";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Location = new System.Drawing.Point(21, 619);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(77, 39);
            this.btnStartVideo.TabIndex = 42;
            this.btnStartVideo.Text = "启动摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.BtnStartVideo_Click);
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.txt_BookName);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.label5);
            this.gbBook.Controls.Add(this.txt_BookPosition);
            this.gbBook.Controls.Add(this.label6);
            this.gbBook.Controls.Add(this.label9);
            this.gbBook.Controls.Add(this.label7);
            this.gbBook.Controls.Add(this.cbo_BookCategory);
            this.gbBook.Controls.Add(this.lbl_BarCode);
            this.gbBook.Controls.Add(this.lbl_BookCount);
            this.gbBook.Controls.Add(this.lbl_BookId);
            this.gbBook.Controls.Add(this.label10);
            this.gbBook.Controls.Add(this.cbo_Publisher);
            this.gbBook.Controls.Add(this.txt_UnitPrice);
            this.gbBook.Controls.Add(this.label8);
            this.gbBook.Controls.Add(this.txt_Author);
            this.gbBook.Controls.Add(this.label12);
            this.gbBook.Controls.Add(this.label13);
            this.gbBook.Controls.Add(this.dtp_PublishDate);
            this.gbBook.Controls.Add(this.label14);
            this.gbBook.Location = new System.Drawing.Point(485, 414);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(499, 244);
            this.gbBook.TabIndex = 41;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "[图书基本信息]";
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Location = new System.Drawing.Point(90, 31);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(142, 21);
            this.txt_BookName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "图书名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "出版日期：";
            // 
            // txt_BookPosition
            // 
            this.txt_BookPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookPosition.Location = new System.Drawing.Point(89, 158);
            this.txt_BookPosition.Name = "txt_BookPosition";
            this.txt_BookPosition.Size = new System.Drawing.Size(142, 21);
            this.txt_BookPosition.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "收藏总数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "书架位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "图书条码：";
            // 
            // cbo_BookCategory
            // 
            this.cbo_BookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BookCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_BookCategory.FormattingEnabled = true;
            this.cbo_BookCategory.Location = new System.Drawing.Point(325, 30);
            this.cbo_BookCategory.Name = "cbo_BookCategory";
            this.cbo_BookCategory.Size = new System.Drawing.Size(142, 20);
            this.cbo_BookCategory.TabIndex = 2;
            // 
            // lbl_BarCode
            // 
            this.lbl_BarCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BarCode.Location = new System.Drawing.Point(89, 197);
            this.lbl_BarCode.Name = "lbl_BarCode";
            this.lbl_BarCode.Size = new System.Drawing.Size(142, 24);
            this.lbl_BarCode.TabIndex = 0;
            this.lbl_BarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BookCount
            // 
            this.lbl_BookCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BookCount.Location = new System.Drawing.Point(325, 154);
            this.lbl_BookCount.Name = "lbl_BookCount";
            this.lbl_BookCount.Size = new System.Drawing.Size(142, 24);
            this.lbl_BookCount.TabIndex = 0;
            this.lbl_BookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BookId
            // 
            this.lbl_BookId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BookId.Location = new System.Drawing.Point(325, 197);
            this.lbl_BookId.Name = "lbl_BookId";
            this.lbl_BookId.Size = new System.Drawing.Size(142, 24);
            this.lbl_BookId.TabIndex = 0;
            this.lbl_BookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书编号：";
            // 
            // cbo_Publisher
            // 
            this.cbo_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Publisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Publisher.FormattingEnabled = true;
            this.cbo_Publisher.Location = new System.Drawing.Point(90, 73);
            this.cbo_Publisher.Name = "cbo_Publisher";
            this.cbo_Publisher.Size = new System.Drawing.Size(142, 20);
            this.cbo_Publisher.TabIndex = 3;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnitPrice.Location = new System.Drawing.Point(325, 113);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(142, 21);
            this.txt_UnitPrice.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "图书原价：";
            // 
            // txt_Author
            // 
            this.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Author.Location = new System.Drawing.Point(89, 114);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(143, 21);
            this.txt_Author.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "主编人：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "图书分类：";
            // 
            // dtp_PublishDate
            // 
            this.dtp_PublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_PublishDate.Location = new System.Drawing.Point(325, 71);
            this.dtp_PublishDate.Name = "dtp_PublishDate";
            this.dtp_PublishDate.Size = new System.Drawing.Size(142, 21);
            this.dtp_PublishDate.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "出版社：";
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCurrentImage.Location = new System.Drawing.Point(256, 414);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(196, 192);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentImage.TabIndex = 47;
            this.pbCurrentImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(370, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "保存修改";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cameraControl
            // 
            this.cameraControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(21, 414);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(199, 192);
            this.cameraControl.TabIndex = 50;
            // 
            // FrmBookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 677);
            this.Controls.Add(this.cameraControl);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[图书信息维护]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBookManage_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BookPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_BookCategory;
        private System.Windows.Forms.Label lbl_BookId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_Publisher;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_PublishDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.Label lbl_BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remainder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
        private Camera_NET.CameraControl cameraControl;
    }
}