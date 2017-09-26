using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;
using Nagarro.EmployeePortal.EntityDataModel;
using Nagarro.EmployeePortal.EntityDataModel.EntityModel;

namespace Nagarro.EmployeePortal.Data
{
    public class IssuesDAC : DACBase, IIssuesDAC
    {
        public IssuesDAC() : base(DACType.IssuesDAC) { }

        public IIssuesDTO CreateIssue(IIssuesDTO issuesDTO)
        {
            IIssuesDTO createIssueRetval = null;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {

                    Issue issue = new Issue();
                    issuesDTO.IsActive = true;
                    EntityConverter.FillEntityFromDTO(issuesDTO, issue);
                    context.Issues.Add(issue);

                    issuesDTO.IssueHistoriesDTO.AssignedTo = 1;
                    issuesDTO.IssueHistoriesDTO.Comments = "new issue has been generated";
                    issuesDTO.IssueHistoriesDTO.ModifiedBy = 1;
                    issuesDTO.IssueHistoriesDTO.Status = 1;
                    issuesDTO.IssueHistoriesDTO.ModifiedOn = DateTime.Now;
                    issuesDTO.IssueHistoriesDTO.IssueId = issue.IssueId;

                    IssueHistory newissueHistory = new IssueHistory();
                    EntityConverter.FillEntityFromDTO(issuesDTO.IssueHistoriesDTO, newissueHistory);
                    context.IssueHistories.Add(newissueHistory);
                    context.SaveChanges();

                    createIssueRetval = issuesDTO;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return createIssueRetval;
        }

        bool IIssuesDAC.DeleteIssue(int issueId)
        {
            bool retVal = false;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    var deleteIssue = context.Issues.First(item => item.IssueId == issueId);
                    if (deleteIssue != null)
                    {
                        deleteIssue.IsActive = false;
                        context.SaveChanges();
                        retVal = true;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public IIssueHistoriesDTO UpdateIssueByAdmin(IIssueHistoriesDTO issueHistoriesDTO)
        {
            IIssueHistoriesDTO retVal = null;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    var updateIssueByAdmin = context.IssueHistories.First(item => issueHistoriesDTO.IssueId == item.IssueId);
                    if (updateIssueByAdmin != null)
                    {
                        issueHistoriesDTO.IssueHistoryId = updateIssueByAdmin.IssueHistoryId;
                        EntityConverter.FillEntityFromDTO(issueHistoriesDTO, updateIssueByAdmin);
                        context.SaveChanges();
                        retVal = issueHistoriesDTO;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public IIssuesDTO UpdateIssueByNonAdmin(IIssuesDTO issuesDTO)
        {
            IIssuesDTO retVal = null;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    var updateIssue = context.Issues.First(item => issuesDTO.IssueId == item.IssueId);
                    if (updateIssue != null)
                    {
                        EntityConverter.FillEntityFromDTO(issuesDTO, updateIssue);
                        context.SaveChanges();
                        retVal = issuesDTO;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public IList<IComplexIssueDTO> GetAllIssueByEmployeeId(int employeeid)
        {
            IList<IComplexIssueDTO> issueDTOList = null;
            IComplexIssueDTO issueDTO = null;

            try
            {
                using (EmployeePortalEntities portal = new EmployeePortalEntities())
                {
                    var issueList = portal.GetAllIssuesByEmployeeId(employeeid).ToList();
                    if (issueList.Count > 0)
                    {
                        issueDTOList = new List<IComplexIssueDTO>();
                        foreach (var issue in issueList)
                        {
                            issueDTO = (IComplexIssueDTO)DTOFactory.Instance.Create(DTOType.ComplexIssueDTO);
                            EntityConverter.FillDTOFromComplexObject(issue, issueDTO);
                            issueDTOList.Add(issueDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return issueDTOList;
        }


        public IIssuesDTO GetIssue(int issueId)
        {
            IIssuesDTO issueDTO = null;
            try
            {
                using (EmployeePortalEntities portal = new EmployeePortalEntities())
                {
                    var issue = portal.Issues.Include("Employee").Where(i => i.IssueId == issueId && i.IsActive);
                    if (issue != null)
                    {
                        issueDTO = (IIssuesDTO)DTOFactory.Instance.Create(DTOType.IssuesDTO);
                        EntityConverter.FillDTOFromEntity(issue, issueDTO); 
                    }

                   // issueDTO.PostedByName = issue.Employee.FirstName;
                    var issueHistoryList = portal.GetIssueHistoryByIssueId(issueId).ToList();
                    if(issueHistoryList.Count>0)
                    {
                        issueDTO.IssueHistories = new List<IComplexIssueHistoryDTO>();
                        IComplexIssueHistoryDTO issueHistoryDTO = null;

                        foreach (var issueHistory in issueHistoryList)
                        {
                            issueHistoryDTO = (IComplexIssueHistoryDTO)DTOFactory.Instance.Create(DTOType.IssueHistoriesDTO);
                            EntityConverter.FillDTOFromComplexObject(issueHistory, issueHistoryDTO);
                            issueDTO.IssueHistories.Add(issueHistoryDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }

            return issueDTO;

        }
        
        public IList<IComplexIssueDTO> GetAllActiveIssues()
        {
            IList<IComplexIssueDTO> issueDTOList = null;
            IComplexIssueDTO issueDTO = null;

            try
            {
                using (EmployeePortalEntities portal = new EmployeePortalEntities())
                {
                    var issueList = portal.GetAllIssuesByEmployeeId(null).ToList();
                    if (issueList.Count > 0)
                    {
                        issueDTOList = new List<IComplexIssueDTO>();
                        foreach (var issue in issueList)
                        {
                            issueDTO = (IComplexIssueDTO)DTOFactory.Instance.Create(DTOType.ComplexIssueDTO);
                            EntityConverter.FillDTOFromComplexObject(issue, issueDTO);
                            issueDTOList.Add(issueDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return issueDTOList;
        }

    }
}
