using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
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
