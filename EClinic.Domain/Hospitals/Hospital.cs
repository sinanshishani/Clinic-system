using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class Hospital : DbEntity<User>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string RegionalId { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string WebsiteUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public Account Account { get; set; }
    }
}