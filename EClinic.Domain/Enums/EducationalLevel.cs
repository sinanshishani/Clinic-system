using System.ComponentModel;

namespace EClinic.Domain.Enums
{
    public enum EducationalLevel
    {
        [Description("None")]
        None = 1,

        [Description("HighSchool")]
        HighSchool = 2,

        [Description("BachelorDegree")]
        BachelorDegree = 3,

        [Description("Postgraduate")]
        Postgraduate = 4
    }
}