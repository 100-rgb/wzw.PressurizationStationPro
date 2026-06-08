using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzw.PressurizationStationPro
{
    /// <summary>
    /// 业务层：核心方法
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 获取所有用户对象
        /// </summary>
        /// <returns></returns>
        public List<SysAdmin> QuerySysAdmins()
        {
            string sql = "Select LoginId,LoginName,LoginPwd,RoleName from SysAdmin";
            SQLiteDataReader dataReader = SQLiteHelper.ExecuteReader(sql);
            List<SysAdmin> sysAdmins = new List<SysAdmin>();
            while(dataReader.Read())
            {
                sysAdmins.Add(new SysAdmin()
                {
                    LoginId = Convert.ToInt32(dataReader["LoginId"]),
                    LoginName = dataReader["LoginName"].ToString(),
                    LoginPwd = dataReader["LoginPwd"].ToString(),
                    RoleName = (RoleName)Enum.Parse(typeof(RoleName), dataReader["RoleName"].ToString())
                });
            }
            //关闭dataReader
            dataReader.Close();
            return sysAdmins;
        }
        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin sysAdmin)
        {
            //【1】封装SQL语句
            string sql = "Select LoginId,RoleName from SysAdmin where LoginName =@LoginName and LoginPwd=@LoginPwd";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",sysAdmin.LoginName),
                new SQLiteParameter("@LoginPwd",sysAdmin.LoginPwd),
            };
            //【2】提交查询
            SQLiteDataReader dataReader = SQLiteHelper.ExecuteReader(sql, parameters);
            //【3】判断是否成功
            if (dataReader.Read())
            {
                sysAdmin.LoginId = Convert.ToInt32(dataReader["LoginId"]);
                sysAdmin.RoleName = (RoleName)Enum.Parse(typeof(RoleName), dataReader["RoleName"].ToString());
            }
            else
            {
                //赋值为空对象
                sysAdmin = null;
            }
            //关闭dataReader
            dataReader.Close();
            return sysAdmin;
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public bool AddSysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Insert into SysAdmin(LoginName,LoginPwd,RoleName)");
            stringBuilder.Append("values(@LoginName,@LoginPwd,@RoleName)");
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",sysAdmin.LoginName),
                new SQLiteParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SQLiteParameter("@RoleName",sysAdmin.RoleName.ToString()),
            };
            return SQLiteHelper.ExecuteNonQuery(stringBuilder.ToString(), parameters)==1;
        }
        /// <summary>
        /// 修改用户，根据LoginId修改
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public bool ModifySysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Update SysAdmin set LoginName=@LoginName,LoginPwd=@LoginPwd,RoleName=@RoleName ");
            stringBuilder.Append("where LoginId=@LoginId");
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",sysAdmin.LoginName),
                new SQLiteParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SQLiteParameter("@RoleName",sysAdmin.RoleName.ToString()),
                new SQLiteParameter("@LoginId",sysAdmin.LoginId),
            };
            return SQLiteHelper.ExecuteNonQuery(stringBuilder.ToString(), parameters)==1;
        }
        /// <summary>
        /// 删除用户，根据LoginId删除
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public bool DeleteSysAdmin(int loginId)
        {
            string sql = "Delete from SysAdmin where LoginId = @LoginId";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginId",loginId),
            };
            return SQLiteHelper.ExecuteNonQuery(sql, parameters)==1;
        }
    }
}
