using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface INoticesDAC : IDataAccessComponent
    {
        //INoticesDTO SampleMethod(INoticesDTO noticesDTO);
        IList<INoticesDTO> GetCurrentNotices();

        IList<INoticesDTO> GetActiveNotices();
        
        bool DeleteNotice(int noticeId);
        
        INoticesDTO UpdateNotice(INoticesDTO noticeDTO);
        
        INoticesDTO CreateNotice(INoticesDTO noticeDTO);


    }
}
