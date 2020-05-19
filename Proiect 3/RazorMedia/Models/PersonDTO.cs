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

    [KnownType(typeof(List<MediaDTO>))]
    [Serializable]
    public partial class PersonDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDTO()
        {
            this.Media = new HashSet<MediaDTO>().ToList();
        }

        public int PersonID { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<MediaDTO> Media { get; set; }
    }
}
