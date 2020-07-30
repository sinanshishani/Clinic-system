using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain.Lookups
{
    public class SystemAccountSubType : Lookup
    {
        [Required]
        [ForeignKey("AccountType")]
        public long AccountTypeId { get; set; }
        public SystemAccountType AccountType { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }
    }
}