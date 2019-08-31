using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("Prinder")]
    public partial class Prinder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prinder()
        {
            Nxenes = new HashSet<Nxene>();
        }

        [Key]
        public int PrindId { get; set; }

        public int? PersonId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nxene> Nxenes { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
