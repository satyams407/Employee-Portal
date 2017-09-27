using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
   public interface IDepartmentDTO : IDTO
    {
        int DepartmentId { get; set; }

        string DepartmentName { get; set; }
    }
}
