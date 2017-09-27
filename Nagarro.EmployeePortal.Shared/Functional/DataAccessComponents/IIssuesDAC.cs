using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IIssuesDAC : IDataAccessComponent
    {
        IIssuesDTO CreateIssue(IIssuesDTO issuesDTO);

        bool DeleteIssue(int issueId);

        IIssueHistoriesDTO UpdateIssueByAdmin(IIssueHistoriesDTO issueshistoriesDTO);

        IIssuesDTO UpdateIssueByNonAdmin(IIssuesDTO issuesDTO);

        IList<IComplexIssueDTO> GetAllIssueByEmployeeId(int employeeid);

        IIssuesDTO GetIssue(int issueId);

        IList<IComplexIssueDTO> GetAllActiveIssues();
    }
}
