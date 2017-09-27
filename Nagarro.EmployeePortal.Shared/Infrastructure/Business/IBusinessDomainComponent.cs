namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Defines a contract for base business domain component,
    /// Author : Nagarro
    /// </summary>
    public interface IBusinessDomainComponent
    {
        /// <summary>
        /// Gets the type of the BDC.
        /// </summary>
        /// <value>The type of the BDC.</value>
        BDCType BDCType { get; }
    }
}
