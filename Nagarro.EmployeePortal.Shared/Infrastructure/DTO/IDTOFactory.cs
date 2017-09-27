namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Defines a contract for DTO factory,
    /// Author : Nagarro     
    /// </summary>
    public interface IDTOFactory
    {
        /// <summary>
        /// Creates the specified DTO type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        IDTO Create(DTOType type, params object[] args);
    }
}
