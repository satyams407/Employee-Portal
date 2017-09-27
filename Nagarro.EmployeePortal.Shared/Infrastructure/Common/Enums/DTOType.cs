namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Data Transfer Objects
    /// </summary>
    public enum DTOType
    {


        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,


        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.SampleDTO")]
        SampleDTO = 1,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.NoticesDTO")]
        NoticesDTO = 2,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.UsersDTO")]
        UsersDTO = 3,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.IssuesDTO")]
        IssuesDTO = 4,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.DepartmentDTO")]
        DepartmentDTO = 5,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.EmployeesDTO")]
        EmployeeDTO = 6,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.IssueHistoriesDTO")]
        IssueHistoriesDTO = 7,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.ComplexIssueDTO")]
        ComplexIssueDTO = 8,

        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.ComplexIssueHistory")]
        ComplexIssueHistoryDTO = 9

    }
}
