using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IIssueHistoriesDTO : IDTO
    {
        int IssueHistoryId { get; set; }
        int IssueId { get; set; }
        string Comments { get; set; }
        int ModifiedBy { get; set; }
        System.DateTime ModifiedOn { get; set; }
        Nullable<int> AssignedTo { get; set; }
        int Status { get; set; }

    }
}
