namespace GaussSchoolManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sherbimet")]
    public partial class Sherbimet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sherbimet()
        {
            Pagesas = new HashSet<Pagesa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SherbimiId { get; set; }

        public decimal? Cmimi { get; set; }

        [StringLength(400)]
        public string Pershkrimi { get; set; }

        public int? KursId { get; set; }

        public virtual Kurse Kurse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagesa> Pagesas { get; set; }
    }
}
