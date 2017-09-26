using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.EntityDataModel;
using Nagarro.EmployeePortal.EntityDataModel.EntityModel;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Data
{
    public class DepartmentDAC : DACBase , IDepartmentDAC
    {
        public DepartmentDAC() : base(DACType.DepartmentDAC)
        {

        }

        public  IList<IDepartmentDTO> GetAll()
        {
            List<IDepartmentDTO> departments = new List<IDepartmentDTO>();

            try 
            {
              using(EmployeePortalEntities context = new EmployeePortalEntities())
              {
                  foreach(var departmentName in context.Departments)
                  {
                      IDepartmentDTO departmentDTO = (IDepartmentDTO)DTOFactory.Instance.Create(DTOType.DepartmentDTO);
                      EntityConverter.FillDTOFromEntity(departmentName, departmentDTO);
                      departments.Add(departmentDTO);
                  
                  }
              }
            }
            catch(Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return departments;
        }

        public IDepartmentDTO GetDepartment(int departmentId)
        {
            IDepartmentDTO retVal = null;
            try 
            { 
              using (EmployeePortalEntities context = new EmployeePortalEntities())
              {
                IDepartmentDTO departmentDTO = (IDepartmentDTO)DTOFactory.Instance.Create(DTOType.DepartmentDTO);
                EntityConverter.FillDTOFromEntity(context.Departments.First(item => item.DepartmentId == departmentId),departmentDTO);
                retVal = departmentDTO;
               }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }   
    }
}
