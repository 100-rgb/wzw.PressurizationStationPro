using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzw.PressurizationStationPro
{
    public class HistoryData
    {
        [ExcelColumnName("日期时间")]
        [ExcelFormat("yyyy-MM-dd HH:mm:ss")]
        [ExcelColumnWidth(30)]
        public DateTime InsertTime { get; set; }
        [ExcelColumnName("进口压力")]
        [ExcelColumnWidth(10)]
        public string PressureIn { get; set; }
        [ExcelColumnName("出口压力")]
        [ExcelColumnWidth(10)]
        public string PressureOut { get; set; }
        [ExcelColumnName("进口温度1")]
        [ExcelColumnWidth(10)]
        public string TempIn1 { get; set; }
        [ExcelColumnName("进口温度2")]
        [ExcelColumnWidth(10)]
        public string TempIn2 { get; set; }
        [ExcelColumnName("出口温度")]
        [ExcelColumnWidth(10)]
        public string TempOut { get; set; }
        [ExcelColumnName("水箱压力1")]
        [ExcelColumnWidth(10)]
        public string PressureTank1 { get; set; }
        [ExcelColumnName("水箱压力2")]
        [ExcelColumnWidth(10)]
        public string PressureTank2 { get; set; }
        [ExcelColumnName("水箱液位1")]
        [ExcelColumnWidth(10)]
        public string LevelTank1 { get; set; }
        [ExcelColumnName("水箱液位2")]
        [ExcelColumnWidth(10)]
        public string LevelTank2 { get; set; }
        [ExcelColumnName("水箱出口压力")]
        [ExcelColumnWidth(10)]
        public string PressureTankOut { get; set; }
    }
}
