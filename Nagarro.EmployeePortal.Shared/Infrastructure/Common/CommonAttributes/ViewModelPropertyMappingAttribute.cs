namespace Nagarro.EmployeePortal.Shared
{
    using System;

    /// <summary>
    /// Contains/Represents/Provides ViewModel property mapping attribute,
    /// Author		: Nagarro
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public sealed class ViewModelPropertyMappingAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelPropertyMappingAttribute"/> class.
        /// </summary>
        /// <param name="mappingDirection">The mapping direction.</param>
        /// <param name="mappedViewModelPropertyName">Name of the mapped entity property.</param>
        public ViewModelPropertyMappingAttribute(MappingDirectionType mappingDirection, string mappedViewModelPropertyName)
            : this(mappingDirection)
        {
            // private set value
            MappedViewModelPropertyName = mappedViewModelPropertyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelPropertyMappingAttribute"/> class.
        /// </summary>
        /// <param name="mappingDirection">The mapping direction.</param>
        internal ViewModelPropertyMappingAttribute(MappingDirectionType mappingDirection)
        {
            // private set value
            MappingDirection = mappingDirection;
        }

        #endregion

        #region ViewModelPropertyMappingAttribute Members

        /// <summary>
        /// Gets the name of the mapped entity property.
        /// </summary>
        /// <value>The name of the mapped entity property.</value>
        public string MappedViewModelPropertyName { get; private set; }

        /// <summary>
        /// Gets the mapping direction.
        /// </summary>
        /// <value>The mapping direction.</value>
        public MappingDirectionType MappingDirection { get; private set; }

        #endregion
    }
}
