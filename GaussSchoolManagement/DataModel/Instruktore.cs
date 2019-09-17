using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("Instruktore")]
    public partial class Instruktore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instruktore()
        {
            InstruktoreKurses = new HashSet<InstruktoreKurse>();
        }

        [Key]
        public int InstruktorId { get; set; }

        [ForeignKey("Persona")]
        public int? PersonId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstruktoreKurse> InstruktoreKurses { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
