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
    public partial class FrmReturnBook : Form
    {
        private ReaderManager objReaderManager = new ReaderManager();
        private BorrowManager objBorrowManager = new BorrowManager();
        private Reader currentReader = null;
        private List<BorrowDetail> borrowList = null;
        private List<BorrowDetail> returnList = new List<BorrowDetail>();


        #region 初始化
        public FrmReturnBook()
        {
            InitializeComponent();
            this.txtBarCode.Enabled = false;
            this.btnConfirmReturn.Enabled = false;
            this.dgvNonReturnList.AutoGenerateColumns = false;
            this.dgvReturnList.AutoGenerateColumns = false;
        }
        #endregion

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
            this.dgvNonReturnList.DataSource = null;
            this.dgvReturnList.DataSource = null;
            //状态控制
            this.txtBarCode.Enabled = false;
            this.btnConfirmReturn.Enabled = false;
            //变量重置
            this.currentReader = null;
            this.borrowList = null;
            this.returnList.Clear();
            //等待输入...
            this.txtReadingCard.SelectAll();
            this.txtReadingCard.Focus();
        }

        #region 显示读者信息（个人信息+图书借阅信息）
        private void TxtReadingCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtReadingCard.Text.Trim().Length != 0)
            {
                if (ChangeConfirm() != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    this.currentReader = objReaderManager.GetReaderByReadingCard(this.txtReadingCard.Text.Trim());
                    this.borrowList = objBorrowManager.GetBorrowDetails(this.txtReadingCard.Text.Trim());
                    this.returnList.Clear();
                    int borrowCount = (from b in this.borrowList select b).Sum(u => u.NonReturnCount);
                    if (this.currentReader != null)
                    {
                        if (this.currentReader.StatusId == 1)
                        {
                            this.lblReaderName.Text = this.currentReader.ReaderName;
                            this.lblRoleName.Text = this.currentReader.RoleName;
                            this.lblAllowCounts.Text = this.currentReader.AllowCounts.ToString();
                            this.lblBorrowCount.Text = borrowCount.ToString();
                            this.lbl_Remainder.Text = (this.currentReader.AllowCounts - borrowCount).ToString();
                            this.pbReaderImage.Image = this.currentReader.ReaderImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(this.currentReader.ReaderImage);
                            this.dgvNonReturnList.DataSource = this.borrowList;
                            this.dgvReturnList.DataSource = null;
                            if (this.dgvNonReturnList.RowCount > 0)
                            {
                                this.txtBarCode.Enabled = true;
                                this.txtBarCode.Focus();
                            }
                        }
                        else
                        {
                            ResetForm();
                            MessageBox.Show("该借阅证已挂失，请确认", "提示信息");
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

        #region 显示还书列表
        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtBarCode.Text.Length != 0)
            {
                bool isBookExists = (from b in this.borrowList where b.BarCode == this.txtBarCode.Text.Trim() select b).Count() > 0;
                if (!isBookExists)
                {
                    MessageBox.Show("该图书不在待还列表，请检查", "提示信息");
                    this.txtBarCode.SelectAll();
                    this.txtBarCode.Focus();
                    return;
                }
                BorrowDetail objCurrentDetail = (from b in this.borrowList where b.BarCode == this.txtBarCode.Text.Trim() select b).First<BorrowDetail>();
                int borrowCount = (from b in this.borrowList where b.BarCode == this.txtBarCode.Text.Trim() select b).Sum(u => u.NonReturnCount);
                int returnCount = (from r in this.returnList where r.BarCode == this.txtBarCode.Text.Trim() select r).Count();
                if (returnCount == 0)
                {
                    this.returnList.Add(new BorrowDetail()
                    {
                        BarCode = objCurrentDetail.BarCode,
                        BookName = objCurrentDetail.BookName,
                        ReturnCount = 1
                    });
                    this.dgvReturnList.DataSource = null;
                    this.dgvReturnList.DataSource = this.returnList;
                    this.btnConfirmReturn.Enabled = true;
                }
                else
                {
                    BorrowDetail returnDetail = (from r in this.returnList where r.BarCode == objCurrentDetail.BarCode select r).First<BorrowDetail>();
                    if (borrowCount <= returnDetail.ReturnCount)
                    {
                        MessageBox.Show("还书数量超出借阅数，请检查", "提示信息");
                        this.txtBarCode.Clear();
                        this.txtBarCode.Focus();
                        return;
                    }
                    else
                    {
                        returnDetail.ReturnCount += 1;
                        this.dgvReturnList.Refresh();
                    }
                }
                this.lblReturnCount.Text = (from r in this.returnList select r.ReturnCount).Sum().ToString();
                this.txtBarCode.Clear();
                this.txtBarCode.Focus();
            }
        }
        #endregion

        #region 还书操作
        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            try
            {
                objBorrowManager.ReturnBooks(this.returnList, this.borrowList, Program.currentAdmin.AdminName);
                MessageBox.Show("还书成功");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询读者信息发生异常：" + ex.Message, "异常提示");
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DialogResult ChangeConfirm()
        {
            DialogResult result = DialogResult.OK;
            if (this.dgvReturnList.Rows.Count > 0)
            {
                result = MessageBox.Show("存在未保存的还书信息，确认切换吗？", "询问信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            return result;
        }
        private void FrmReturnBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangeConfirm() != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
