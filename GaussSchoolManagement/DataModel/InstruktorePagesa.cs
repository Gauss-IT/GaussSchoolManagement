using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("InstruktorePagesa")]
    public partial class InstruktorePagesa
    {
        [Key]
        public int InstruktorePagesaId { get; set; }

        [ForeignKey("Instruktore")]
        public int? InstruktorId { get; set; }

        [ForeignKey("Pagesa")]
        public int? PageseId { get; set; }

        public virtual Instruktore Instruktore { get; set; }

        public virtual Pagesa Pagesa { get; set; }
    }
}
