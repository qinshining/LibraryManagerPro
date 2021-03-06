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
    public partial class FrmModifyPwd : Form
    {
        private SysAdminManager objAdminManager = new SysAdminManager();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码", "提示信息");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwdConfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("请确认密码", "提示信息");
                this.txtNewPwdConfirm.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim() != this.txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("两次输入的新密码不一致", "提示信息");
                return;
            }
            if (this.txtOldPwd.Text.Trim() != Program.currentAdmin.LoginPwd)
            {
                MessageBox.Show("原密码不正确");
                this.txtOldPwd.SelectAll();
                this.txtOldPwd.Focus();
                return;
            }
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = Program.currentAdmin.AdminId,
                LoginPwd = this.txtNewPwd.Text.Trim()
            };
            try
            {
                int result = objAdminManager.ModifyPwd(objAdmin);
                if (result == 1)
                {
                    Program.currentAdmin.LoginPwd = objAdmin.LoginPwd;
                    MessageBox.Show("修改成功", "提示信息");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("未能正确修改，请检查信息是否存在", "修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常：" + ex.Message, "修改失败");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
