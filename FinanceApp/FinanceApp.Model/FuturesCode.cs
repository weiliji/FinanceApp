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
    
    public partial class FuturesCode
    {
        public int FuturesCodeId { get; set; }
        public Nullable<int> ExchageId { get; set; }
        public Nullable<decimal> CodeSize { get; set; }
        public Nullable<System.DateTime> FirstTradeDate { get; set; }
        public Nullable<System.DateTime> LastTradeDate { get; set; }
        public Nullable<int> MUId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> AssetId { get; set; }
        public Nullable<int> FuturesCodeStatus { get; set; }
        public string TradeCode { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> LastModifyId { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    }
}
