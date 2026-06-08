using AForge.Video.DirectShow;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;
using xbd.s7netplus;

namespace wzw.PressurizationStationPro
{
    public partial class 参数设置 : Form
    {

        public 参数设置(SysInfo sysInfo, SysInfoService infoService, string sysInfoPath)
        {
            InitializeComponent();
            this.sysInfo = sysInfo;
            this.infoService = infoService;
            this.sysInfoPath = sysInfoPath;

            //初始化
            this.cmb_CPUType.DataSource = Enum.GetNames(typeof(CpuType));
            FilterInfoCollection infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo item in infoCollection)
            {
                this.cmb_Camera.Items.Add(item.Name);
            }
            if (sysInfo != null)
            {
                this.txt_IPAddress.Text = this.sysInfo.IPAddress;
                this.cmb_CPUType.Text = this.sysInfo.CpuType.ToString();
                this.txt_Rack.Text = this.sysInfo.Rack.ToString();
                this.txt_Slot.Text = this.sysInfo.Slot.ToString();
                this.toggle_AutoStart.Checked = this.sysInfo.AutoStart;
                this.txt_ScreenTime.Text = this.sysInfo.ScreenTime.ToString();
                this.txt_LogoffTime.Text = this.sysInfo.LogoffTime.ToString();
                if (infoCollection.Count>this.sysInfo.CameraIndex)
                {
                    this.cmb_Camera.SelectedIndex = this.sysInfo.CameraIndex;
                }
            }
            this.toggle_AutoStart.CheckedChanged += this.toggle_AutoStart_CheckedChanged;
        }

        private void btn_PLCSet_Click(object sender, EventArgs e)
        {
            if (this.sysInfo == null)
            {
                this.sysInfo = new SysInfo();
            }
            this.sysInfo.IPAddress = this.txt_IPAddress.Text;
            this.sysInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), this.cmb_CPUType.Text.Trim(), true);
            this.sysInfo.Rack = Convert.ToInt16(this.txt_Rack.Text.Trim());
            this.sysInfo.Slot = Convert.ToInt16(this.txt_Slot.Text.Trim());

            bool result = infoService.SetSysInfoToPath(this.sysInfo, this.sysInfoPath);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FrmMsgNoAck("通信参数写入失败", "通信参数").ShowDialog();
            }
        }

        private void btn_PLCCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_SysSet_Click(object sender, EventArgs e)
        {
            if (this.sysInfo == null)
            {
                this.sysInfo = new SysInfo();
            }
            this.sysInfo.AutoStart = this.toggle_AutoStart.Checked;
            this.sysInfo.ScreenTime = Convert.ToInt32(this.txt_ScreenTime.Text.Trim());
            this.sysInfo.LogoffTime = Convert.ToInt32(this.txt_LogoffTime.Text.Trim());
            this.sysInfo.CameraIndex = this.cmb_Camera.SelectedIndex;

            bool result = infoService.SetSysInfoToPath(this.sysInfo, this.sysInfoPath);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FrmMsgNoAck("系统参数写入失败", "系统参数").ShowDialog();
            }
        }

        private void btn_SysCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggle_AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart(this.toggle_AutoStart.Checked);
        }

        #region 开机启动
        /// <summary>  
        /// 修改程序在注册表中的键值  
        /// </summary>  
        /// <param name="isAuto">true:开机启动,false:不开机自启</param> 
        private void AutoStart(bool isAuto = true)
        {
            if (isAuto == true)
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.SetValue("PressurizationStationPro", System.Windows.Forms.Application.ExecutablePath);
                R_run.Close();
                R_local.Close();
            }
            else
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.DeleteValue("PressurizationStationPro", false);
                R_run.Close();
                R_local.Close();
            }
        }
        #endregion


        #region 无边框拖动
        private Point mpoint;
        private SysInfo sysInfo;
        private SysInfoService infoService;
        private string sysInfoPath;

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
