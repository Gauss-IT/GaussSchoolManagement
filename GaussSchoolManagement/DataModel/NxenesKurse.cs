using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaussSchoolManagement.DataModel
{
    [Table("NxenesKurse")]
    public partial class NxenesKurse
    {
        [Key]
        public int NxenesKursId { get; set; }

        public int? KursId { get; set; }

        public int? NxenesId { get; set; }

        public virtual Kurse Kurse { get; set; }

        public virtual Nxene Nxene { get; set; }
    }
}
