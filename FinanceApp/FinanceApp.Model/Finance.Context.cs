﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Financing_ConnectStr : DbContext
    {
        public Financing_ConnectStr()
            : base("name=Financing_ConnectStr")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fin_PledgeApply> Fin_PledgeApply { get; set; }
        public virtual DbSet<Fin_PledgeApplyCashDetail> Fin_PledgeApplyCashDetail { get; set; }
        public virtual DbSet<Fin_PledgeApplyStockDetail> Fin_PledgeApplyStockDetail { get; set; }
        public virtual DbSet<Fin_RepoApply> Fin_RepoApply { get; set; }
        public virtual DbSet<Fin_RepoApplyDetail> Fin_RepoApplyDetail { get; set; }
        public virtual DbSet<Fin_StockNo> Fin_StockNo { get; set; }
    }
}