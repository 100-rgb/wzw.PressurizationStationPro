using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.DataConvertLib;
using xbd.s7netplus;
using DataType = xbd.s7netplus.DataType;

namespace wzw.PressurizationStationPro
{
    /// <summary>
    /// 通信类
    /// </summary>
    public class S7NetLib
    {
        /// <summary>
        /// 私有字段
        /// </summary>
        private Plc siemens;

        /// <summary>
        /// 共有属性
        /// </summary>
        public CpuType CpuType { get; set; }
        public string IPAddress { get; set; }
        public short Rack { get; set; }
        public short Slot { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public S7NetLib()
        {
            
        }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="cpuType"></param>
        /// <param name="ip"></param>
        /// <param name="rack"></param>
        /// <param name="slot"></param>
        public S7NetLib(CpuType cpuType,String ip,short rack,short slot)
        {
            this.CpuType = cpuType;
            this.IPAddress = ip;
            this.Rack = rack;
            this.Slot = slot;
        }
        /// <summary>
        /// 锁标志位
        /// </summary>
        private static object objLock = new object();

        /// <summary>
        /// 建立PLC连接
        /// </summary>
        /// <returns></returns>
        public OperateResult Connect()
        {
            try
            {
                //如果已经连接，先断开再重新连接
                if (this.siemens != null && this.siemens.IsConnected)
                {
                    this.siemens.Close();
                }
                siemens = new Plc(this.CpuType, this.IPAddress, this.Rack, this.Slot);
                siemens.Open();
                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex) 
            {
                return OperateResult.CreateFailResult(ex.Message);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisConnect()
        {
            if (this.siemens != null && this.siemens.IsConnected)
            {
                this.siemens.Close();
            }
        }

        /// <summary>
        /// 读字节数组
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public OperateResult<byte[]> ReadByteArray(DataType dataType,int db,int start,int count)
        {
            if(this.siemens!=null && this.siemens.IsConnected)
            {
                try
                {
                    lock (objLock) 
                    {
                        return OperateResult.CreateSuccessResult(siemens.ReadBytes(dataType, db, start, count));
                    }                   
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<byte[]>("读取失败："+ex.Message);
                }               
            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>("请检查PLC连接是否正确");
            }
        }

        /// <summary>
        /// 读单个变量
        /// </summary>
        /// <param name="varAddress"></param>
        /// <returns></returns>
        public OperateResult<object> ReadVariable(string varAddress)
        {
            if (this.siemens != null && this.siemens.IsConnected)
            {
                try
                {
                    lock (objLock)
                    {
                        return OperateResult.CreateSuccessResult(siemens.Read(varAddress));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<object>("读取失败：" + ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<object>("请检查PLC连接是否正确");
            }
        }

        /// <summary>
        /// 读取类对象
        /// </summary>
        /// <param name="db"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public OperateResult<T> ReadClass<T>(int db,int start) where T : class
        {
            if (this.siemens != null && this.siemens.IsConnected)
            {
                try
                {
                    lock (objLock)
                    {
                        return OperateResult.CreateSuccessResult(siemens.ReadClass<T>(db,start));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<T>("读取失败：" + ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<T>("请检查PLC连接是否正确");
            }
        }

        /// <summary>
        /// 变量写入
        /// </summary>
        /// <param name="varAddress"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public OperateResult WriteVariable(string varAddress,object value)
        {
            if (this.siemens != null && this.siemens.IsConnected)
            {
                try
                {
                    lock (objLock)
                    {
                        siemens.Write(varAddress,value);
                        return OperateResult.CreateSuccessResult();
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult("写入失败：" + ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult("请检查PLC连接是否正确");
            }
        }

    }
}
