using EClinic.Enums;
using EClinic.Framework.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain
{
    public class MedicalVisitComplaintDetails : DbEntity<User>
    {
        [Range(1, 10)]
        public int? PainDegree { get; set; }

        [StringLength(500)]
        public string Place { get; set; }

        public int? Duration { get; set; }
        public string PainIncreasinFactors { get; set; }

        public DiseaseCause? DiseaseCause { get; set; }
    }
}