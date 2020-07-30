using EClinic.Enums;
using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class User : DbEntity<User>, IAggregatableEntity
    {
        public string Username { get; set; }
        public string Mobile { get; set; }

        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }

        public bool IsDoctor { get; set; }
        public bool IsAccountManager { get; set; }

        public UserStatus Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastLoginTime { get; set; }
        public string LastLoginPeriod { get; set; }

        public bool IsActive { get; set; }
    }
}