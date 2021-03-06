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
    public partial class FrmReaderManger : Form
    {
        private ReaderManager objReaderManager = new ReaderManager();
        private CameraChoice cameraChoice = new CameraChoice();
        private Reader currentReader = null;
        public FrmReaderManger()
        {
            InitializeComponent();
            this.btnEdit.Enabled = false;
            this.btnEnable.Enabled = false;
            this.btnCloseVideo.Enabled = false;
            this.btnTake.Enabled = false;
            //初始化下拉框
            try
            {
                //用于新增读者的角色下拉框
                DataTable dt = objReaderManager.GetRoles();
                this.cboReaderRole.DataSource = dt;
                this.cboReaderRole.DisplayMember = "RoleName";
                this.cboReaderRole.ValueMember = "RoleId";
                this.cboReaderRole.SelectedIndex = -1;
                //用于查询的角色下拉框
                DataTable dtNew = dt.Copy();
                DataRow dr = dtNew.NewRow();
                dr["RoleName"] = "全部";
                dr["RoleId"] = -1;
                dtNew.Rows.InsertAt(dr, 0);
                this.cboRole.DataSource = dtNew;
                this.cboRole.DisplayMember = "RoleName";
                this.cboRole.ValueMember = "RoleId";
                this.cboRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化发生异常，请检查：" + ex.Message, "异常提示");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //按角色查询
        private void BtnQueryReader_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvReader.Items.Clear();
                List<Reader> readerList = objReaderManager.GetReaders(this.cboRole.SelectedValue.ToString());
                foreach (Reader reader in readerList)
                {
                    ListViewItem lvItem = new ListViewItem(reader.ReaderId.ToString());
                    lvItem.SubItems.AddRange(new string[]
                    {
                        reader.ReadingCard,
                        reader.ReaderName,
                        reader.Gender,
                        reader.PhoneNumber,
                        reader.RoleName,
                        reader.StatusDes,
                        reader.RegTime.ToShortDateString(),
                        reader.ReaderAddress
                    });
                    this.lvReader.Items.Add(lvItem);
                }
                this.lblReaderCount.Text = this.lvReader.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询发生异常，请检查：" + ex.Message, "异常提示");
            }
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

        private void FrmReaderManger_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cameraControl.CloseCamera();
        }
        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
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
                if (objReaderManager.IsExistsReadingCard(this.txtReadingCard.Text.Trim()))
                {
                    MessageBox.Show("借阅证号重复，请修改", "提示信息");
                    this.txtReadingCard.SelectAll();
                    this.txtReadingCard.Focus();
                    return;
                }
                if (objReaderManager.IsExistsIDCard(this.txtIDCard.Text.Trim()))
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
                ReadingCard = this.txtReadingCard.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                RoleId = Convert.ToInt32(this.cboReaderRole.SelectedValue),
                IDCard = this.txtIDCard.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                ReaderAddress = this.txtAddress.Text.Trim(),
                PostCode = this.txtPostcode.Text.Trim(),
                ReaderImage = this.pbReaderPhoto.Image == null ? "" : new Common.SerializeObjectToString().SerializeObject(this.pbReaderPhoto.Image),
                ReaderPwd = "123456",
                AdminId = Program.currentAdmin.AdminId
            };
            #endregion
            #region 调用后台方法执行
            try
            {
                objReaderManager.AddReader(objReader);
                MessageBox.Show("添加成功", "提示信息");
                this.txtReaderName.Clear();
                this.txtReadingCard.Clear();
                this.rdoMale.Checked = false;
                this.rdoFemale.Checked = false;
                this.cboReaderRole.SelectedIndex = -1;
                this.txtIDCard.Clear();
                this.txtPhone.Clear();
                this.txtAddress.Clear();
                this.txtPostcode.Clear();
                this.pbReaderPhoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加发生异常：" + ex.Message, "异常提示");
            }
            #endregion
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_ReadingCard.Text.Trim().Length != 0 && this.rdoReadingCard.Checked)
                {
                    this.currentReader = objReaderManager.GetReaderByReadingCard(this.txt_ReadingCard.Text.Trim());
                }
                else if (this.txt_IDCard.Text.Trim().Length != 0 && this.rdoIDCard.Checked)
                {
                    this.currentReader = objReaderManager.GetReaderByIDCard(this.txt_IDCard.Text.Trim());
                }
                else
                {
                    return;
                }
                if (this.currentReader != null)
                {
                    this.lblReaderName.Text = this.currentReader.ReaderName;
                    this.lblReadingCard.Text = this.currentReader.ReadingCard;
                    this.lblGender.Text = this.currentReader.Gender;
                    this.lblRoleName.Text = this.currentReader.RoleName;
                    this.lblIDCard.Text = this.currentReader.IDCard;
                    this.lblPhone.Text = this.currentReader.PhoneNumber;
                    this.lblAddress.Text = this.currentReader.ReaderAddress;
                    this.lblPostCode.Text = this.currentReader.PostCode;
                    this.pbReaderImg.Image = this.currentReader.ReaderImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(this.currentReader.ReaderImage);
                    this.btnEdit.Enabled = true;
                    this.btnEnable.Enabled = true;
                    this.btnEnable.Text = this.currentReader.StatusId == 1 ? "挂失借阅证 " : "恢复启用";
                }
                else
                {
                    MessageBox.Show("没有查询到读者信息，请检查查询条件是否正确", "提示信息");
                    this.lblReaderName.Text = "";
                    this.lblReadingCard.Text = "";
                    this.lblGender.Text = "";
                    this.lblRoleName.Text = "";
                    this.lblIDCard.Text = "";
                    this.lblPhone.Text = "";
                    this.lblAddress.Text = "";
                    this.lblPostCode.Text = "";
                    this.pbReaderImg.Image = null;
                    this.btnEdit.Enabled = false;
                    this.btnEnable.Enabled = false;
                    this.btnEnable.Text = "挂失借阅证 ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询过程中发生异常：" + ex.Message, "异常提示");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentReader == null)
            {
                return;
            }
            FrmEidtReader frmEdit = new FrmEidtReader(this.currentReader);
            DialogResult result = frmEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                BtnQuery_Click(null, null);//TODO 优化用户体验，如用户查询到信息后，修改了文本框内容后没有点击查询，直接点击修改，修改后会查询不到修改的内容，或者查询到另一个读者信息
            }
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            if (this.currentReader == null)
            {
                return;
            }
            string changedStatus = string.Empty;
            DialogResult result = DialogResult.No;
            if (this.currentReader.StatusId == 1)
            {
                changedStatus = "2";
                result = MessageBox.Show("确定要挂失该借阅证吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                changedStatus = "1";
                result = MessageBox.Show("确定要重新启用该借阅证吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    objReaderManager.ChangeReaderCardStatus(changedStatus, this.currentReader.ReaderId.ToString());
                    this.currentReader.StatusId = Convert.ToInt32(changedStatus);
                    if (changedStatus == "2")
                    {
                        MessageBox.Show("挂失成功", "提示信息");
                        this.btnEnable.Text = this.currentReader.StatusId == 1 ? "挂失借阅证 " : "恢复启用";
                    }
                    else
                    {
                        MessageBox.Show("启用成功", "提示信息");
                        this.btnEnable.Text = this.currentReader.StatusId == 1 ? "挂失借阅证 " : "恢复启用";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生异常：" + ex.Message, "操作失败");
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cameraControl.CloseCamera();
        }
    }
}
