using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IDepartmentFacades : IFacade
    {
        OperationResult<IDepartmentDTO> GetDepartment(int departmentId);

        OperationResult<IList<IDepartmentDTO>> GetAll();
    }
}
