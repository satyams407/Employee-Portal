using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.BusinessFacades
{
    public class NoticesFacade : FacadeBase, INoticesFacade
    {
        public NoticesFacade() : base(FacadeType.NoticesFacade) { }

        public OperationResult<INoticesDTO> CreateNotice(INoticesDTO noticesDTO)
        {
            INoticesBDC noticeBDC = (INoticesBDC)BDCFactory.Instance.Create(BDCType.NoticesBDC);
            return noticeBDC.CreateNotice(noticesDTO);
        }

        public OperationResult<IList<INoticesDTO>> GetCurrentNotices()
        {
            INoticesBDC noticeBDC = (INoticesBDC)BDCFactory.Instance.Create(BDCType.NoticesBDC);
            return noticeBDC.GetCurrentNotices();
        }

        public OperationResult<IList<INoticesDTO>> GetActiveNotices()
        {
            INoticesBDC noticeBDC = (INoticesBDC)BDCFactory.Instance.Create(BDCType.NoticesBDC);
            return noticeBDC.GetActiveNotices();
        }

        public OperationResult<INoticesDTO> UpdateNotice(INoticesDTO noticesDTO)
        {
            INoticesBDC noticeBDC = (INoticesBDC)BDCFactory.Instance.Create(BDCType.NoticesBDC);
            return noticeBDC.UpdateNotice(noticesDTO);
        }

        public OperationResult<bool> DeleteNotice(int noticeId)
        {
            INoticesBDC noticeBDC = (INoticesBDC)BDCFactory.Instance.Create(BDCType.NoticesBDC);
            return noticeBDC.DeleteNotice(noticeId);
        }
    }
}
