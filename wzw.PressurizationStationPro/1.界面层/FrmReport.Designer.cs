namespace wzw.PressurizationStationPro
{
    partial class FrmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dtp_ReportTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_ReportType = new System.Windows.Forms.ComboBox();
            this.rdb_Max = new System.Windows.Forms.RadioButton();
            this.rdb_Mini = new System.Windows.Forms.RadioButton();
            this.rdb_Avg = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Exit.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.White;
            this.lbl_Exit.Location = new System.Drawing.Point(1094, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(49, 46);
            this.lbl_Exit.TabIndex = 3;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(61, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(106, 31);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "数据报表";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1143, 1);
            this.label1.TabIndex = 1;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "PressureTankOut";
            this.Column11.HeaderText = "水箱出口压力";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "LevelTank2";
            this.Column10.HeaderText = "水箱液位2";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 85;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "LevelTank1";
            this.Column9.HeaderText = "水箱液位1";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 85;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PressureTank2";
            this.Column8.HeaderText = "水箱压力2";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 85;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PressureTank1";
            this.Column7.HeaderText = "水箱压力1";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 85;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TempOut";
            this.Column6.HeaderText = "出口温度";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TempIn2";
            this.Column5.HeaderText = "进口温度2";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 85;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TempIn1";
            this.Column4.HeaderText = "进口温度1";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wzw.PressurizationStationPro.Properties.Resources.Report;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PressureOut";
            this.Column3.HeaderText = "出口压力";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InsertTime";
            this.Column1.HeaderText = "时间日期";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 180;
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Image = global::wzw.PressurizationStationPro.Properties.Resources.Yellow;
            this.btn_Print.Location = new System.Drawing.Point(1046, 78);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(92, 32);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "打印记录";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Image = global::wzw.PressurizationStationPro.Properties.Resources.Green;
            this.btn_Export.Location = new System.Drawing.Point(948, 78);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(92, 32);
            this.btn_Export.TabIndex = 5;
            this.btn_Export.Text = "导出记录";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Image = global::wzw.PressurizationStationPro.Properties.Resources.Pink;
            this.btn_Query.Location = new System.Drawing.Point(850, 78);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(92, 32);
            this.btn_Query.TabIndex = 5;
            this.btn_Query.Text = "查询记录";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dtp_ReportTime
            // 
            this.dtp_ReportTime.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_ReportTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_ReportTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReportTime.Location = new System.Drawing.Point(313, 76);
            this.dtp_ReportTime.Name = "dtp_ReportTime";
            this.dtp_ReportTime.Size = new System.Drawing.Size(225, 31);
            this.dtp_ReportTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "日期时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "报表类型";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.AllowUserToResizeColumns = false;
            this.dgv_Data.AllowUserToResizeRows = false;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.ColumnHeadersHeight = 50;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.EnableHeadersVisualStyles = false;
            this.dgv_Data.Location = new System.Drawing.Point(21, 136);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Data.RowHeadersWidth = 55;
            this.dgv_Data.RowTemplate.Height = 35;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1098, 466);
            this.dgv_Data.TabIndex = 2;
            this.dgv_Data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Data_RowPostPaint);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PressureIn";
            this.Column2.HeaderText = "进口压力";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.MainPanel.Controls.Add(this.rdb_Avg);
            this.MainPanel.Controls.Add(this.rdb_Mini);
            this.MainPanel.Controls.Add(this.rdb_Max);
            this.MainPanel.Controls.Add(this.cmb_ReportType);
            this.MainPanel.Controls.Add(this.btn_Print);
            this.MainPanel.Controls.Add(this.btn_Export);
            this.MainPanel.Controls.Add(this.btn_Query);
            this.MainPanel.Controls.Add(this.dtp_ReportTime);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.dgv_Data);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1143, 619);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Exit);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 47);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // cmb_ReportType
            // 
            this.cmb_ReportType.FormattingEnabled = true;
            this.cmb_ReportType.Location = new System.Drawing.Point(103, 76);
            this.cmb_ReportType.Name = "cmb_ReportType";
            this.cmb_ReportType.Size = new System.Drawing.Size(106, 31);
            this.cmb_ReportType.TabIndex = 6;
            this.cmb_ReportType.SelectedIndexChanged += new System.EventHandler(this.cmb_ReportType_SelectedIndexChanged);
            // 
            // rdb_Max
            // 
            this.rdb_Max.AutoSize = true;
            this.rdb_Max.Checked = true;
            this.rdb_Max.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.rdb_Max.ForeColor = System.Drawing.Color.White;
            this.rdb_Max.Location = new System.Drawing.Point(544, 79);
            this.rdb_Max.Name = "rdb_Max";
            this.rdb_Max.Size = new System.Drawing.Size(96, 32);
            this.rdb_Max.TabIndex = 7;
            this.rdb_Max.TabStop = true;
            this.rdb_Max.Text = "最大值";
            this.rdb_Max.UseVisualStyleBackColor = true;
            // 
            // rdb_Mini
            // 
            this.rdb_Mini.AutoSize = true;
            this.rdb_Mini.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.rdb_Mini.ForeColor = System.Drawing.Color.White;
            this.rdb_Mini.Location = new System.Drawing.Point(646, 79);
            this.rdb_Mini.Name = "rdb_Mini";
            this.rdb_Mini.Size = new System.Drawing.Size(96, 32);
            this.rdb_Mini.TabIndex = 7;
            this.rdb_Mini.Text = "最小值";
            this.rdb_Mini.UseVisualStyleBackColor = true;
            // 
            // rdb_Avg
            // 
            this.rdb_Avg.AutoSize = true;
            this.rdb_Avg.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.rdb_Avg.ForeColor = System.Drawing.Color.White;
            this.rdb_Avg.Location = new System.Drawing.Point(748, 78);
            this.rdb_Avg.Name = "rdb_Avg";
            this.rdb_Avg.Size = new System.Drawing.Size(96, 32);
            this.rdb_Avg.TabIndex = 7;
            this.rdb_Avg.Text = "平均值";
            this.rdb_Avg.UseVisualStyleBackColor = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 621);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReport";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据报表";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DateTimePicker dtp_ReportTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_ReportType;
        private System.Windows.Forms.RadioButton rdb_Max;
        private System.Windows.Forms.RadioButton rdb_Mini;
        private System.Windows.Forms.RadioButton rdb_Avg;
    }
}