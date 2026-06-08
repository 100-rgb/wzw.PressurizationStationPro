using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzw.PressurizationStationPro
{
    public class SQLiteService
    {
        /// <summary>
        /// 设置连接字符串
        /// </summary>
        /// <param name="connStr"></param>
        public void SetConnectStr(string connStr)
        {
            SQLiteHelper.ConnString = connStr;
        }

    }
}
