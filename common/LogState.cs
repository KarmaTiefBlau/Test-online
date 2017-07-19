using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{


    public enum LogState
    {
        /// <summary>
        /// 用户不存在
        /// </summary>
        None,
        /// <summary>
        /// 学生用户登陆成功
        /// </summary>
        stuSuccess,
        /// <summary>
        /// 管理员登陆成功
        /// </summary>
        adminSuccess,
        /// <summary>
        /// 老师登陆成功
        /// </summary>
        teacherSuccess,
        /// <summary>
        /// 密码错误
        /// </summary>
        PwdErr
    }
}
