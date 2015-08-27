﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IMenuDAL.cs
// 文件功能描述：功能菜单表dbo.Menu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Data.Entity;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 功能菜单表dbo.Menu数据交互接口。
    /// </summary>
    public class MenuDAL : BaseDAL<Menu>,IMenuDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}