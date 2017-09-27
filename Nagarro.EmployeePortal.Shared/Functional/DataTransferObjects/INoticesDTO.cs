using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
   public interface INoticesDTO : IDTO
    {
       int NoticeId { get; set; }
       int PostedBy { get; set; }
       string Title { get; set; }
       string Description { get; set; }
       DateTime StartDate { get; set; }
       DateTime ExpirationDate { get; set; }
       bool IsActive { get; set; }
    }
}
