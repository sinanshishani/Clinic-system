using System.ComponentModel;

namespace EClinic.Enums
{
    public enum ProcedureInsuranceStatus
    {
        [Description("NeedNoApproval")]
        NeedNoApproval = 1,

        [Description("NeedApproval")]
        NeedApproval = 2,

        [Description("NotCovered")]
        NotCovered = 3
    }
}