﻿using System;

namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Contains/Represents/Provides Entity mapping attribute,
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class EntityMappingAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityMappingAttribute"/> class.
        /// </summary>
        /// <param name="mappedEntityTypeFullName">Full name of the mapped entity type.</param>
        /// <param name="mappingType">Type of the mapping.</param>
        public EntityMappingAttribute(string mappedEntityTypeFullName, MappingType mappingType)
        {
            // private set value
            this.MappedEntityTypeFullName = mappedEntityTypeFullName;
            this.MappingType = mappingType;
        }

        #endregion

        #region EntityMappingAttribute Members

        /// <summary>
        /// Gets or sets the full name of the mapped entity type.
        /// </summary>
        /// <value>The full name of the mapped entity type.</value>
        public string MappedEntityTypeFullName { get; private set; }
        /// <summary>
        /// Gets or sets the type of the mapping.
        /// </summary>
        /// <value>The type of the mapping.</value>
        public MappingType MappingType { get; private set; }

        #endregion

    }
}
