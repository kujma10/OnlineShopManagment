//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopManagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Balance
    {
        public int ID { get; set; }
        public int StorageID { get; set; }
        public int CatID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual Storage Storage { get; set; }
    }
}
