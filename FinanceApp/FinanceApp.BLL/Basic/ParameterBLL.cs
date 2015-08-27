﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IParameterDAL.cs
// 文件功能描述：参数表dbo.Parameter数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 参数表dbo.Parameter数据交互接口。
    /// </summary>
    public class ParameterBLL : BaseBLL<Parameter>
    {
        public ParameterBLL(IBaseDAL<Parameter> currentDAL) : base(currentDAL) { }
    }
}
