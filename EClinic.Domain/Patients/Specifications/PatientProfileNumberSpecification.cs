using Abp.Specifications;
using EClinic.Domain;
using System;
using System.Linq.Expressions;

namespace EClinic.Domain.Patients
{
    public class PatientProfileNumberSpecification : Specification<PatientProfile>
    {
        public PatientProfileNumberSpecification(string profileNumber)
        {
            ProfileNumber = profileNumber;
        }

        public string ProfileNumber { get; }

        public override Expression<Func<PatientProfile, bool>> ToExpression()
        {
            return (patient) => (patient.ProfileNumber == ProfileNumber);
        }
    }
}