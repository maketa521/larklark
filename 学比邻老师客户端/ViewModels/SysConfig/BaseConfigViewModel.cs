﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学比邻老师客户端.ViewModels.@base;

namespace 学比邻老师客户端.ViewModels.SysConfig
{
    public class BaseConfigViewModel : BaseWindowVM
    {
        #region 公共属性
        /// <summary>
        /// 窗口标题
        /// </summary>
        public override string DisplayName => "乐比邻老师端-基本设置";
        #endregion
    }
}
