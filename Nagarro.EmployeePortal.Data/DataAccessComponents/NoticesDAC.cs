using Nagarro.EmployeePortal.EntityDataModel;
using Nagarro.EmployeePortal.EntityDataModel.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Data
{
   public class NoticesDAC : DACBase, INoticesDAC
    {

        public NoticesDAC() : base(DACType.NoticesDAC) { }

        public IList<INoticesDTO> GetCurrentNotices()
        {
            List<INoticesDTO> currentNotices = new List<INoticesDTO>();
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    foreach (var notice in context.Notices.Where(i=> ((i.StartDate<=DateTime.Now) && (i.ExpirationDate>=DateTime.Now) ) && i.IsActive==true))
                    {
                        INoticesDTO noticeDTO = (INoticesDTO)DTOFactory.Instance.Create(DTOType.NoticesDTO);
                        EntityConverter.FillDTOFromEntity(notice, noticeDTO);
                        currentNotices.Add(noticeDTO);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return currentNotices;
        }

        public IList<INoticesDTO> GetActiveNotices()
        {
            List<INoticesDTO> activeNotices = new List<INoticesDTO>();
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    //check whether we need to check here whether notice is active or not
                    foreach (var notice in context.Notices.Where(item => item.IsActive==true))
                    {
                        INoticesDTO noticeDTO = (INoticesDTO)DTOFactory.Instance.Create(DTOType.NoticesDTO);
                        EntityConverter.FillDTOFromEntity(notice, noticeDTO);
                        activeNotices.Add(noticeDTO);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return activeNotices;
        }

        public bool DeleteNotice(int noticeId)
        {
            bool retVal = false;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    var deleteNotice = context.Notices.First(item => item.NoticeId == noticeId);
                    if(deleteNotice!=null)
                    {
                        deleteNotice.IsActive = false;
                        context.SaveChanges();
                        retVal = true;
                    }

                }
            }
            catch(Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public INoticesDTO UpdateNotice(INoticesDTO noticesDTO)
        {
            INoticesDTO retVal = null;
            try
            {
                using(EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    var updateNotice = context.Notices.First(item => noticesDTO.NoticeId == item.NoticeId);
                    if(updateNotice!=null)
                    {
                        EntityConverter.FillEntityFromDTO(noticesDTO, updateNotice);
                        context.SaveChanges();
                        retVal = noticesDTO;
                    }
                }
            }
            catch(Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public INoticesDTO CreateNotice(INoticesDTO noticesDTO)
        {
            INoticesDTO createNoticeRetval = null;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {
                    noticesDTO.IsActive = true;
                    Notice notice = new Notice();
                    EntityConverter.FillEntityFromDTO(noticesDTO, notice);
                    context.Notices.Add(notice);
                    context.SaveChanges();
                    notice.NoticeId=noticesDTO.NoticeId;
                    createNoticeRetval = noticesDTO;
                    
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return createNoticeRetval;
        }
    }
}
