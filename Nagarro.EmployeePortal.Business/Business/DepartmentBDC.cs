using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Business
{
    public class DepartmentBDC : BDCBase, IDepartmentBDC
    {
        public DepartmentBDC() : base(BDCType.DepartmentBDC)
        {

        }

        public OperationResult<IDepartmentDTO> GetDepartment(int departmentId)
        {
            OperationResult<IDepartmentDTO> getDepartmentRetVal = null;
            try
            {
                IDepartmentDAC departmentDAC = (IDepartmentDAC)DACFactory.Instance.Create(DACType.DepartmentDAC);
                IDepartmentDTO returnedDepartmentDTO = departmentDAC.GetDepartment(departmentId);
                if (returnedDepartmentDTO != null)
                {
                    getDepartmentRetVal = OperationResult<IDepartmentDTO>.CreateSuccessResult(returnedDepartmentDTO, " successfully");
                }
                else
                {
                    getDepartmentRetVal = OperationResult<IDepartmentDTO>.CreateFailureResult("failed!");
                }
            }
            catch (DACException dacEx)
            {
                getDepartmentRetVal = OperationResult<IDepartmentDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                getDepartmentRetVal = OperationResult<IDepartmentDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return getDepartmentRetVal;
        }
        

        public OperationResult<IList<IDepartmentDTO>> GetAll()
        {
            OperationResult<IList<IDepartmentDTO>> getDepartmentRetVal = null;
            try
            {
                IDepartmentDAC departmentDAC = (IDepartmentDAC)DACFactory.Instance.Create(DACType.DepartmentDAC);
                IList<IDepartmentDTO> returnedDepartmentDTO = departmentDAC.GetAll();
                if (returnedDepartmentDTO != null)
                {
                    getDepartmentRetVal = OperationResult<IList<IDepartmentDTO>>.CreateSuccessResult(returnedDepartmentDTO, " successfully");
                }
                else
                {
                    getDepartmentRetVal = OperationResult<IList<IDepartmentDTO>>.CreateFailureResult("failed!");
                }
            }
            catch (DACException dacEx)
            {
                getDepartmentRetVal = OperationResult<IList<IDepartmentDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                getDepartmentRetVal = OperationResult<IList<IDepartmentDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return getDepartmentRetVal;
        }
    }
}
