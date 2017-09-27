using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IIssuesDTO : IDTO
    {
        int IssueId { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int PostedBy { get; set; }
        int Priority { get; set; }
        bool IsActive { get; set; }
        string PostedByName { get; set; }
        IList<IComplexIssueHistoryDTO> IssueHistories { get; set; }
        IIssueHistoriesDTO IssueHistoriesDTO { get; set; }
    }
}
