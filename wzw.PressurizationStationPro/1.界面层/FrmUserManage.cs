using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wzw.PressurizationStationPro
{
    public partial class FrmUserManage : Form
    {
        public FrmUserManage()
        {
            InitializeComponent();
            this.dgv_User.AutoGenerateColumns = false;
            this.Load += FrmUserManage_Load;
        }

        private SysAdminService adminService = new SysAdminService();
        List<SysAdmin> sysAdmins = new List<SysAdmin>();
        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            this.cmb_RoleName.Items.AddRange(Enum.GetNames(typeof(RoleName)));
            RefreshUserList();
            if(sysAdmins.Count > 0 )
            {
                UpdateUserInfo(sysAdmins.First());
            }
        }
        /// <summary>
        /// 刷新用户列表
        /// </summary>
        private void RefreshUserList()
        {
            sysAdmins = adminService.QuerySysAdmins();
            if (sysAdmins.Count > 0)
            {
                this.dgv_User.DataSource = null;
                this.dgv_User.DataSource = this.sysAdmins;
            }
            else
            {
                this.dgv_User.DataSource = null;
            }
        }
        //更新信息
        private void UpdateUserInfo(SysAdmin sysAdmin)
        {
            this.txt_LoginName.Text = sysAdmin.LoginName;
            this.txt_LoginPwd.Text = StringSecurityHelper.DESDecrypt(sysAdmin.LoginPwd);
            this.cmb_RoleName.Text = sysAdmin.RoleName.ToString();
        }

        private void dgv_User_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(this.dgv_User, e);
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            //非空判断
            if (this.txt_LoginName.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户名不能为空!", "增加用户").ShowDialog();
                return;
            }
            if (this.txt_LoginPwd.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户密码不能为空!", "增加用户").ShowDialog();
                return;
            }
            if (this.cmb_RoleName.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户角色不能为空!", "增加用户").ShowDialog();
                return;
            }
            //【2】判断是否存在
            if (sysAdmins.Where(c => c.LoginName == this.txt_LoginName.Text.Trim()).Count() > 0)
            {
                new FrmMsgNoAck("该用户名已存在，请更换!", "增加用户").ShowDialog();
                return;
            }
            //【3】封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName = this.txt_LoginName.Text.Trim(),
                LoginPwd = StringSecurityHelper.DESEncrypt(this.txt_LoginPwd.Text.Trim()),
                RoleName = (RoleName)Enum.Parse(typeof(RoleName), this.cmb_RoleName.Text)
            };

            //【4】添加用户
            if (adminService.AddSysAdmin(sysAdmin))
            {
                //刷新用户列表
                RefreshUserList();
            }
            else
            {
                new FrmMsgNoAck("添加用户失败，请检查!", "增加用户").ShowDialog();
                return;
            }
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            //非空判断
            if (this.txt_LoginName.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户名不能为空!", "修改用户").ShowDialog();
                return;
            }
            if (this.txt_LoginPwd.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户密码不能为空!", "修改用户").ShowDialog();
                return;
            }
            if (this.cmb_RoleName.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("用户角色不能为空!", "修改用户").ShowDialog();
                return;
            }
            //【2】封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginId = sysAdmins[this.dgv_User.SelectedRows[0].Index].LoginId,
                LoginName = this.txt_LoginName.Text.Trim(),
                LoginPwd = StringSecurityHelper.DESEncrypt(this.txt_LoginPwd.Text.Trim()),
                RoleName = (RoleName)Enum.Parse(typeof(RoleName), this.cmb_RoleName.Text)
            };

            //【3】修改用户
            if (adminService.ModifySysAdmin(sysAdmin))
            {
                //刷新用户列表
                RefreshUserList();
            }
            else
            {
                new FrmMsgNoAck("修改用户失败，请检查!", "修改用户").ShowDialog();
                return;
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if(this.dgv_User.SelectedRows.Count > 0)
            {
                //int loginId = Convert.ToInt32(this.dgv_User.SelectedRows[0].Cells[3].Value);
                int loginId = sysAdmins[this.dgv_User.SelectedRows[0].Index].LoginId;
                if (adminService.DeleteSysAdmin(loginId))
                {
                    RefreshUserList();
                }
                else
                {
                    new FrmMsgNoAck("删除用户失败，请检查!", "删除用户").ShowDialog();
                    return;
                }
            }
        }

        //点击哪行，就选中哪行的信息
        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateUserInfo(sysAdmins[e.RowIndex]);
            }
        }

        private void dgv_User_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1 && e.Value != null)
                {
                    e.Value = StringSecurityHelper.DESDecrypt(e.Value.ToString());
                }
            }
        }

        #region 无边框拖动
        private Point mpoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }
        }







        #endregion


    }
}
