using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Nagarro.EmployeePortal.Shared
{
    public static class AppConstants
    {
        public struct ConfigurationKeys
        {
            #region "Properties"
            /// <summary>
            /// Constant representing the assemblies' output bin folder name.
            /// </summary>
            public static readonly string OutputBinFolderName = ConfigurationManager.AppSettings["OutputBinFolderName"];

            #endregion
        }
    }
}
