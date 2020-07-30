using Abp.Domain.Entities.Auditing;
using EClinic.Domain.Lookups;
using EClinic.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class Account : FullAuditedEntity<long>
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public AccountStatus Status { get; set; }

        public bool IsAdminAccount { get; set; }

        [ForeignKey("Manager")]
        public long? ManageId { get; set; }
        public User Manager { get; set; }

        [ForeignKey("AccountType")]
        public long AccountTypeId { get; set; }
        public SystemAccountType AccountType { get; set; }

        [ForeignKey("AccountSubType")]
        public long AccountSubTypeId { get; set; }
        public SystemAccountSubType AccountSubType { get; set; }

        //[ForeignKey("City")]
        //public long CityId { get; set; }
        //public City City { get; set; }

        public ICollection<User> Users { get; set; }
    }
}