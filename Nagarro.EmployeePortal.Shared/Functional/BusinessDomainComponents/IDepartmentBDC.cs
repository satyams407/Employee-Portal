using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IDepartmentBDC : IBusinessDomainComponent
    {
        OperationResult<IDepartmentDTO> GetDepartment(int departmentId);

        OperationResult<IList<IDepartmentDTO>> GetAll();
    }
}
