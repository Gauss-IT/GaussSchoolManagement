using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{

    [Table("Kurse")]
    public partial class Kurse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurse()
        {
            InstruktoreKurses = new HashSet<InstruktoreKurse>();
            NxenesKurses = new HashSet<NxenesKurse>();
            Sherbimets = new HashSet<Sherbimet>();
        }

        [Key]
        public int KursId { get; set; }

        [StringLength(50)]
        public string ShifraKursit { get; set; }

        [StringLength(100)]
        public string EmriKursit { get; set; }

        [StringLength(400)]
        public string Pershkrimi { get; set; }

        [StringLength(50)]
        public string Niveli { get; set; }

        [StringLength(50)]
        public string VitiShkollor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstruktoreKurse> InstruktoreKurses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxenesKurse> NxenesKurses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sherbimet> Sherbimets { get; set; }
    }
}
