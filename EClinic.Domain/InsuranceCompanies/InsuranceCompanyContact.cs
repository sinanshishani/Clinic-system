using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class InsuranceCompanyContact : DbEntity<User>
    {
        [Required]
        public string Name { get; set; }

        public string DepartmentName { get; set; }
        [Required]
        public string ExtensionNumber { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        [ForeignKey("InsuranceCompany")]
        public long InsuranceCompanyId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
    }
}