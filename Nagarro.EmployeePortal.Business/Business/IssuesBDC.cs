using Nagarro.EmployeePortal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Business
{
    public class IssuesBDC : BDCBase, IIssuesBDC
    {
        public IssuesBDC() : base(BDCType.IssuesBDC) { }

        public OperationResult<IIssuesDTO> CreateIssue(IIssuesDTO issuesDTO)
        {
            OperationResult<IIssuesDTO> createIssueReturnValue = null;
            try
            {
                IIssuesDAC issueDAC = (IIssuesDAC)DACFactory.Instance.Create(DACType.IssuesDAC);
                IIssuesDTO returnedIssueDTO = issueDAC.CreateIssue(issuesDTO);
                if (returnedIssueDTO != null)
                {
                    createIssueReturnValue = OperationResult<IIssuesDTO>.CreateSuccessResult(returnedIssueDTO, "issue created successfully");
                }
                else
                {
                    createIssueReturnValue = OperationResult<IIssuesDTO>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                createIssueReturnValue = OperationResult<IIssuesDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                createIssueReturnValue = OperationResult<IIssuesDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return createIssueReturnValue;
        }

        public OperationResult<bool> DeleteIssue(int issueId)
        {
            OperationResult<bool> deleteIssueReturnValue = null;
            try
            {
                IIssuesDAC issueDAC = (IIssuesDAC)DACFactory.Instance.Create(DACType.IssuesDAC);
                bool returnedIssueDTO = issueDAC.DeleteIssue(issueId);
                if (returnedIssueDTO == true)
                {
                    deleteIssueReturnValue = OperationResult<bool>.CreateSuccessResult(returnedIssueDTO, "issue updated successfully");
                }
                else
                {
                    deleteIssueReturnValue = OperationResult<bool>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                deleteIssueReturnValue = OperationResult<bool>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                deleteIssueReturnValue = OperationResult<bool>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return deleteIssueReturnValue;
        }

        public OperationResult<IIssueHistoriesDTO> UpdateIssueByAdmin(IIssueHistoriesDTO issueHistoriesDTO)
        {
            OperationResult<IIssueHistoriesDTO> updateIssueReturnValue = null;
            try
            {
                IIssuesDAC issueDAC = (IIssuesDAC)DACFactory.Instance.Create(DACType.IssuesDAC);
                IIssueHistoriesDTO returnedIssueDTO = issueDAC.UpdateIssueByAdmin(issueHistoriesDTO);
                if (returnedIssueDTO != null)
                {
                    updateIssueReturnValue = OperationResult<IIssueHistoriesDTO>.CreateSuccessResult(returnedIssueDTO, "issue updated successfully by admin");
                }
                else
                {
                    updateIssueReturnValue = OperationResult<IIssueHistoriesDTO>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                updateIssueReturnValue = OperationResult<IIssueHistoriesDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                updateIssueReturnValue = OperationResult<IIssueHistoriesDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return updateIssueReturnValue;
        }

        public OperationResult<IIssuesDTO> UpdateIssueByNonAdmin(IIssuesDTO issuesDTO)
        {
            OperationResult<IIssuesDTO> updateIssueReturnValue = null;
            try
            {
                IIssuesDAC issueDAC = (IIssuesDAC)DACFactory.Instance.Create(DACType.IssuesDAC);
                IIssuesDTO returnedIssueDTO = issueDAC.UpdateIssueByNonAdmin(issuesDTO);
                if (returnedIssueDTO != null)
                {
                    updateIssueReturnValue = OperationResult<IIssuesDTO>.CreateSuccessResult(returnedIssueDTO, "issue updated successfullyby non admin");
                }
                else
                {
                    updateIssueReturnValue = OperationResult<IIssuesDTO>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                updateIssueReturnValue = OperationResult<IIssuesDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                updateIssueReturnValue = OperationResult<IIssuesDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return updateIssueReturnValue;
        }

        public OperationResult<IList<IComplexIssueDTO>> GetAllIssueByEmployeeId(int employeeid) { return null; }

        public OperationResult<IIssuesDTO> GetIssue(int issueId)
        { return null; }

        public OperationResult<IList<IComplexIssueDTO>> GetAllActiveIssues() { return null; }
    }
}
