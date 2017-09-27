using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IIssuesBDC : IBusinessDomainComponent
    {
        OperationResult<IIssuesDTO> CreateIssue(IIssuesDTO issuesDTO);

        OperationResult<bool> DeleteIssue(int issueId);

        OperationResult<IIssueHistoriesDTO> UpdateIssueByAdmin(IIssueHistoriesDTO issueHistoriesDTO);

        OperationResult<IIssuesDTO> UpdateIssueByNonAdmin(IIssuesDTO issuesDTO);


        OperationResult<IList<IComplexIssueDTO>> GetAllIssueByEmployeeId(int employeeid);

        OperationResult<IIssuesDTO> GetIssue(int issueId);

        OperationResult<IList<IComplexIssueDTO>> GetAllActiveIssues();
    }
}
