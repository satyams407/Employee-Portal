namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Business Domain Component Type
    /// </summary>
    public enum BDCType
    { 
        [QualifiedTypeName("Nagarro.EmployeePortal.Business.dll", "Nagarro.EmployeePortal.Business.SampleBDC")]
        SampleBDC = 0,

        [QualifiedTypeName("Nagarro.EmployeePortal.Business.dll", "Nagarro.EmployeePortal.Business.NoticesBDC")]
        NoticesBDC = 1,

        [QualifiedTypeName("Nagarro.EmployeePortal.Business.dll", "Nagarro.EmployeePortal.Business.UsersBDC")]
        UsersBDC = 2,

        [QualifiedTypeName("Nagarro.EmployeePortal.Business.dll", "Nagarro.EmployeePortal.Business.IssuesBDC")]
        IssuesBDC = 3,

        [QualifiedTypeName("Nagarro.EmployeePortal.Business.dll", "Nagarro.EmployeePortal.Business.DepartmentBDC")]
        DepartmentBDC = 4,
    }
}
