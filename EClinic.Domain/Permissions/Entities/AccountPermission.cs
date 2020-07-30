using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class AccountPermission : DbEntity<User>
    {
        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("Permission")]
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}