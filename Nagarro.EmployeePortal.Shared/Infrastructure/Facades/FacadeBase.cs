using System.Diagnostics.CodeAnalysis;

namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Represents the abstract base class for all facades,
    /// Author : Nagarro     
    /// </summary>
    public abstract class FacadeBase : IFacade
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeBase"/> class.
        /// </summary>
        /// <param name="facadeType">Type of the facade.</param>
        protected FacadeBase(FacadeType facadeType)
        {
            FacadeType = facadeType;
        }
        #endregion

        #region IFacade Members

        /// <summary>
        /// Gets the type of the facade.
        /// </summary>
        /// <value>The type of the facade.</value>
        public FacadeType FacadeType { get; private set; }

        #endregion

        #region Factory Access

        /// <summary>
        /// Gets the factory for the facade.
        /// </summary>
        /// <value>The facade.</value>
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected FacadeFactory Facade
        {
            get
            {
                return FacadeFactory.Instance;
            }
        }

        /// <summary>
        /// Gets the factory for the business domain component.
        /// </summary>
        /// <value>The business domain component.</value>
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected BDCFactory BusinessDomainComponent
        {
            get
            {
                return BDCFactory.Instance;
            }
        }

        /// <summary>
        /// Gets the factory for the data transfer object.
        /// </summary>
        /// <value>The data transfer object.</value>
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected DTOFactory DataTransferObject
        {
            get
            {
                return DTOFactory.Instance;
            }
        }

        #endregion

    }
}
