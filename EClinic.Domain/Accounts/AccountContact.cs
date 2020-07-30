using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class AccountContact : DbEntity<User>
    {
        public string Type { get; set; }
        public string Value { get; set; }

        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }
    }
}