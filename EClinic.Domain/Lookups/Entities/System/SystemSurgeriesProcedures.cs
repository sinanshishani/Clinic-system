using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain.Lookups
{
    public class SystemSurgeriesProcedures : Lookup
    {
        [Required]
        [ForeignKey("SurgeryProcedure")]
        public long SurgeryProcedureId { get; set; }
        public SystemSurgeryProcedure SurgeryProcedure { get; set; }

        [Required]
        [ForeignKey("Surgery")]
        public long SurgeryId { get; set; }
        public SystemSurgery Surgery { get; set; }
    }
}