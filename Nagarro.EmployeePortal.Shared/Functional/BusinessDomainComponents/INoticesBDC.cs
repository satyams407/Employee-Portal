using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface INoticesBDC : IBusinessDomainComponent
    {
        OperationResult<INoticesDTO> CreateNotice(INoticesDTO noticesDTO);

        OperationResult<IList<INoticesDTO>> GetCurrentNotices();

        OperationResult<IList<INoticesDTO>> GetActiveNotices();

        OperationResult<INoticesDTO> UpdateNotice(INoticesDTO noticesDTO);

        OperationResult<bool> DeleteNotice(int noticeId);
     
    }
}
