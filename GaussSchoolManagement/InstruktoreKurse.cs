namespace GaussSchoolManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstruktoreKurse")]
    public partial class InstruktoreKurse
    {
        [Key]
        public int InstruktorKursId { get; set; }

        public int? InstruktorId { get; set; }

        public int? KursId { get; set; }

        public virtual Instruktore Instruktore { get; set; }

        public virtual Kurse Kurse { get; set; }
    }
}
