using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class AccountSubscriptionPlan : DbEntity<User>
    {
        public string Type { get; set; }
        public string Value { get; set; }

        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("SubscriptionPlan")]
        public long SubscriptionPlanId { get; set; }
        public SystemSubscriptionPlan SubscriptionPlan { get; set; }
    }
}