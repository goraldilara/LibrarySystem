//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTHORS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTHORS()
        {
            this.BOOK = new HashSet<BOOK>();
        }
    
        public int Author_ID { get; set; }
        public string Author_Name { get; set; }
        public string Author_Lastname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK> BOOK { get; set; }
    }
}
