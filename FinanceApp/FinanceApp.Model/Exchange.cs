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
    
    public partial class Exchange
    {
        public int ExchangeId { get; set; }
        public string ExchangeName { get; set; }
        public string ExchangeCode { get; set; }
        public int ExchangeStatus { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> LastModifyId { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    }
}
