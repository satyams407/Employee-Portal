namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Data Access Component Type
    /// </summary>
    public enum DACType
    {

        [QualifiedTypeName("Nagarro.EmployeePortal.Data.dll", "Nagarro.EmployeePortal.Data.SampleDAC")]
        SampleDAC = 1,

        [QualifiedTypeName("Nagarro.EmployeePortal.Data.dll", "Nagarro.EmployeePortal.Data.NoticesDAC")]
        NoticesDAC = 2,

        [QualifiedTypeName("Nagarro.EmployeePortal.Data.dll", "Nagarro.EmployeePortal.Data.UsersDAC")]
        UsersDAC = 3,

        [QualifiedTypeName("Nagarro.EmployeePortal.Data.dll", "Nagarro.EmployeePortal.Data.IssuesDAC")]
        IssuesDAC = 4,

        [QualifiedTypeName("Nagarro.EmployeePortal.Data.dll", "Nagarro.EmployeePortal.Data.DepartmentDAC")]
        DepartmentDAC = 5,

      
    }
}
