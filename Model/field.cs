//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCenter.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class field
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public field()
        {
            this.bookingInfoes = new HashSet<bookingInfo>();
        }
    
        public int id { get; set; }
        public Nullable<int> idType { get; set; }
        public string name { get; set; }
        public string condition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bookingInfo> bookingInfoes { get; set; }
        public virtual fieldtype fieldtype { get; set; }
    }
}
