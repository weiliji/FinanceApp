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
    
    public partial class Wf_DataSource
    {
        public int SourceId { get; set; }
        public string BaseName { get; set; }
        public string TableCode { get; set; }
        public Nullable<int> DataStatus { get; set; }
        public Nullable<int> RowId { get; set; }
        public string DalName { get; set; }
        public string AssName { get; set; }
        public string ViewUrl { get; set; }
        public string RefusalUrl { get; set; }
        public string SuccessUrl { get; set; }
        public string ConditionUrl { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<System.DateTime> ApplyTime { get; set; }
        public string ApplyTitle { get; set; }
        public string ApplyMemo { get; set; }
        public string ApplyInfo { get; set; }
    }
}
