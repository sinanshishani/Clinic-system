using EClinic.AppDomain.Lookups.Models.AccountType;
using EClinic.AppDomain.Lookups.Models.Bank.Dto;
using System.Collections.Generic;

namespace EClinic.Core.Lookups
{
    public class AccountSubTypeDto : LookupDto
    {
        public AccountTypeDto AccountType { get; set; }
        public string Notes { get; set; }
    }
}