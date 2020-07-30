using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class InsuranceCompany : DbEntity<User>
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string FaxNumber { get; set; }
        public string PostalBox { get; set; }
        public string Note { get; set; }
        [Required]
        public double VisitPrice { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime ContractExpirationDate { get; set; }
        [Required]
        public string ContractStatus { get; set; }
        public string ContractFileUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }
    }
}