using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.DataConvertLib;

namespace wzw.PressurizationStationPro
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            this.cmb_ReportType.Items.Add("小时报表");
            this.cmb_ReportType.Items.Add("日报表");
            this.cmb_ReportType.SelectedIndex = 0;

            //初始化条件
            InitialColumnList();
        }

        //小时报表：每分钟之间的数据  12:00  12:00-12:01 ... 12:59-13:00  60个时间段  条件：Max Mini Avg
        //日报表：24条记录  每个小时之间的数据  Max(字段)

        //时间 条件

        private List<string> maxCondition = new List<string>();
        private List<string> minCondition = new List<string>();
        private List<string> avgCondition = new List<string>();

        private HistoryDataService historyService = new HistoryDataService();

        private void InitialColumnList()
        {
            List<string> columnList = new List<string>();
            columnList.Add("PressureIn");
            columnList.Add("PressureOut");
            columnList.Add("TempIn1");
            columnList.Add("TempIn2");
            columnList.Add("TempOut");
            columnList.Add("PressureTank1");
            columnList.Add("PressureTank2");
            columnList.Add("LevelTank1");
            columnList.Add("LevelTank2");
            columnList.Add("PressureTankOut");
            foreach(var item in columnList)
            {
                maxCondition.Add($"Max({item})");
                minCondition.Add($"Min({item})");
                avgCondition.Add($"Avg({item})");
            }

        }

        private void cmb_ReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cmb_ReportType.SelectedIndex)
            {
                case 0:
                    this.dtp_ReportTime.CustomFormat = "yyyy-MM-dd HH:00:00";
                    break;
                case 1:
                    this.dtp_ReportTime.CustomFormat = "yyyy-MM-dd";
                    break;
                default:
                    this.dtp_ReportTime.CustomFormat = "yyyy-MM-dd HH:00:00";
                    break;
            }

        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            //时间段
            List<string> startList = new List<string>();
            List<string> endList = new List<string>();

            //2026-05-19 14:00:00
            DateTime dateTime = Convert.ToDateTime(this.dtp_ReportTime.Text);

            switch (this.cmb_ReportType.SelectedIndex)
            {
                //小时报表 按每分钟
                case 0:
                    for(int i = 0; i < 60; i++)
                    {
                        startList.Add(dateTime.AddMinutes(i).ToString("yyyy-MM-dd HH:mm:ss"));
                        endList.Add(dateTime.AddMinutes(i+1).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    break;
                //日报表 按每小时
                case 1:
                    for(int i = 0; i < 24; i++)
                    {
                        startList.Add(dateTime.AddHours(i).ToString("yyyy-MM-dd HH:mm:ss"));
                        endList.Add(dateTime.AddHours(i + 1).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    break;
                default:
                    break;
            }

            //条件
            List<string> conditionList = this.rdb_Max.Checked ? maxCondition : (this.rdb_Mini.Checked ? minCondition : avgCondition) ;
            Task.Run(() =>
            {
                Task<OperateResult<DataTable>>[] taskList = new Task<OperateResult<DataTable>>[startList.Count];

                for(int i = 0; i < taskList.Length; i++)
                {
                    taskList[i] = Task.Factory.StartNew((index) =>
                    {
                        return historyService.GetReportDataByCondition(startList[(int)index], endList[(int)index], conditionList,index.ToString());
                    },i);
                }
                Task<OperateResult<DataTable>[]> task = Task.WhenAll(taskList);
                //至少读到了一条数据
                if (task.Result.Length > 0 && task.Result.First().IsSuccess)
                {
                    //希望得到一个DataTable
                    DataTable dataTable = GetAllDataTable(task.Result);
                    //再把这个DataTable显示到dgv中
                    if(dataTable != null)
                    {
                        UpdateDataTable(dataTable, startList);
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            new FrmMsgNoAck("查询数据表为空!", "数据查询").ShowDialog();
                        }));
                    }
                }
                else
                {
                    new FrmMsgNoAck("此时间段未查询到数据!", "数据查询").ShowDialog();
                }

            });
        }

        private void UpdateDataTable(DataTable dataTable, List<string> startList)
        {
            //操作datagridview加个判断变成更加通用的方法
            if (this.dgv_Data.InvokeRequired)
            {
                this.dgv_Data.Invoke(new Action<DataTable, List<string>>(UpdateDataTable),dataTable,startList);
            }
            else
            {
                this.dgv_Data.Rows.Clear();
                for(int i = 0;i< dataTable.Rows.Count;i++)
                {
                    int rowIndex = this.dgv_Data.Rows.Add();
                    this.dgv_Data.Rows[rowIndex].Cells[0].Value = startList[i];

                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        if (dataTable.Rows[i][j] is DBNull || dataTable.Rows[i][j] == DBNull.Value)
                        {
                            this.dgv_Data.Rows[rowIndex].Cells[j + 1].Value = "---";
                        }
                        else
                        {
                            this.dgv_Data.Rows[rowIndex].Cells[j + 1].Value = dataTable.Rows[i][j];
                        }
                    }
                }
            }
        }

        private DataTable GetAllDataTable(OperateResult<DataTable>[] dataResult)
        {
            //获取所有成功的DataTable集合
            List<DataTable> dataTables = new List<DataTable>();

            foreach(var item in dataResult)
            {
                if (item.IsSuccess)
                {
                    dataTables.Add(item.Content);
                }
            }

            if(dataTables.Count > 0)
            {
                //排序
                dataTables = dataTables.OrderBy(c => Convert.ToInt32(c.TableName)).ToList();
                //再把这些DataTable合并成一个
                //复制已有的表的结构
                DataTable resultTable=dataTables.First().Clone();

                object[] rowData = new object[resultTable.Columns.Count];
                for(int i = 0; i < dataTables.Count; i++)
                {
                    for(int j = 0; j < dataTables[i].Rows.Count; j++)
                    {
                        dataTables[i].Rows[j].ItemArray.CopyTo(rowData, 0);
                        resultTable.Rows.Add(rowData);
                    }
                }
                return resultTable;
            }
            else
            {
                return null;
            }
        }

        private void dgv_Data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(this.dgv_Data, e);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //标题
            saveFileDialog.Title = "请选择文件";
            saveFileDialog.Filter = "EXcel文件(*.xlsx)|*.xlsx|CSV文件(*.csv)|*.csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "数据报表_" + "_" + this.cmb_ReportType.Text + Convert.ToDateTime(this.dtp_ReportTime.Text).ToString("yyyyMMddHHmmss");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MiniExcel.SaveAs(saveFileDialog.FileName, GetHistoryDataFromDgv());
                    Process.Start(saveFileDialog.FileName);//创建文件后打开文件
                }
                catch (Exception ex)
                {
                    new FrmMsgNoAck("导出失败：" + ex.Message, "数据导出").ShowDialog();
                }

            }
        }

        private List<HistoryData> GetHistoryDataFromDgv()
        {
            if(this.dgv_Data.Rows.Count > 0)
            {
                List<HistoryData> historyDatas = new List<HistoryData>();
                foreach(DataGridViewRow item in this.dgv_Data.Rows)
                {
                    historyDatas.Add(new HistoryData()
                    {
                        InsertTime = Convert.ToDateTime(item.Cells[0].Value),
                        PressureIn = item.Cells[1].Value.ToString(),
                        PressureOut = item.Cells[2].Value.ToString(),
                        TempIn1 = item.Cells[3].Value.ToString(),
                        TempIn2 = item.Cells[4].Value.ToString(),
                        TempOut = item.Cells[5].Value.ToString(),
                        PressureTank1 = item.Cells[6].Value.ToString(),
                        PressureTank2 = item.Cells[7].Value.ToString(),
                        LevelTank1 = item.Cells[8].Value.ToString(),
                        LevelTank2 = item.Cells[9].Value.ToString(),
                        PressureTankOut = item.Cells[10].Value.ToString(),
                    });
                }
                return historyDatas;
            }
            else
            {
                return new List<HistoryData>();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Print_DataGridView(this.dgv_Data);
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
