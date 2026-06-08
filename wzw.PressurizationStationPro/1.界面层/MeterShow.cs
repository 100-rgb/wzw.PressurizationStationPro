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
    public partial class MeterShow : UserControl
    {
        public MeterShow()
        {
            InitializeComponent();
        }

        //通过修改属性动态的修改控件名称
        private string paramName="出水管温度";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量名称")]
        public string ParamName
        {
            get { return paramName; }
            set 
            {
                paramName= value;
                this.lbl_ParamName.Text = paramName;
            }
        }


        private string unit = "℃";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量单位")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_ParamValue.Text = paramValue.ToString("f2") + "" + unit;
            }
        }

        private float paramValue=0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量数值")]
        public float ParamValue
        {
            get { return paramValue; }
            set 
            { 
                //变化更新
                if (paramValue!=value)
                {
                    paramValue = value;
                    this.lbl_ParamValue.Text = paramValue.ToString("f2") + "" + unit;
                }             
            }
        }

        private float meterMax=100.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取仪表盘量程最大值")]
        public float MeterMax
        {
            get { return meterMax; }
            set 
            { 
                meterMax = value;
                this.meter_Param.MaxValue = meterMax;
            }
        }

        private float meterMin = 0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取仪表盘量程最小值")]
        public float MeterMin
        {
            get { return meterMin; }
            set
            {
                meterMin = value;
                this.meter_Param.MinValue = meterMin;
            }
        }




    }
}
