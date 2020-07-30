using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain.Lookups
{
    public class SystemSubscriptionDuration : Lookup
    {
        [Required]
        [ForeignKey("SubscriptionPlan")]
        public long SubscriptionPlanId { get; set; }
        public SystemSubscriptionPlan SubscriptionPlan { get; set; }

        public int DurationInDays { get; set; }
    }
}