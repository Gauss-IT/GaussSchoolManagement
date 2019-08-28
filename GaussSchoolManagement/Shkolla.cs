namespace GaussSchoolManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shkolla")]
    public partial class Shkolla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shkolla()
        {
            Nxenes = new HashSet<Nxene>();
        }

        public int ShkollaId { get; set; }

        [StringLength(50)]
        public string ShkollaEmri { get; set; }

        [StringLength(50)]
        public string ShkollaTipi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nxene> Nxenes { get; set; }
    }
}
