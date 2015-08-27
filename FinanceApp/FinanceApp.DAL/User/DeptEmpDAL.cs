﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IDeptEmpDAL.cs
// 文件功能描述：员工部门表dbo.DeptEmp数据交互接口。
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
    /// 员工部门表dbo.DeptEmp数据交互接口。
    /// </summary>
    public class DeptEmpDAL : BaseDAL<DeptEmp>,IDeptEmpDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(DeptEmp entity)
        {
            throw new NotImplementedException();
        }
    }
}