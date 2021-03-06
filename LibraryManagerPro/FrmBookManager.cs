using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using Camera_NET;

namespace LibraryManagerPro
{
    public partial class FrmBookManager : Form
    {
        private BookManager objBookManager = new BookManager();
        private CameraChoice cameraChoice = new CameraChoice();
        private string[] exts = { ".bmp", ".jpg", ".jpeg", ".jpe", ".png" };
        private List<Book> bookList = null;
        public FrmBookManager()
        {
            InitializeComponent();
            this.dgvBookList.AutoGenerateColumns = false;
            this.btnDel.Enabled = false;
            this.btnStartVideo.Enabled = false;
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
            this.btnChoseImage.Enabled = false;
            this.btnSave.Enabled = false;
            try
            {
                List<Category> categoryList = objBookManager.GetAllCategories();
                List<Category> categoriesQuery = new List<Category>(categoryList);
                categoriesQuery.Insert(0, new Category() { CategoryId = -1, CategoryName = string.Empty });
                //查询框的图书分类下拉框
                this.cboCategory.DataSource = categoriesQuery;
                this.cboCategory.ValueMember = "CategoryId";
                this.cboCategory.DisplayMember = "CategoryName";
                this.cboCategory.SelectedIndex = 0;
                //编辑框的图书分类下拉框
                this.cbo_BookCategory.DataSource = categoryList;
                this.cbo_BookCategory.ValueMember = "CategoryId";
                this.cbo_BookCategory.DisplayMember = "CategoryName";
                this.cbo_BookCategory.SelectedIndex = -1;
                //编辑框的图书出版社
                this.cbo_Publisher.DataSource = objBookManager.GetAllPublishers();
                this.cbo_Publisher.ValueMember = "PublisherId";
                this.cbo_Publisher.DisplayMember = "PublisherName";
                this.cbo_Publisher.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化发生异常：" + ex.Message, "提示信息");
            }
        }
        //dgv选择变更
        private void DgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvBookList.CurrentRow == null)
            {
                this.txt_BookName.Text = "";
                this.cbo_BookCategory.SelectedIndex = -1;
                this.cbo_Publisher.SelectedIndex = -1;
                this.txt_Author.Text = "";
                this.txt_UnitPrice.Text = "";
                this.txt_BookPosition.Text = "";
                this.lbl_BookCount.Text = "";
                this.lbl_BarCode.Text = "";
                this.lbl_BookId.Text = "";
                this.pbCurrentImage.Image = null;
            }
            else
            {
                Book objBook = (from b in this.bookList where b.BarCode == this.dgvBookList.CurrentRow.Cells["BarCode"].Value.ToString() select b).First<Book>();
                this.txt_BookName.Text = objBook.BookName;
                this.cbo_BookCategory.SelectedValue = objBook.BookCategory;
                this.cbo_Publisher.SelectedValue = objBook.PublisherId;
                this.dtp_PublishDate.Value = objBook.PublishDate;
                this.txt_Author.Text = objBook.Author;
                this.txt_UnitPrice.Text = objBook.UnitPrice.ToString();
                this.txt_BookPosition.Text = objBook.BookPosition;
                this.lbl_BookCount.Text = objBook.BookCount.ToString();
                this.lbl_BarCode.Text = objBook.BarCode;
                this.lbl_BookId.Text = objBook.BookId.ToString();
                this.pbCurrentImage.Image = objBook.BookImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(objBook.BookImage);
            }
        }
        //查询
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            this.dgvBookList.SelectionChanged -= new EventHandler(DgvBookList_SelectionChanged);
            try
            {
                this.bookList = objBookManager.GetBookByCombineConditions(this.cboCategory.SelectedValue.ToString(), this.txtBarCode.Text.Trim(), this.txtBookName.Text.Trim());
                this.dgvBookList.DataSource = this.bookList;
                if (this.bookList.Count > 0)
                {
                    this.btnDel.Enabled = true;
                    this.btnStartVideo.Enabled = true;
                    this.btnChoseImage.Enabled = true;
                    this.btnSave.Enabled = true;
                    this.dgvBookList.SelectionChanged += new EventHandler(DgvBookList_SelectionChanged);
                }
                else
                {
                    this.btnDel.Enabled = false;
                    this.btnStartVideo.Enabled = false;
                    this.btnCloseVideo.Enabled = false;
                    this.btnTake.Enabled = false;
                    this.btnChoseImage.Enabled = false;
                    this.btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询出现异常：" + ex.Message, "提示信息");
            }
            DgvBookList_SelectionChanged(null, null);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.CurrentRow == null)
            {
                return;
            }
            this.dgvBookList.SelectionChanged -= new EventHandler(DgvBookList_SelectionChanged);
            DialogResult result = MessageBox.Show("确认要删除编号：【" + this.lbl_BarCode.Text + "】名称：【" + this.txt_BookName.Text + "】的图书吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int deleteResult = objBookManager.DeleteBook(this.lbl_BookId.Text);
                    if (deleteResult == 1)
                    {
                        MessageBox.Show("删除成功", "提示信息");
                        Book objBook = (from b in this.bookList where b.BookId == Convert.ToInt32(this.lbl_BookId.Text) select b).First<Book>();
                        this.bookList.Remove(objBook);
                        this.dgvBookList.DataSource = null;
                        this.dgvBookList.DataSource = this.bookList;
                    }
                    else
                    {
                        MessageBox.Show("未能删除成功，请重新查询是否已在其他地方被删除", "提示信息");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除出现异常：" + ex.Message, "提示信息");
                }
                this.dgvBookList.SelectionChanged += new EventHandler(DgvBookList_SelectionChanged);
                DgvBookList_SelectionChanged(null, null);
            }
        }
        #region 摄像头操作
        //启动摄像头
        private void BtnStartVideo_Click(object sender, EventArgs e)
        {
            try
            {
                cameraChoice.UpdateDeviceList();
                cameraControl.SetCamera(cameraChoice.Devices[0].Mon, null);
                ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);
                Resolution resolution = null;
                foreach (Resolution item in resolutions)
                {
                    if (item.CompareTo(cameraControl.Resolution) == 0)
                    {
                        resolution = item;
                        break;
                    }
                }
                if (resolution == null)
                {
                    resolution = resolutions[0];
                }
                cameraControl.SetCamera(cameraChoice.Devices[0].Mon, resolution);
                this.btnStartVideo.Enabled = false;
                this.btnCloseVideo.Enabled = true;
                this.btnTake.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动摄像头发生异常：" + ex.Message, "启动失败");
            }
        }
        //关闭摄像头
        private void BtnCloseVideo_Click(object sender, EventArgs e)
        {
            this.cameraControl.CloseCamera();
            this.btnStartVideo.Enabled = true;
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
        }
        //拍照
        private void BtnTake_Click(object sender, EventArgs e)
        {
            if (!this.cameraControl.CameraCreated)
            {
                return;
            }
            Bitmap bitmap = this.cameraControl.SnapshotSourceImage();
            this.pbCurrentImage.Image = bitmap;
            this.pbCurrentImage.Update();
        }
        #endregion
        //选择图片
        private void BtnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "选择图片";
            openFileDialog.Filter = "图片|*.bmp;*.jpg;*.jpeg;*.jpe;*.png";//过滤文件类型
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //string fileExtension = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('.'));
                //if (!this.exts.Contains(fileExtension))
                //{
                //    MessageBox.Show("不支持的文件类型，请选择正确的图片", "提示信息");
                //    this.pbCurrentImage.Image = null;
                //}
                //else
                //{
                //    this.pbCurrentImage.Image = Image.FromFile(openFileDialog.FileName);
                //}
                this.pbCurrentImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        //保存修改
        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txt_BookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入图书名称", "提示信息");
                this.txt_BookName.Focus();
                return;
            }
            if (this.cbo_BookCategory.SelectedIndex == -1)
            {
                MessageBox.Show("请选择图书分类", "提示信息");
                return;
            }
            if (this.cbo_Publisher.SelectedIndex == -1)
            {
                MessageBox.Show("请选择图书出版社", "提示信息");
                return;
            }
            if (this.txt_Author.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入主编人", "提示信息");
                this.txt_Author.Focus();
                return;
            }
            if (!Common.DataValidate.IsDecimal(this.txt_UnitPrice.Text.Trim()))
            {
                MessageBox.Show("请输入正确的单价", "提示信息");
                this.txt_UnitPrice.Focus();
                return;
            }
            if (this.txt_BookPosition.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入书架位置", "提示信息");
                this.txt_BookPosition.Focus();
                return;
            }
            if (this.pbCurrentImage.Image == null)
            {
                MessageBox.Show("请选择图书封面", "提示信息");
                return;
            }
            #endregion
            #region 封装数据
            Book objBook = new Book()
            {
                BookName = this.txt_BookName.Text.Trim(),
                BookCategory = Convert.ToInt32(this.cbo_BookCategory.SelectedValue),
                PublisherId = Convert.ToInt32(this.cbo_Publisher.SelectedValue),
                PublisherName = this.cbo_Publisher.Text,
                PublishDate = Convert.ToDateTime(this.dtp_PublishDate.Text),
                Author = this.txt_Author.Text.Trim(),
                UnitPrice = Convert.ToDecimal(this.txt_UnitPrice.Text.Trim()),
                BookPosition = this.txt_BookPosition.Text.Trim(),
                BookImage = new Common.SerializeObjectToString().SerializeObject(this.pbCurrentImage.Image),
                BookId = Convert.ToInt32(this.lbl_BookId.Text)
            };
            #endregion
            #region 调用后台方法保存数据
            try
            {
                if (objBookManager.EditBook(objBook) == 1)
                {
                    Book objEditBook = (from b in this.bookList where b.BookId == objBook.BookId select b).First<Book>();
                    objEditBook.BookName = objBook.BookName;
                    objEditBook.BookCategory = objBook.BookCategory;
                    objEditBook.PublisherId = objBook.PublisherId;
                    objEditBook.PublisherName = objBook.PublisherName;
                    objEditBook.PublishDate = objBook.PublishDate;
                    objEditBook.Author = objBook.Author;
                    objEditBook.UnitPrice = objBook.UnitPrice;
                    objEditBook.BookPosition = objBook.BookPosition;
                    objEditBook.BookImage = objBook.BookImage;
                    this.dgvBookList.Refresh();
                    MessageBox.Show("修改成功", "提示信息");
                }
                else
                {
                    MessageBox.Show("修改失败，请重试", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败，请重试。具体信息：" + ex.Message, "提示信息");
            }
            #endregion
        }

        private void FrmBookManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cameraControl.CloseCamera();
        }
    }
}
