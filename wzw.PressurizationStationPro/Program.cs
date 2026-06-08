using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.DataConvertLib;

namespace wzw.PressurizationStationPro
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connStr = "Data Source=" + Application.StartupPath + "\\DataBase\\PressurizationStationProDataBase;Pooling=true;FailIfMissing=false";

            new SQLiteService().SetConnectStr(connStr);
            Application.Run(new FrmMain());
           
        }
        /// <summary>
        /// 锁屏时间的滴答次数
        /// </summary>
        public static int TickCount { get; set; }

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static SysAdmin CurrentUser;

    }
}
