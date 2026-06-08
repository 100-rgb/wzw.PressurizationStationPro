using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using xbd.DataConvertLib;

namespace wzw.PressurizationStationPro
{
    public class HistoryDataService
    {
        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="historyData"></param>
        /// <returns></returns>
        public bool AddHistoryData(HistoryData historyData)
        {
            string sql = "Insert into HistoryData(InsertTime,PressureIn,PressureOut,TempIn1,TempIn2,TempOut,PressureTank1,PressureTank2,LevelTank1,LevelTank2,PressureTankOut) " +
                "Values (@InsertTime,@PressureIn,@PressureOut,@TempIn1,@TempIn2,@TempOut,@PressureTank1,@PressureTank2,@LevelTank1,@LevelTank2,@PressureTankOut)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@InsertTime",historyData.InsertTime.ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@PressureIn",historyData.PressureIn),
                new SQLiteParameter("@PressureOut",historyData.PressureOut),
                new SQLiteParameter("@TempIn1",historyData.TempIn1),
                new SQLiteParameter("@TempIn2",historyData.TempIn2),
                new SQLiteParameter("@TempOut",historyData.TempOut),
                new SQLiteParameter("@PressureTank1",historyData.PressureTank1),
                new SQLiteParameter("@PressureTank2",historyData.PressureTank2),
                new SQLiteParameter("@LevelTank1",historyData.LevelTank1),
                new SQLiteParameter("@LevelTank2",historyData.LevelTank2),
                new SQLiteParameter("@PressureTankOut",historyData.PressureTankOut)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, parameters) == 1;
        }
        /// <summary>
        /// 根据开始时间和结束时间进行查询
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public OperateResult<List<HistoryData>> GetHistoryDataByTime(DateTime start, DateTime end)
        {
            string sql = "Select InsertTime,PressureIn,PressureOut,TempIn1,TempIn2,TempOut,PressureTank1,PressureTank2,LevelTank1,LevelTank2,PressureTankOut" +
                " from HistoryData where InsertTime between @Start and @End";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Start",start),
                new SQLiteParameter("@End",end),
            };
            try
            {
                SQLiteDataReader dataReader = SQLiteHelper.ExecuteReader(sql, parameters);
                List<HistoryData> historyDatas = new List<HistoryData>();
                while(dataReader.Read())
                {
                    historyDatas.Add(new HistoryData()
                    {
                        InsertTime = Convert.ToDateTime(dataReader["InsertTime"]),
                        PressureIn = dataReader["PressureIn"].ToString(),
                        PressureOut = dataReader["PressureOut"].ToString(),
                        TempIn1 = dataReader["TempIn1"].ToString(),
                        TempIn2 = dataReader["TempIn2"].ToString(),
                        TempOut = dataReader["TempOut"].ToString(),
                        PressureTank1 = dataReader["PressureTank1"].ToString(),
                        PressureTank2 = dataReader["PressureTank2"].ToString(),
                        LevelTank1 = dataReader["LevelTank1"].ToString(),
                        LevelTank2 = dataReader["LevelTank2"].ToString(),
                        PressureTankOut = dataReader["PressureTankOut"].ToString(),
                    });
                }
                dataReader.Close();
                return OperateResult.CreateSuccessResult(historyDatas);
            }
            catch (Exception ex)
            {
                return OperateResult.CreateFailResult<List<HistoryData>>(ex.Message);
            }
        }

        /// <summary>
        /// 单个区间查询的方法
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="condition">查询内容和条件</param>
        /// <param name="datatableName">数据表名称</param>
        /// <returns></returns>
        public OperateResult<DataTable> GetReportDataByCondition(string start, string end,List<string> condition,string datatableName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Select ");
            stringBuilder.Append(string.Join(",", condition));
            stringBuilder.Append(" from HistoryData where InsertTime between @Start and @End");

            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Start",start),
                new SQLiteParameter("@End",end),
            };

            try
            {
                DataSet dataSet = SQLiteHelper.GetDataSet(stringBuilder.ToString(), parameters, datatableName);

                if (dataSet.Tables.Count > 0)
                {
                    return OperateResult.CreateSuccessResult(dataSet.Tables[0]);
                }
                else
                {
                    return OperateResult.CreateFailResult<DataTable>("DataTable数量为0");
                }
            }
            catch (Exception ex)
            {
                return OperateResult.CreateFailResult<DataTable>(ex.Message);
            }
        }


    }
}
