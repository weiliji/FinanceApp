﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBrandDAL.cs
// 文件功能描述：品牌dbo.Brand数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 品牌dbo.Brand数据交互接口。
    /// </summary>
    public class BrandBLL : BaseBLL<Brand>
    {
        public BrandBLL(IBaseDAL<Brand> currentDAL) : base(currentDAL) { }
    }
}
