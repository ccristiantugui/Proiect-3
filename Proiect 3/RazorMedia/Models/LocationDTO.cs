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

    public partial class LocationDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationDTO()
        {
            this.Media = new HashSet<MediaDTO>().ToList();
        }

        public int LocationID { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<MediaDTO> Media { get; set; }
    }
}
