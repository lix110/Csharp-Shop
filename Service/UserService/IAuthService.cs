﻿using Mapper;
using MVC卓越项目.Controller.Auth.Param;
using Service.UserService.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
  public  interface IAuthService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginParam"></param>
        /// <returns></returns>
        Hashtable Login(LoginParam loginParam, string ip);
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
         bool Logout(string token);

        Hashtable Register(RegisterParam registerParam, string ip);


        int verify(string phone);
    }
}
