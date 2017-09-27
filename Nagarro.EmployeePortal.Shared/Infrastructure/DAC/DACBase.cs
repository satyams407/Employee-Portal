namespace Nagarro.EmployeePortal.Shared
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;

    public abstract class DACBase : IDataAccessComponent
    {

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="DACBase"/> class.
        /// </summary>
        /// <param name="dacType">Type of the dac.</param>
        protected DACBase(DACType dacType)
        {
            this.Type = dacType;
        }
        #endregion

        #region IDataAccessComponent Members

        /// <summary>
        /// private gets the type of the DAC.
        /// </summary>
        /// <value>The type of the DAC.</value>
        public DACType Type { get; private set; }

        #endregion

        #region Factory Access

        /// <summary>
        /// Gets the factory of data access component.
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

        /// <summary>
        /// Gets the factory of data transfer object.
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
