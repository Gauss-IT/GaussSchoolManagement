using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("Pagesa")]
    public partial class Pagesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagesa()
        {
            NxenesPagesas = new HashSet<NxenesPagesa>();
            InstruktorePagesas = new HashSet<InstruktorePagesa>();
        }

        [Key]
        public int PageseId { get; set; }

        [StringLength(50)]
        public string FormaPageses { get; set; }

        [StringLength(50)]
        public string PershkrimiPageses { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }

        public decimal? ShumaPaguar { get; set; }

        public decimal? Zbritje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxenesPagesa> NxenesPagesas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstruktorePagesa> InstruktorePagesas { get; set; }

    }
}
