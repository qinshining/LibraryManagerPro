namespace LibraryManagerPro
{
    partial class FrmNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBookPosition = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.label6);
            this.gbinfo.Controls.Add(this.lblCategory);
            this.gbinfo.Controls.Add(this.lblBookPosition);
            this.gbinfo.Controls.Add(this.lblBookCount);
            this.gbinfo.Controls.Add(this.lblBookName);
            this.gbinfo.Controls.Add(this.lblBookId);
            this.gbinfo.Controls.Add(this.label9);
            this.gbinfo.Controls.Add(this.label10);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Location = new System.Drawing.Point(333, 32);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(514, 172);
            this.gbinfo.TabIndex = 31;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "[图书基本信息]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "收藏总数：";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Location = new System.Drawing.Point(326, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(142, 24);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookPosition
            // 
            this.lblBookPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookPosition.Location = new System.Drawing.Point(326, 73);
            this.lblBookPosition.Name = "lblBookPosition";
            this.lblBookPosition.Size = new System.Drawing.Size(142, 24);
            this.lblBookPosition.TabIndex = 0;
            this.lblBookPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookCount
            // 
            this.lblBookCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookCount.Location = new System.Drawing.Point(91, 73);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(142, 24);
            this.lblBookCount.TabIndex = 0;
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookName.Location = new System.Drawing.Point(91, 31);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(142, 24);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookId
            // 
            this.lblBookId.BackColor = System.Drawing.SystemColors.Control;
            this.lblBookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookId.Location = new System.Drawing.Point(91, 126);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(142, 24);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "书架位置：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书分类：";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(27, 32);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(249, 258);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 33;
            this.pbImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(893, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭窗口 ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(873, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存新图书  ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(286, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 27);
            this.label13.TabIndex = 34;
            this.label13.Text = "[图书条码]：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarCode.Location = new System.Drawing.Point(414, 255);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(199, 35);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarCode_KeyDown);
            this.txtBarCode.Leave += new System.EventHandler(this.TxtBarCode_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(645, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "[新增总数]：";
            // 
            // txtAddCount
            // 
            this.txtAddCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddCount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddCount.Location = new System.Drawing.Point(777, 255);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(70, 35);
            this.txtAddCount.TabIndex = 1;
            this.txtAddCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAddCount_KeyDown);
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
            this.BookPosition});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookList.Location = new System.Drawing.Point(27, 336);
            this.dgvBookList.MultiSelect = false;
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(957, 329);
            this.dgvBookList.TabIndex = 38;
            this.dgvBookList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvBookList_RowStateChanged);
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "图书条码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 120;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 200;
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
            this.Author.Width = 150;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "现收藏总数";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "书架位置";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // FrmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 677);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddCount);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.gbinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewBook";
            this.Text = "[新书上架]";
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBookPosition;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
    }
}