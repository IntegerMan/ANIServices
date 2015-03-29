//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MattEland.Ani.AniServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Node
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Node()
        {
            this.Transits = new HashSet<Transit>();
            this.UserNodes = new HashSet<UserNode>();
        }
    
        public int N_ID { get; set; }
        public int N_NodeTypeID { get; set; }
        public Nullable<int> N_LastLocationID { get; set; }
        public System.DateTime N_CreatedTimeUTC { get; set; }
        public Nullable<System.DateTime> N_LastActivityTimeUTC { get; set; }
    
        public virtual GPSLocation GPSLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transit> Transits { get; set; }
        public virtual NodeType NodeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNode> UserNodes { get; set; }
    }
}
