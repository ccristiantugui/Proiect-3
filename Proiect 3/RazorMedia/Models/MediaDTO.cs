using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMedia.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    public partial class MediaDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaDTO()
        {
            this.People = new HashSet<PersonDTO>().ToList();
            this.CustomAttributes = new HashSet<CustomAttributesDTO>().ToList();
        }

        public int MediaID { get; set; }
        public string Path { get; set; }
        public MediaTypeDTO MediaType { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime ModifiedAt { get; set; }
        public int LocationLocationID { get; set; }
        public int EventEventID { get; set; }

        public virtual LocationDTO Location { get; set; }
        public virtual EventDTO Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PersonDTO> People { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<CustomAttributesDTO> CustomAttributes { get; set; }
    }
}

