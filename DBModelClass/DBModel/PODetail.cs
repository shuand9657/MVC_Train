//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModelClass.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PODetail
    {
        public int PODetailID { get; set; }
        public int POID { get; set; }
        public int PartsID { get; set; }
        public int Qty { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> OrderPrice { get; set; }
        public string Memo { get; set; }
    }
}
