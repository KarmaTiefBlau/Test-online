﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace BLL
{
    public class login
    {
        #region 核对用户信息
        /// <summary>
        /// 核对用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public LogState check_user_info(string stuNumber, string pwd,bool Type )
        {


            if (Type)//教师登录
            {
                DAL. teacher dal = new DAL.teacher();
                DataTable dt = dal.get_user_info(stuNumber.Trim());

                if (dt.Rows.Count == 0)
                {
                    return LogState.None;
                }

                DataRow dr = dt.Rows[0];

                if (dr[2].ToString().Trim() == pwd.Trim())
                {
                    return LogState.teacherSuccess;
                }
                else
                {

                    return LogState.PwdErr;
                }

            }
            else {
                DAL.Admin dal = new DAL.Admin();
                DataTable dt = dal.get_user_info(stuNumber.Trim());

                if (dt.Rows.Count == 0)
                {
                    return LogState.None;
                }

                DataRow dr = dt.Rows[0];

                if (dr[1].ToString().Trim() == pwd.Trim())
                {
                    return LogState.adminSuccess;
                }
                else
                {

                    return LogState.PwdErr;
                }

            }

     
        }
        #endregion


    }
}
