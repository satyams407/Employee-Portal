using System;
using System.Configuration;
using System.IO;
using System.Reflection;


namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Represents the factory for Data Transfer Objects,
    /// Author : Nagarro 
    /// </summary>    
    public class DTOFactory : FactoryBase, IDTOFactory
    {
        //The variable is declared to be volatile to ensure that assignment to the 
        //_instance variable completes before the instance variable can be accessed.
        private static volatile DTOFactory _instance;
        private static object _syncObject = new object();

        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="DTOFactory"/> class.
        /// </summary>
        private DTOFactory()
        {
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Instance is private static property to return the same Instance of the class everytime.
        /// Note: Double - checked serialized initialization of Class pattern is used.
        /// </summary>       
        public static DTOFactory Instance
        {
            get
            {
                #region Single Instance Logic
                //Check for null before acquiring the lock.
                if (_instance == null)
                {
                    //Use a _syncObject to lock on, to avoid deadlocks among multiple threads.
                    lock (_syncObject)
                    {
                        //Again check if _instance has been initialized, 
                        //since some other thread may have acquired the lock first and constructed the object.
                        if (_instance == null)
                        {
                            _instance = new DTOFactory();
                        }
                    }
                }
                #endregion

                return _instance;
            }
        }

        #endregion

        #region IDTOFactory Members

        /// <summary>
        /// Creates the specified DTO type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public IDTO Create(DTOType type, params object[] args)
        {
            try
            {
                // get type info
                QualifiedTypeNameAttribute QualifiedNameAttr = EnumAttributeUtility<DTOType, QualifiedTypeNameAttribute>.GetEnumAttribute(type.ToString());

                // Initialize instance
                IDTO instance = null;

                // create instance
                instance = (IDTO)this.CreateObjectInstance(QualifiedNameAttr.AssemblyFileName, QualifiedNameAttr.QualifiedTypeName, args);

                // return
                return instance;
            }
            catch (FactoryException fex)
            {
                throw fex;
            }
        }

        #endregion
    }
}
