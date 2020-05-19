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

    public partial class EventDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventDTO()
        {
            this.Media = new HashSet<MediaDTO>().ToList();
        }

        public int EventID { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<MediaDTO> Media { get; set; }
    }
}