using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using Common;
using BLL;

namespace LibraryManagerPro
{
    public partial class FrmAdminLogin : Form
    {
        private SysAdminManager objAdminManager = new SysAdminManager();
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region 数据验证

            if (this.txtAdminId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入账号", "提示信息");
                this.txtAdminId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码", "提示信息");
                this.txtLoginPwd.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txtAdminId.Text.Trim()))
            {
                MessageBox.Show("账号不正确", "提示信息");
                this.txtAdminId.Focus();
                return;
            }

            #endregion

            #region 封装对象

            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = Convert.ToInt32(this.txtAdminId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text
            };

            #endregion

            #region 调用后台进行登录

            try
            {
                objAdmin = objAdminManager.AdminLogin(objAdmin);
                if (objAdmin != null)
                {
                    if (objAdmin.StatusId == 1)
                    {
                        Program.currentAdmin = objAdmin;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("账号已被锁定", "登录失败");
                    }
                }
                else
                {
                    MessageBox.Show("账号或密码错误", "登录失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常，请稍后再试：" + ex.Message, "异常提示");
            }

            #endregion
        }
        //取消登录
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //账号文本框keydown事件
        private void TxtAdminId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtLoginPwd.SelectAll();
                this.txtLoginPwd.Focus();
            }
        }
        //密码文本框keydown事件
        private void TxtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
