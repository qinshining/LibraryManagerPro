using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camera_NET;
using Models;
using BLL;

namespace LibraryManagerPro
{
    public partial class FrmEidtReader : Form
    {
        private CameraChoice cameraChoice = new CameraChoice();
        private ReaderManager objReaderManager = new ReaderManager();
        private Reader currentReader = null;
        public FrmEidtReader()
        {
            InitializeComponent();
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
            try
            {
                //用于新增读者的角色下拉框
                DataTable dt = objReaderManager.GetRoles();
                this.cboReaderRole.DataSource = dt;
                this.cboReaderRole.DisplayMember = "RoleName";
                this.cboReaderRole.ValueMember = "RoleId";
                this.cboReaderRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化发生异常，请检查：" + ex.Message, "异常提示");
            }
        }

        public FrmEidtReader(Reader objReader) : this()
        {
            this.txtReaderName.Text = objReader.ReaderName;
            this.txtReadingCard.Text = objReader.ReadingCard;
            this.rdoMale.Checked = objReader.Gender == "男";
            this.rdoFemale.Checked = objReader.Gender == "女";
            this.cboReaderRole.SelectedValue = objReader.RoleId;
            this.txtIDCard.Text = objReader.IDCard;
            this.txtPhone.Text = objReader.PhoneNumber;
            this.txtAddress.Text = objReader.ReaderAddress;
            this.txtPostcode.Text = objReader.PostCode;
            this.pbReaderPhoto.Image = objReader.ReaderImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(objReader.ReaderImage);
            this.currentReader = objReader;
        }

        #region 摄像头操作
        private void BtnStartVideo_Click(object sender, EventArgs e)
        {
            try
            {
                this.cameraChoice.UpdateDeviceList();
                cameraControl.SetCamera(cameraChoice.Devices[0].Mon, null);
                this.btnStartVideo.Enabled = false;
                this.btnCloseVideo.Enabled = true;
                this.btnTake.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("摄像头启动失败" + ex.Message, "提示信息");
            }
        }

        private void BtnCloseVideo_Click(object sender, EventArgs e)
        {
            this.cameraControl.CloseCamera();
            this.btnStartVideo.Enabled = true;
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
        }

        private void BtnTake_Click(object sender, EventArgs e)
        {
            if (!this.cameraControl.CameraCreated)
            {
                return;
            }
            Bitmap bitmap = this.cameraControl.SnapshotSourceImage();
            this.pbReaderPhoto.Image = bitmap;
        }

        private void FrmEidtReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cameraControl.CloseCamera();
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region 数据验证（非空验证）
            if (this.txtReaderName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入读者姓名", "提示信息");
                this.txtReaderName.Focus();
                return;
            }
            if (this.txtReadingCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入借阅证编号", "提示信息");
                this.txtReadingCard.Focus();
                return;
            }
            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("请选择性别", "提示信息");
                return;
            }
            if (this.cboReaderRole.SelectedIndex == -1)
            {
                MessageBox.Show("请选择会员角色", "提示信息");
                return;
            }
            if (!Common.DataValidate.IsIdentityCard(this.txtIDCard.Text.Trim()))
            {
                MessageBox.Show("请输入正确的身份证号", "提示信息");
                this.txtIDCard.SelectAll();
                this.txtIDCard.Focus();
                return;
            }
            if (this.txtPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入联系电话", "提示信息");
                this.txtPhone.Focus();
                return;
            }
            #endregion
            #region 重复验证
            try
            {
                if (objReaderManager.IsExistsReadingCard(this.txtReadingCard.Text.Trim(), currentReader.ReaderId.ToString()))
                {
                    MessageBox.Show("借阅证号重复，请修改", "提示信息");
                    this.txtReadingCard.SelectAll();
                    this.txtReadingCard.Focus();
                    return;
                }
                if (objReaderManager.IsExistsIDCard(this.txtIDCard.Text.Trim(), currentReader.ReaderId.ToString()))
                {
                    MessageBox.Show("身份证号重复，请修改", "提示信息");
                    this.txtIDCard.SelectAll();
                    this.txtIDCard.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("校验数据是否重复时发生异常，请重试：" + ex.Message, "提示信息");
                return;
            }
            #endregion
            #region 封装数据
            Reader objReader = new Reader()
            {
                ReaderName = this.txtReaderName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                RoleId = Convert.ToInt32(this.cboReaderRole.SelectedValue),
                IDCard = this.txtIDCard.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                ReaderAddress = this.txtAddress.Text.Trim(),
                PostCode = this.txtPostcode.Text.Trim(),
                ReaderImage = this.pbReaderPhoto.Image == null ? "" : new Common.SerializeObjectToString().SerializeObject(this.pbReaderPhoto.Image),
                ReaderId = this.currentReader.ReaderId
            };
            #endregion
            #region 调用后台方法执行
            try
            {
                objReaderManager.EditReader(objReader);
                MessageBox.Show("修改成功", "提示信息");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改发生异常：" + ex.Message, "异常提示");
            }
            #endregion
        }
    }
}
