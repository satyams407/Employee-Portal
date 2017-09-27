using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.BusinessFacades
{
    public class DepartmentFacade : FacadeBase, IDepartmentFacades
    {
         public DepartmentFacade() : base(FacadeType.DepartmentFacade)
        {

        }



         public OperationResult<IDepartmentDTO> GetDepartment(int departmentId)
         {
             IDepartmentBDC departmentBDC = (IDepartmentBDC)BDCFactory.Instance.Create(BDCType.DepartmentBDC);
             return departmentBDC.GetDepartment(departmentId);
         }

         public OperationResult<IList<IDepartmentDTO>> GetAll()
         {

             IDepartmentBDC departmentBDC = (IDepartmentBDC)BDCFactory.Instance.Create(BDCType.DepartmentBDC);
             return departmentBDC.GetAll();
         }

        
    }
}
