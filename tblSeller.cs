//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSeller
    {
        public tblSeller()
        {
            this.tblProducts = new HashSet<tblProduct>();
        }
    
        public int SellerId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual tblLocation tblLocation { get; set; }
        public virtual tblLogin tblLogin { get; set; }
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
