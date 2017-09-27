using System;
using System.Diagnostics.CodeAnalysis;


namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Represents the abstract base class for all Business Domain Components,
    /// Author : Nagarro     
    /// </summary>
    public abstract class BDCBase : IBusinessDomainComponent
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="BDCBase"/> class.
        /// </summary>
        /// <param name="bdcType">Type of the BDC.</param>
        /// <param name="securityToken">The security token.</param>
        protected BDCBase(BDCType bdcType)
        {
            BDCType = bdcType;
        }

        #endregion

        #region IBusinessDomainComponent Members

        /// <summary>
        /// Gets the type of the BDC.
        /// </summary>
        /// <value>The type of the BDC.</value>
        public BDCType BDCType { get; private set; }

        #endregion

        #region Factory Access

        /// <summary>
        /// Gets the factory for business domain component.
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
        /// Gets the factory for data transfer object.
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

        /// <summary>
        /// Gets the data access component.
        /// </summary>
        /// <value>The data access component.</value>
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected DACFactory DataAccessComponent
        {
            get
            {
                return DACFactory.Instance;
            }
        }

        #endregion
    }
}
