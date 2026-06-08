using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzw.PressurizationStationPro
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class SysAdmin
    {
        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }
        public RoleName RoleName { get; set; }
    }
}
