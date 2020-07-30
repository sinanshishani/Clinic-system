using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain.Lookups
{
    public abstract class AccountLookup : Lookup
    {
        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }
    }
}