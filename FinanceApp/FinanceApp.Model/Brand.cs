//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brand
    {
        public int BrandId { get; set; }
        public Nullable<int> ProducerId { get; set; }
        public string BrandName { get; set; }
        public string BrandFullName { get; set; }
        public string BrandInfo { get; set; }
        public Nullable<int> BrandStatus { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> LastModifyId { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    }
}