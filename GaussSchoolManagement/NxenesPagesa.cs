namespace GaussSchoolManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NxenesPagesa")]
    public partial class NxenesPagesa
    {
        [Key]
        public int NxenesPageseId { get; set; }

        public int? NxenesId { get; set; }

        public int? PageseId { get; set; }

        public virtual Nxene Nxene { get; set; }

        public virtual Pagesa Pagesa { get; set; }
    }
}
