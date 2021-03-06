namespace LibraryManagerPro
{
    partial class FrmReaderManger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReaderManger));
            this.rdoIDCard = new System.Windows.Forms.RadioButton();
            this.rdoReadingCard = new System.Windows.Forms.RadioButton();
            this.txt_ReadingCard = new System.Windows.Forms.TextBox();
            this.txt_IDCard = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblReadingCard = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbReaderImg = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblReaderCount = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cameraControl = new Camera_NET.CameraControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.pbReaderPhoto = new System.Windows.Forms.PictureBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.cboReaderRole = new System.Windows.Forms.ComboBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReadingCard = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvReader = new System.Windows.Forms.ListView();
            this.ReaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadingCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQueryReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoIDCard
            // 
            this.rdoIDCard.AutoSize = true;
            this.rdoIDCard.Location = new System.Drawing.Point(23, 70);
            this.rdoIDCard.Name = "rdoIDCard";
            this.rdoIDCard.Size = new System.Drawing.Size(83, 16);
            this.rdoIDCard.TabIndex = 3;
            this.rdoIDCard.Text = "身份证号：";
            this.rdoIDCard.UseVisualStyleBackColor = true;
            // 
            // rdoReadingCard
            // 
            this.rdoReadingCard.AutoSize = true;
            this.rdoReadingCard.Checked = true;
            this.rdoReadingCard.Location = new System.Drawing.Point(23, 23);
            this.rdoReadingCard.Name = "rdoReadingCard";
            this.rdoReadingCard.Size = new System.Drawing.Size(95, 16);
            this.rdoReadingCard.TabIndex = 3;
            this.rdoReadingCard.TabStop = true;
            this.rdoReadingCard.Text = "借阅证编号：";
            this.rdoReadingCard.UseVisualStyleBackColor = true;
            // 
            // txt_ReadingCard
            // 
            this.txt_ReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReadingCard.Location = new System.Drawing.Point(118, 18);
            this.txt_ReadingCard.Name = "txt_ReadingCard";
            this.txt_ReadingCard.Size = new System.Drawing.Size(126, 21);
            this.txt_ReadingCard.TabIndex = 0;
            // 
            // txt_IDCard
            // 
            this.txt_IDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDCard.Location = new System.Drawing.Point(118, 67);
            this.txt_IDCard.Name = "txt_IDCard";
            this.txt_IDCard.Size = new System.Drawing.Size(126, 21);
            this.txt_IDCard.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(23, 152);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(107, 37);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "提交查询  ";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Location = new System.Drawing.Point(778, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(142, 24);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Location = new System.Drawing.Point(547, 146);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(142, 24);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPostCode
            // 
            this.lblPostCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPostCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostCode.Location = new System.Drawing.Point(778, 146);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(142, 24);
            this.lblPostCode.TabIndex = 28;
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoleName.Location = new System.Drawing.Point(778, 62);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(142, 24);
            this.lblRoleName.TabIndex = 28;
            this.lblRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReadingCard
            // 
            this.lblReadingCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReadingCard.Location = new System.Drawing.Point(778, 21);
            this.lblReadingCard.Name = "lblReadingCard";
            this.lblReadingCard.Size = new System.Drawing.Size(142, 24);
            this.lblReadingCard.TabIndex = 28;
            this.lblReadingCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaderName
            // 
            this.lblReaderName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReaderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderName.Location = new System.Drawing.Point(547, 21);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(142, 24);
            this.lblReaderName.TabIndex = 28;
            this.lblReaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "联系电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "现在住址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮政编码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "会员角色：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "借阅证编号：";
            // 
            // pbReaderImg
            // 
            this.pbReaderImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderImg.Location = new System.Drawing.Point(268, 18);
            this.pbReaderImg.Name = "pbReaderImg";
            this.pbReaderImg.Size = new System.Drawing.Size(178, 174);
            this.pbReaderImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReaderImg.TabIndex = 27;
            this.pbReaderImg.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(903, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.Location = new System.Drawing.Point(795, 261);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(102, 37);
            this.btnEnable.TabIndex = 3;
            this.btnEnable.Text = "挂失借阅证 ";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(425, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "对应会员总数：";
            // 
            // lblReaderCount
            // 
            this.lblReaderCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReaderCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderCount.Location = new System.Drawing.Point(520, 269);
            this.lblReaderCount.Name = "lblReaderCount";
            this.lblReaderCount.Size = new System.Drawing.Size(126, 24);
            this.lblReaderCount.TabIndex = 28;
            this.lblReaderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(129, 271);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(126, 20);
            this.cboRole.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "按照会员角色查询：";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 241);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lblIDCard);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Controls.Add(this.lblPostCode);
            this.tabPage1.Controls.Add(this.rdoIDCard);
            this.tabPage1.Controls.Add(this.lblRoleName);
            this.tabPage1.Controls.Add(this.txt_IDCard);
            this.tabPage1.Controls.Add(this.lblReadingCard);
            this.tabPage1.Controls.Add(this.rdoReadingCard);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblReaderName);
            this.tabPage1.Controls.Add(this.txt_ReadingCard);
            this.tabPage1.Controls.Add(this.pbReaderImg);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "会员查询";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(149, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "修改信息 ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblIDCard
            // 
            this.lblIDCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIDCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIDCard.Location = new System.Drawing.Point(547, 104);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(142, 24);
            this.lblIDCard.TabIndex = 28;
            this.lblIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.Location = new System.Drawing.Point(547, 62);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(142, 24);
            this.lblGender.TabIndex = 28;
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "身份证号：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.cameraControl);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnCloseVideo);
            this.tabPage2.Controls.Add(this.pbReaderPhoto);
            this.tabPage2.Controls.Add(this.btnTake);
            this.tabPage2.Controls.Add(this.btnStartVideo);
            this.tabPage2.Controls.Add(this.cboReaderRole);
            this.tabPage2.Controls.Add(this.rdoFemale);
            this.tabPage2.Controls.Add(this.rdoMale);
            this.tabPage2.Controls.Add(this.txtReaderName);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtIDCard);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txtReadingCard);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtPostcode);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "会员办证";
            // 
            // cameraControl
            // 
            this.cameraControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(7, 14);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(159, 180);
            this.cameraControl.TabIndex = 36;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(380, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 39);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.Location = new System.Drawing.Point(379, 61);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(89, 39);
            this.btnCloseVideo.TabIndex = 35;
            this.btnCloseVideo.Text = "关闭摄像头";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            this.btnCloseVideo.Click += new System.EventHandler(this.BtnCloseVideo_Click);
            // 
            // pbReaderPhoto
            // 
            this.pbReaderPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderPhoto.Location = new System.Drawing.Point(200, 14);
            this.pbReaderPhoto.Name = "pbReaderPhoto";
            this.pbReaderPhoto.Size = new System.Drawing.Size(159, 180);
            this.pbReaderPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReaderPhoto.TabIndex = 28;
            this.pbReaderPhoto.TabStop = false;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(380, 107);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(88, 39);
            this.btnTake.TabIndex = 34;
            this.btnTake.Text = "开始拍照";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Location = new System.Drawing.Point(379, 15);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(88, 39);
            this.btnStartVideo.TabIndex = 33;
            this.btnStartVideo.Text = "启动摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.BtnStartVideo_Click);
            // 
            // cboReaderRole
            // 
            this.cboReaderRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReaderRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReaderRole.FormattingEnabled = true;
            this.cboReaderRole.Location = new System.Drawing.Point(809, 76);
            this.cboReaderRole.Name = "cboReaderRole";
            this.cboReaderRole.Size = new System.Drawing.Size(142, 20);
            this.cboReaderRole.TabIndex = 26;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(624, 78);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 24;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(573, 78);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 25;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtReaderName
            // 
            this.txtReaderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderName.Location = new System.Drawing.Point(573, 24);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(142, 21);
            this.txtReaderName.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(502, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "读者姓名：";
            // 
            // txtIDCard
            // 
            this.txtIDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCard.Location = new System.Drawing.Point(572, 125);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(142, 21);
            this.txtIDCard.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(808, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 21);
            this.txtPhone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "身份证号：";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(572, 171);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 21);
            this.txtAddress.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(737, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "联系电话：";
            // 
            // txtReadingCard
            // 
            this.txtReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadingCard.Location = new System.Drawing.Point(808, 24);
            this.txtReadingCard.Name = "txtReadingCard";
            this.txtReadingCard.Size = new System.Drawing.Size(143, 21);
            this.txtReadingCard.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(501, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "现在住址：";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.Location = new System.Drawing.Point(808, 171);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(142, 21);
            this.txtPostcode.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(737, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 15;
            this.label20.Text = "邮政编码：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(737, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 16;
            this.label21.Text = "会员角色：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(514, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 17;
            this.label22.Text = "性别：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(725, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 18;
            this.label23.Text = "借阅证编号：";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "people.ico");
            this.imageList1.Images.SetKeyName(1, "BOOK02.ICO");
            // 
            // lvReader
            // 
            this.lvReader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReaderId,
            this.ReadingCard,
            this.ReaderName,
            this.Gender,
            this.PhoneNumber,
            this.RoleName,
            this.StatusDesc,
            this.RegTime,
            this.ReaderAddress});
            this.lvReader.FullRowSelect = true;
            this.lvReader.GridLines = true;
            this.lvReader.HideSelection = false;
            this.lvReader.Location = new System.Drawing.Point(16, 314);
            this.lvReader.Name = "lvReader";
            this.lvReader.Size = new System.Drawing.Size(975, 348);
            this.lvReader.TabIndex = 33;
            this.lvReader.UseCompatibleStateImageBehavior = false;
            this.lvReader.View = System.Windows.Forms.View.Details;
            // 
            // ReaderId
            // 
            this.ReaderId.Text = "读者编号";
            // 
            // ReadingCard
            // 
            this.ReadingCard.Text = "借阅证编号";
            this.ReadingCard.Width = 150;
            // 
            // ReaderName
            // 
            this.ReaderName.Text = "姓名";
            this.ReaderName.Width = 100;
            // 
            // Gender
            // 
            this.Gender.Text = "性别";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "联系电话";
            this.PhoneNumber.Width = 150;
            // 
            // RoleName
            // 
            this.RoleName.Text = "会员类型";
            // 
            // StatusDesc
            // 
            this.StatusDesc.Text = "会员状态";
            this.StatusDesc.Width = 100;
            // 
            // RegTime
            // 
            this.RegTime.Text = "办证时间";
            this.RegTime.Width = 150;
            // 
            // ReaderAddress
            // 
            this.ReaderAddress.Text = "通信地址";
            this.ReaderAddress.Width = 260;
            // 
            // btnQueryReader
            // 
            this.btnQueryReader.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryReader.Image")));
            this.btnQueryReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryReader.Location = new System.Drawing.Point(278, 261);
            this.btnQueryReader.Name = "btnQueryReader";
            this.btnQueryReader.Size = new System.Drawing.Size(119, 39);
            this.btnQueryReader.TabIndex = 2;
            this.btnQueryReader.Text = "按照角色查询 ";
            this.btnQueryReader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQueryReader.UseVisualStyleBackColor = true;
            this.btnQueryReader.Click += new System.EventHandler(this.BtnQueryReader_Click);
            // 
            // FrmReaderManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.lvReader);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.btnQueryReader);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReaderCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReaderManger";
            this.Text = "[会员管理]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReaderManger_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDCard;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RadioButton rdoIDCard;
        private System.Windows.Forms.RadioButton rdoReadingCard;
        private System.Windows.Forms.TextBox txt_ReadingCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbReaderImg;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblReadingCard;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblReaderCount;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cboReaderRole;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReadingCard;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pbReaderPhoto;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvReader;
        private System.Windows.Forms.ColumnHeader ReadingCard;
        private System.Windows.Forms.ColumnHeader ReaderName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader ReaderAddress;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader RegTime;
        private System.Windows.Forms.ColumnHeader StatusDesc;
        private System.Windows.Forms.Button btnQueryReader;
        private System.Windows.Forms.ColumnHeader ReaderId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ColumnHeader RoleName;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label5;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label label8;
    }
}