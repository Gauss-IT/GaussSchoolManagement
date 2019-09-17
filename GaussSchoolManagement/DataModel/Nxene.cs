using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Shkolla")]
        public int? ShkollaId { get; set; }

        [StringLength(50)]
        public string Klasa { get; set; }

        [ForeignKey("Prinder")]
        public int? PrindId { get; set; }

        [ForeignKey("Persona")]
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
