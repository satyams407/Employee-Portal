using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IComplexIssueDTO : IDTO
    {
        int IssueId { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int PostedBy { get; set; }
        int Priority { get; set; }
        Nullable<int> AssignedTo { get; set; }
        int status { get; set; }
        bool IsActive { get; set; }
        string PostedByName { get; set; }
        string AssignedToName { get; set; }
    }
}
