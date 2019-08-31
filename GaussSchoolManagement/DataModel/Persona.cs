using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Instruktores = new HashSet<Instruktore>();
            Nxenes = new HashSet<Nxene>();
            Prinders = new HashSet<Prinder>();
        }

        [Key]
        public int PersonId { get; set; }

        [StringLength(50)]
        public string Emri { get; set; }

        [StringLength(50)]
        public string Mbiemri { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataLindjes { get; set; }

        [StringLength(150)]
        public string EmailAdresa { get; set; }

        [StringLength(50)]
        public string Telefoni { get; set; }

        [StringLength(400)]
        public string Adresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruktore> Instruktores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nxene> Nxenes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prinder> Prinders { get; set; }
    }
}
