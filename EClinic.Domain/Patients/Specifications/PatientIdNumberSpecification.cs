using Abp.Specifications;
using EClinic.Domain;
using System;
using System.Linq.Expressions;

namespace EClinic.Domain.Patients
{
    public class PatientIdNumberSpecification : Specification<PatientProfile>
    {
        public PatientIdNumberSpecification(string idNumber)
        {
            IdNumber = idNumber;
        }

        public string IdNumber { get; }

        public override Expression<Func<PatientProfile, bool>> ToExpression()
        {
            return (patient) => (patient.IdNumber == IdNumber);
        }
    }
}