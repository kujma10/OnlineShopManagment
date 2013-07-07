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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
            this.Balances = new HashSet<Balance>();
        }
    
        public int ID { get; set; }
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool Disabled { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Balance> Balances { get; set; }
    }
}
