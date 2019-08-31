using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GaussSchoolManagement.DataModel
{
    public partial class Nxene
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nxene()
        {
            NxenesKurses = new HashSet<NxenesKurse>();
            NxenesPagesas = new HashSet<NxenesPagesa>();
        }

        [Key]
        public int NxenesId { get; set; }

        public int? ShkollaId { get; set; }

        [StringLength(50)]
        public string Klasa { get; set; }

        public int? PrindId { get; set; }

        public int? PersonId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxenesKurse> NxenesKurses { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Prinder Prinder { get; set; }

        public virtual Shkolla Shkolla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxenesPagesa> NxenesPagesas { get; set; }
    }
}
