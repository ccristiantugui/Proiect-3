//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class Media
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Media()
        {
            this.People = new HashSet<Person>().ToList();
            this.CustomAttributes = new HashSet<CustomAttributes>().ToList();
        }

        [DataMember]
        public int MediaID { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public MediaType MediaType { get; set; }
        [DataMember]
        public System.DateTime CreatedAt { get; set; }
        [DataMember]
        public System.DateTime ModifiedAt { get; set; }
        [DataMember]
        public int LocationLocationID { get; set; }
        [DataMember]
        public int EventEventID { get; set; }

        [DataMember]
        public virtual Location Location { get; set; }
        [DataMember]
        public virtual Event Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<Person> People { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<CustomAttributes> CustomAttributes { get; set; }
    }
}