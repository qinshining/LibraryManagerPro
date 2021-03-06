using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.tssl_AdminName.Text = Program.currentAdmin.AdminName;
        }
        //新增图书
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            TsmiAddBook_Click(null, null);
        }
        //图书维护
        private void btnBookManage_Click(object sender, EventArgs e)
        {
            TsmiBookManage_Click(null, null);
        }
        //图书出借
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            TsmiBorrowBook_Click(null, null);
        }
        //图书上架
        private void btnBookNew_Click(object sender, EventArgs e)
        {
            TsmiBookNew_Click(null, null);
        }
        //图书归还
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            TsmiReturnBook_Click(null, null);
        }
        //会员管理
        private void btnReaderManager_Click(object sender, EventArgs e)
        {
            TsmiMemberManage_Click(null, null);
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            TsmiModifyPwd_Click(null, null);
        }
        //退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //嵌入新窗体
        private void ShowNewForm(Form objFrm)
        {
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            objFrm.TopLevel = false;
            objFrm.FormBorderStyle = FormBorderStyle.None;
            objFrm.Parent = this.spContainer.Panel2;
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
        }

        #region 菜单栏
        //修改密码
        private void TsmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objFrm = new FrmModifyPwd();
            objFrm.ShowDialog();
        }
        //退出系统
        private void TsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //新增图书
        private void TsmiAddBook_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmAddBook)
            {
                return;
            }
            this.lblOperationName.Text = "新增图书";
            FrmAddBook objFrm = new FrmAddBook();
            ShowNewForm(objFrm);
        }
        //图书上架
        private void TsmiBookNew_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmNewBook)
            {
                return;
            }
            this.lblOperationName.Text = "图书上架";
            FrmNewBook objFrm = new FrmNewBook();
            ShowNewForm(objFrm);
        }
        //图书维护
        private void TsmiBookManage_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmBookManager)
            {
                return;
            }
            this.lblOperationName.Text = "图书维护";
            FrmBookManager objFrm = new FrmBookManager();
            ShowNewForm(objFrm);
        }
        //图书出借
        private void TsmiBorrowBook_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmBorrowBook)
            {
                return;
            }
            this.lblOperationName.Text = "图书出借";
            FrmBorrowBook objFrm = new FrmBorrowBook();
            ShowNewForm(objFrm);
        }
        //图书归还
        private void TsmiReturnBook_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmReturnBook)
            {
                return;
            }
            this.lblOperationName.Text = "图书归还";
            FrmReturnBook objFrm = new FrmReturnBook();
            ShowNewForm(objFrm);
        }
        //会员管理
        private void TsmiMemberManage_Click(object sender, EventArgs e)
        {
            if (this.spContainer.Panel2.Controls.Count > 0 && this.spContainer.Panel2.Controls[0] is FrmReaderManger)
            {
                return;
            }
            this.lblOperationName.Text = "会员管理";
            FrmReaderManger objFrm = new FrmReaderManger();
            ShowNewForm(objFrm);
        }

        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
