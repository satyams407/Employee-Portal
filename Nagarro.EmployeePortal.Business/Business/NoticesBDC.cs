using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;


namespace Nagarro.EmployeePortal.Business
{
    public class NoticesBDC : BDCBase, INoticesBDC
    {
        public NoticesBDC()
            : base(BDCType.NoticesBDC)
        {

        }

        //public OperationResult<INoticesDTO> SampleMethod(INoticesDTO noticesDTO)
        //{
        //    OperationResult<INoticesDTO> retVal = null;

        //    INoticesDAC noticesDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
        //    noticesDTO = noticesDAC.SampleMethod(noticesDTO);
        //    retVal = OperationResult<INoticesDTO>.CreateSuccessResult(noticesDTO);
        //    return retVal;
        //}


        public OperationResult<INoticesDTO> CreateNotice(INoticesDTO noticesDTO)
        {
            OperationResult<INoticesDTO> createNoticeReturnValue = null;
            try
            {
                EmployeePortalValidationResult validationResult = Validator<NoticeValidator, INoticesDTO>.Validate(noticesDTO, ValidationConstants.NoticeMessages.TitleMandatory);
                if (!validationResult.IsValid)
                {
                    createNoticeReturnValue = OperationResult<INoticesDTO>.CreateFailureResult(validationResult);
                }

                else
                {
                    INoticesDAC noticeDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
                    INoticesDTO returnedNoticeDTO = noticeDAC.CreateNotice(noticesDTO);
                    if (returnedNoticeDTO != null)
                    {
                        createNoticeReturnValue = OperationResult<INoticesDTO>.CreateSuccessResult(returnedNoticeDTO, "Notice created successfully");
                    }
                    else
                    {
                        createNoticeReturnValue = OperationResult<INoticesDTO>.CreateFailureResult("Insertion failed!");
                    }
                }
            }
            catch (DACException dacEx)
            {
                createNoticeReturnValue = OperationResult<INoticesDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                createNoticeReturnValue = OperationResult<INoticesDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return createNoticeReturnValue;
        }

        public OperationResult<IList<INoticesDTO>> GetCurrentNotices()
        {
            OperationResult<IList<INoticesDTO>> getCurrentNoticeReturnValue = null;
            try
            {
                INoticesDAC noticeDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
                IList<INoticesDTO> returnedNoticeDTO = noticeDAC.GetCurrentNotices();
                if (returnedNoticeDTO != null)
                {
                    getCurrentNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateSuccessResult(returnedNoticeDTO, " successfully");
                }
                else
                {
                    getCurrentNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateFailureResult("failed!");
                }
            }
            catch (DACException dacEx)
            {
                getCurrentNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                getCurrentNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }

            return getCurrentNoticeReturnValue;
        }

        public OperationResult<IList<INoticesDTO>> GetActiveNotices()
        {
            OperationResult<IList<INoticesDTO>> getActiveNoticeReturnValue = null;
            try
            {
                INoticesDAC noticeDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
                IList<INoticesDTO> returnedNoticeDTO = noticeDAC.GetActiveNotices();
                if (returnedNoticeDTO != null)
                {
                    getActiveNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateSuccessResult(returnedNoticeDTO, " successfully");
                }
                else
                {
                    getActiveNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateFailureResult("failed!");
                }
            }
            catch (DACException dacEx)
            {
                getActiveNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                getActiveNoticeReturnValue = OperationResult<IList<INoticesDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }

            return getActiveNoticeReturnValue;
        }

        public OperationResult<INoticesDTO> UpdateNotice(INoticesDTO noticeDTO)
        {
            OperationResult<INoticesDTO> updateNoticeReturnValue = null;
            try
            {
                INoticesDAC noticeDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
                INoticesDTO returnedNoticeDTO = noticeDAC.UpdateNotice(noticeDTO);
                if (returnedNoticeDTO != null)
                {
                    updateNoticeReturnValue = OperationResult<INoticesDTO>.CreateSuccessResult(returnedNoticeDTO, "Notice created successfully");
                }
                else
                {
                    updateNoticeReturnValue = OperationResult<INoticesDTO>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                updateNoticeReturnValue = OperationResult<INoticesDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                updateNoticeReturnValue = OperationResult<INoticesDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return updateNoticeReturnValue;
        }

        public OperationResult<bool> DeleteNotice(int noticeId)
        {
            OperationResult<bool> deleteNoticeReturnValue = null;
            try
            {
                INoticesDAC noticeDAC = (INoticesDAC)DACFactory.Instance.Create(DACType.NoticesDAC);
                bool returnedNoticeDTO = noticeDAC.DeleteNotice(noticeId);
                if (returnedNoticeDTO == true)
                {
                    deleteNoticeReturnValue = OperationResult<bool>.CreateSuccessResult(returnedNoticeDTO, "Notice created successfully");
                }
                else
                {
                    deleteNoticeReturnValue = OperationResult<bool>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                deleteNoticeReturnValue = OperationResult<bool>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                deleteNoticeReturnValue = OperationResult<bool>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return deleteNoticeReturnValue;
        }
    }
}
