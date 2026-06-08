namespace wzw.PressurizationStationPro
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.cmb_User = new System.Windows.Forms.ComboBox();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackgroundImage = global::wzw.PressurizationStationPro.Properties.Resources.Login;
            this.Main_Panel.Controls.Add(this.btn_Login);
            this.Main_Panel.Controls.Add(this.txt_Pwd);
            this.Main_Panel.Controls.Add(this.cmb_User);
            this.Main_Panel.Controls.Add(this.lbl_Close);
            this.Main_Panel.Controls.Add(this.label1);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(433, 315);
            this.Main_Panel.TabIndex = 0;
            this.Main_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Main_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(62)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(62)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(62)))));
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(129, 222);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(201, 39);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(62)))));
            this.txt_Pwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Pwd.ForeColor = System.Drawing.Color.White;
            this.txt_Pwd.Location = new System.Drawing.Point(129, 182);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(201, 34);
            this.txt_Pwd.TabIndex = 3;
            this.txt_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pwd_KeyDown);
            // 
            // cmb_User
            // 
            this.cmb_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(62)))));
            this.cmb_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_User.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_User.ForeColor = System.Drawing.Color.White;
            this.cmb_User.FormattingEnabled = true;
            this.cmb_User.Location = new System.Drawing.Point(129, 131);
            this.cmb_User.Name = "cmb_User";
            this.cmb_User.Size = new System.Drawing.Size(201, 35);
            this.cmb_User.TabIndex = 2;
            this.cmb_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pwd_KeyDown);
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.White;
            this.lbl_Close.Location = new System.Drawing.Point(404, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(26, 27);
            this.lbl_Close.TabIndex = 1;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "智慧加压站SCADA监控系统";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 315);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.ComboBox cmb_User;
        private System.Windows.Forms.Button btn_Login;
    }
}