using System;
using System.ComponentModel;

namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Defines a contract for base DTO,
    /// Author : Nagarro 
    /// </summary>
    public interface IDTO : ICloneable, INotifyPropertyChanged, INotifyPropertyChanging
    {
        /// <summary>
        /// gets or sets the state of the object.
        /// </summary>
        /// <value>The state of the object.</value>        
        ObjectStateType ObjectState { get; set; }

        /// <summary>
        /// gets the unique ID.
        /// </summary>
        /// <value>The unique ID.</value>        
        Guid? UniqueID { get; }

        /// <summary>
        /// gets the type of the DTO.
        /// </summary>
        /// <value>The type of the DTO.</value>        
        DTOType DTOType { get; }

    }
}
