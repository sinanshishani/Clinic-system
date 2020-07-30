using System.ComponentModel;

namespace EClinic.Domain.Enums
{
    public enum SocialStatus
    {
        [Description("Single")]
        Single = 1,

        [Description("Married")]
        Married = 2,

        [Description("Divorced")]
        Divorced = 3,

        [Description("Widowed")]
        Widowed = 4
    }
}