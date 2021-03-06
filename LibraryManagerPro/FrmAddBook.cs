using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;
using Camera_NET;

namespace LibraryManagerPro
{
    public partial class FrmAddBook : Form
    {
        private BookManager objBookManager = new BookManager();
        private string[] exts = { ".bmp", ".jpg", ".jpeg", ".jpe", ".png" };
        private CameraChoice cameraChoice = new CameraChoice();
        private List<Book> books = new List<Book>();

        public FrmAddBook()
        {
            InitializeComponent();
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
            this.dgvBookList.AutoGenerateColumns = false;
            try
            {
                //初始化图书分类下拉框
                this.cboBookCategory.DataSource = objBookManager.GetAllCategories();
                this.cboBookCategory.DisplayMember = "CategoryName";
                this.cboBookCategory.ValueMember = "CategoryId";
                this.cboBookCategory.SelectedIndex = -1;
                //初始化出版社下拉框
                this.cboPublisher.DataSource = objBookManager.GetAllPublishers();
                this.cboPublisher.DisplayMember = "PublisherName";
                this.cboPublisher.ValueMember = "PublisherId";
                this.cboPublisher.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生异常，请重试。具体信息：" + ex.Message, "异常提示");
            }
        }
        //启动摄像头
        private void btnStartVideo_Click(object sender, EventArgs e)
        {
            try
            {
                //刷新摄像头
                cameraChoice.UpdateDeviceList();
                cameraControl.SetCamera(cameraChoice.Devices[0].Mon, null);//要先启动摄像头，不然接下来这句报错：camera is not created
                ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);
                Resolution currentResolution = null;
                foreach (Resolution item in resolutions)
                {
                    if (item.CompareTo(cameraControl.Resolution) == 0)
                    {
                        currentResolution = item;
                        break;
                    }
                }
                if (currentResolution == null)
                {
                    currentResolution = resolutions[0];
                }
                cameraControl.SetCamera(cameraChoice.Devices[0].Mon, currentResolution);
                this.btnStartVideo.Enabled = false;
                this.btnCloseVideo.Enabled = true;
                this.btnTake.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("摄像头启动失败：" + ex.Message, "异常提示");
            }
        }
        //关闭摄像头
        private void btnCloseVideo_Click(object sender, EventArgs e)
        {
            this.cameraControl.CloseCamera();
            this.btnStartVideo.Enabled = true;
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
        }
        //开始拍照
        private void btnTake_Click(object sender, EventArgs e)
        {
            if (!cameraControl.CameraCreated)
            {
                return;
            }
            Bitmap bitmap = this.cameraControl.SnapshotSourceImage();
            if (bitmap != null)
            {
                this.pbCurrentImage.Image = bitmap;
                this.pbCurrentImage.Update();
            }
        }
        //选择图片
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileExtension = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('.'));
                if (!exts.Contains(fileExtension))
                {
                    MessageBox.Show("不支持的文件类型，请重新选择！", "提示信息");
                    this.pbCurrentImage.Image = null;
                    return;
                }
                this.pbCurrentImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        //清除   
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbCurrentImage.Image = null;
        }
        //判断图书条码是否已经存在
        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length == 0)
            {
                return;
            }
            try
            {
                if (objBookManager.GetCountByCode(this.txtBarCode.Text.Trim()))
                {
                    MessageBox.Show("该编号已被使用，请调整", "提示信息");
                    this.txtBarCode.SelectAll();
                    this.txtBarCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查编号是否重复时发生异常：" + ex.Message);
            }
        }
        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtBarCode_Leave(null, null);
            }
        }
        //确认添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtBookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入图书名称", "提示信息");
                this.txtBookName.Focus();
                return;
            }
            if (this.cboBookCategory.SelectedIndex == -1)
            {
                MessageBox.Show("请选择图书分类", "提示信息");
                return;
            }
            if (this.cboPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("请选择图书出版社", "提示信息");
                return;
            }
            if (this.txtAuthor.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入主编人", "提示信息");
                this.txtAuthor.Focus();
                return;
            }
            if (!Common.DataValidate.IsDecimal(this.txtUnitPrice.Text.Trim()))
            {
                MessageBox.Show("请输入正确的单价", "提示信息");
                this.txtUnitPrice.Focus();
                return;
            }
            if (this.txtBarCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入图书条码", "提示信息");
                this.txtBarCode.Focus();
                return;
            }
            if (!Common.DataValidate.IsInteger(this.txtBookCount.Text.Trim()))
            {
                MessageBox.Show("请输入正确的收藏总数", "提示信息");
                this.txtBookCount.Focus();
                return;
            }
            if (this.txtBookPosition.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入书架位置", "提示信息");
                this.txtBookPosition.Focus();
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
                BookName = this.txtBookName.Text.Trim(),
                BookCategory = Convert.ToInt32(this.cboBookCategory.SelectedValue),
                PublisherId = Convert.ToInt32(this.cboPublisher.SelectedValue),
                PublisherName = this.cboPublisher.Text,
                PublishDate = Convert.ToDateTime(this.dtpPublishDate.Text),
                Author = this.txtAuthor.Text.Trim(),
                UnitPrice = Convert.ToDecimal(this.txtUnitPrice.Text.Trim()),
                BarCode = this.txtBarCode.Text.Trim(),
                BookCount = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                Remainder = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                BookPosition = this.txtBookPosition.Text.Trim(),
                BookImage = new Common.SerializeObjectToString().SerializeObject(this.pbCurrentImage.Image)
            };
            #endregion
            #region 调用后台方法保存数据
            try
            {
                if (objBookManager.AddBook(objBook))
                {
                    this.books.Add(objBook);
                    this.dgvBookList.DataSource = null;
                    this.dgvBookList.DataSource = this.books;
                    foreach (Control item in this.gbBook.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                        else if (item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = -1;
                        }
                    }
                    this.pbCurrentImage.Image = null;
                    MessageBox.Show("添加成功", "提示信息");
                }
                else
                {
                    MessageBox.Show("添加失败，请重试", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败，请重试。具体信息：" + ex.Message, "提示信息");
            }
            #endregion
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvBookList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }

        private void FrmAddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cameraControl.CloseCamera();
        }
    }
}
