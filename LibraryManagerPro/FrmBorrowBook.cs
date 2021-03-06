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
    public partial class FrmBorrowBook : Form
    {
        private ReaderManager objReaderManager = new ReaderManager();
        private BookManager objBookManager = new BookManager();
        private BorrowManager objBorrowManager = new BorrowManager();
        private Reader currentReader = null;
        private List<BorrowDetail> detailList = new List<BorrowDetail>();
        public FrmBorrowBook()
        {
            InitializeComponent();
            this.dgvBookList.AutoGenerateColumns = false;
            this.txtBarCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDel.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //重置界面
        private void ResetForm()
        {
            //信息清空
            this.lblReaderName.Text = "";
            this.lblRoleName.Text = "";
            this.lblAllowCounts.Text = "";
            this.lblBorrowCount.Text = "";
            this.lbl_Remainder.Text = "";
            this.pbReaderImage.Image = null;
            this.dgvBookList.DataSource = null;
            //状态控制
            this.txtBarCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDel.Enabled = false;
            //变量重置
            this.currentReader = null;
            this.detailList.Clear();
            //等待输入...
            this.txtReadingCard.SelectAll();
            this.txtReadingCard.Focus();
        }
        #region 查询用户信息
        private void TxtReadingCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtReadingCard.Text.Trim().Length != 0)
            {
                if (this.dgvBookList.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("当前信息未保存，是否切换？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        ResetForm();
                    }
                }
                try
                {
                    this.currentReader = objReaderManager.GetReaderByReadingCard(this.txtReadingCard.Text.Trim());
                    int borrowedCount = objBorrowManager.GetBorrowedCount(this.txtReadingCard.Text.Trim());
                    if (this.currentReader != null)
                    {
                        if (this.currentReader.StatusId == 1)
                        {
                            this.currentReader.BorrowCount = 0;
                            this.lblReaderName.Text = this.currentReader.ReaderName;
                            this.lblRoleName.Text = this.currentReader.RoleName;
                            this.lblAllowCounts.Text = this.currentReader.AllowCounts.ToString();
                            this.lblBorrowCount.Text = borrowedCount.ToString();
                            this.lbl_Remainder.Text = (this.currentReader.AllowCounts - borrowedCount).ToString();
                            this.pbReaderImage.Image = this.currentReader.ReaderImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(this.currentReader.ReaderImage);
                            this.txtBarCode.Enabled = true;
                            this.txtBarCode.Focus();
                        }
                        else
                        {
                            ResetForm();
                            MessageBox.Show("该借阅证已挂失，无法借书", "提示信息");
                        }
                    }
                    else
                    {
                        ResetForm();
                        MessageBox.Show("未查询到读者信息，请检查借阅证号是否正确", "提示信息");
                    }
                }
                catch (Exception ex)
                {
                    ResetForm();
                    MessageBox.Show("查询读者信息发生异常：" + ex.Message, "异常提示");
                }
            }
        }
        #endregion
        #region 扫码添加图书
        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtBarCode.Text.Trim().Length != 0)
            {
                if (this.currentReader.BorrowCount == Convert.ToInt32(this.lbl_Remainder.Text))
                {
                    MessageBox.Show("借阅数已达上限", "提示信息");
                    this.txtBarCode.SelectAll();
                    this.txtBarCode.Focus();
                    return;
                }
                try
                {
                    Book objBook = objBookManager.GetBookByBarCode(this.txtBarCode.Text.Trim());
                    if (objBook == null)
                    {
                        MessageBox.Show("未查询到图书信息", "提示信息");
                        this.txtBarCode.SelectAll();
                        this.txtBarCode.Focus();
                        return;
                    }
                    int count = (from b in this.detailList where b.BookId == objBook.BookId select b).Count();
                    if (count == 0)
                    {
                        if (objBook.Remainder <= 0)
                        {
                            MessageBox.Show("该图书库存不足，是否补充后再出借，请检查", "提示信息");
                            this.txtBarCode.SelectAll();
                            this.txtBarCode.Focus();
                            return;
                        }
                        DateTime dt = objBorrowManager.GetServerTime();
                        this.detailList.Add(new BorrowDetail
                        {
                            BookId = objBook.BookId,
                            BarCode = objBook.BarCode,
                            BookName = objBook.BookName,
                            Expire = dt.AddDays(this.currentReader.AllowDay),
                            BorrowCount = 1,
                            ReturnCount = 0,
                            NonReturnCount = 1
                        });
                        this.dgvBookList.DataSource = null;
                        this.dgvBookList.DataSource = this.detailList;
                        this.btnSave.Enabled = true;
                        this.btnDel.Enabled = true;
                        this.currentReader.BorrowCount += 1;
                        this.txtBarCode.Clear();
                        this.txtBarCode.Focus();
                    }
                    else
                    {
                        BorrowDetail borrowDetail = (from b in this.detailList where b.BookId == objBook.BookId select b).First<BorrowDetail>();
                        if (objBook.Remainder <= borrowDetail.BorrowCount)
                        {
                            MessageBox.Show("该图书库存不足，是否补充后再出借，请检查", "提示信息");
                            this.txtBarCode.SelectAll();
                            this.txtBarCode.Focus();
                            return;
                        }
                        borrowDetail.BorrowCount += 1;
                        borrowDetail.NonReturnCount += 1;
                        this.dgvBookList.Refresh();
                        this.currentReader.BorrowCount += 1;
                        this.txtBarCode.Clear();
                        this.txtBarCode.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询图书过程中发生异常：" + ex.Message, "异常提示");
                }
            }
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.detailList.Count == 0)
            {
                return;
            }
            string borrowId = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            BorrowInfo objBorrowInfo = new BorrowInfo()
            {
                BorrowId = borrowId,
                ReaderId = this.currentReader.ReaderId,
                AdminName_B = Program.currentAdmin.AdminName
            };
            for (int i = 0; i < this.detailList.Count; i++)
            {
                this.detailList[i].BorrowId = objBorrowInfo.BorrowId;
            }
            try
            {
                objBorrowManager.AddBorrowInfo(objBorrowInfo, this.detailList);
                MessageBox.Show("借阅成功", "提示信息");
                ResetForm();
                this.txtReadingCard.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生异常：" + ex.Message, "异常提示");
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.CurrentRow == null)
            {
                return;
            }
            BorrowDetail borrowDetail = this.dgvBookList.CurrentRow.DataBoundItem as BorrowDetail;
            this.detailList.Remove(borrowDetail);
            this.currentReader.BorrowCount -= borrowDetail.BorrowCount;
            this.dgvBookList.DataSource = null;
            this.dgvBookList.DataSource = this.detailList;
            if (this.detailList.Count == 0)
            {
                this.btnSave.Enabled = false;
                this.btnDel.Enabled = false;
            }
        }
    }
}
