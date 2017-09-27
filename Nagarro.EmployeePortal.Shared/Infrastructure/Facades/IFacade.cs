namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Defines a contract for base facade,
    /// Author : Nagarro
    /// </summary>
    public interface IFacade
    {
        /// <summary>
        /// Gets the type of the facade.
        /// </summary>
        /// <value>The type of the facade.</value>
        FacadeType FacadeType { get; }
    }
}
