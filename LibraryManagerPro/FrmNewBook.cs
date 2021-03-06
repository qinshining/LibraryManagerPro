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

namespace LibraryManagerPro
{
    public partial class FrmNewBook : Form
    {
        private BookManager objBookManager = new BookManager();
        private List<Book> bookList = new List<Book>();
        public FrmNewBook()
        {
            InitializeComponent();
            this.txtAddCount.Enabled = false;
            this.dgvBookList.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入图书条码", "提示信息");
                this.txtBarCode.Focus();
                return;
            }
            if (!Common.DataValidate.IsInteger(this.txtAddCount.Text.Trim()))
            {
                MessageBox.Show("请输入正整数的图书新增总数", "提示信息");
                this.txtAddCount.SelectAll();
                this.txtAddCount.Focus();
                return;
            }
            try
            {
                int result = objBookManager.AddBookCount(this.txtBarCode.Text.Trim(), Convert.ToInt32(this.txtAddCount.Text.Trim()));
                if (result == 1)
                {
                    MessageBox.Show("新增成功", "提示信息");
                    Book objBook = (from b in this.bookList where b.BarCode == this.txtBarCode.Text.Trim() select b).First<Book>();
                    objBook.BookCount += Convert.ToInt32(this.txtAddCount.Text.Trim());
                    objBook.Remainder += Convert.ToInt32(this.txtAddCount.Text.Trim());
                    this.dgvBookList.Refresh();
                    this.txtAddCount.Enabled = false;
                    this.lblBookName.Text = "";
                    this.lblCategory.Text = "";
                    this.lblBookCount.Text = "";
                    this.lblBookPosition.Text = "";
                    this.lblBookId.Text = "";
                    this.pbImage.Image = null;
                    this.txtBarCode.Clear();
                    this.txtAddCount.Clear();
                }
                else
                {
                    MessageBox.Show("新增失败，请刷新后重试", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失败，具体原因：" + ex.Message, "提示信息");
            }
        }

        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtBarCode.Text.Trim().Length != 0)
            {
                TxtBarCode_Leave(null, null);
            }
        }

        private void TxtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                try
                {
                    Book objBook = objBookManager.GetBookByBarCode(this.txtBarCode.Text.Trim());
                    if (objBook != null)
                    {
                        this.txtAddCount.Enabled = true;
                        this.lblBookName.Text = objBook.BookName;
                        this.lblCategory.Text = objBook.CategoryName;
                        this.lblBookCount.Text = objBook.BookCount.ToString();
                        this.lblBookPosition.Text = objBook.BookPosition;
                        this.lblBookId.Text = objBook.BookId.ToString();
                        this.pbImage.Image = objBook.BookImage == string.Empty ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(objBook.BookImage);
                        int count = (from b in this.bookList where b.BookId == objBook.BookId select b).Count();
                        if (count == 0)
                        {
                            this.bookList.Add(objBook);
                            this.dgvBookList.DataSource = null;
                            this.dgvBookList.DataSource = this.bookList;
                        }
                        else
                        {
                            int index = 0;
                            foreach (DataGridViewRow item in this.dgvBookList.Rows)
                            {
                                if (item.Cells["BarCode"].Value.ToString() == objBook.BarCode)
                                {
                                    index = item.Index;
                                    break;
                                }
                            }
                            this.dgvBookList.Rows[index].Selected = true;//TODO 设置之后currentrow并没有改变
                        }
                    }
                    else
                    {
                        this.txtAddCount.Enabled = false;
                        MessageBox.Show("条码错误", "提示信息");
                        this.txtBarCode.SelectAll();
                        this.txtBarCode.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("系统异常：" + ex.Message, "提示信息");
                }
            }
        }

        private void TxtAddCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtAddCount.Text.Trim().Length != 0)
            {
                BtnSave_Click(null, null);
            }
        }

        private void DgvBookList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }
    }
}
