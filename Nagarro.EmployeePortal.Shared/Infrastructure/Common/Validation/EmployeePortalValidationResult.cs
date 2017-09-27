using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public class EmployeePortalValidationResult
    {
        public IList<EmployeePortalValidationFailure> Errors { get; private set; }

        public bool IsValid
        {
            get { return Errors == null || Errors.Count == 0; }
        }

        public EmployeePortalValidationResult(IList<EmployeePortalValidationFailure> failures)
        {
            Errors = failures;
        }

        public EmployeePortalValidationResult()
        {
            Errors = new List<EmployeePortalValidationFailure>();
        }
    }
}
