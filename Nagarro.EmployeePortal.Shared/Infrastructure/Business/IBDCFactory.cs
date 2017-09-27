namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Defines a contract for BDC factory,
    /// Author : Nagarro
    /// </summary>
    public interface IBDCFactory
    {
        /// <summary>
        /// Creates the specified BDC type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        IBusinessDomainComponent Create(BDCType type, params object[] args);
    }
}
