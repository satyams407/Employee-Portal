using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.BusinessFacades
{
    public class IssuesFacade : FacadeBase, IIssuesFacade
    {
         public IssuesFacade() : base(FacadeType.IssuesFacade) { }

         public OperationResult<IIssuesDTO> CreateIssue(IIssuesDTO issuesDTO)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.CreateIssue(issuesDTO);
         }

         public OperationResult<bool> DeleteIssue(int issueId)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.DeleteIssue(issueId);
         }

         public OperationResult<IIssueHistoriesDTO> UpdateIssueByAdmin(IIssueHistoriesDTO issueHistoriesDTO)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.UpdateIssueByAdmin(issueHistoriesDTO);
         }

         public OperationResult<IIssuesDTO> UpdateIssueByNonAdmin(IIssuesDTO issuesDTO)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.UpdateIssueByNonAdmin(issuesDTO);
         }

         public OperationResult<IList<IComplexIssueDTO>> GetAllIssueByEmployeeId(int employeeId)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.GetAllIssueByEmployeeId(employeeId);
         }

         public OperationResult<IIssuesDTO> GetIssue(int issueId)
         {
             IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
             return issueBDC.GetIssue(issueId);
         }

         public OperationResult<IList<IComplexIssueDTO>> GetAllActiveIssues()
        {
            IIssuesBDC issueBDC = (IIssuesBDC)BDCFactory.Instance.Create(BDCType.IssuesBDC);
            return issueBDC.GetAllActiveIssues();
        }
    }
}
