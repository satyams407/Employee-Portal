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

    public class UsersDAC : DACBase, IUsersDAC
    {

        public UsersDAC() : base(DACType.UsersDAC) { }

        public IUsersDTO CreateUser(IUsersDTO usersDTO)
        {
            IUsersDTO createUserRetval = null;
            try
            {
                using (EmployeePortalEntities context = new EmployeePortalEntities())
                {

                    Employee employee = new Employee();
                    EntityConverter.FillEntityFromDTO(usersDTO.Employee, employee);
                    context.Employees.Add(employee);

                    User user = new User();
                    user.EmployeeId = employee.EmployeeId;
                    EntityConverter.FillEntityFromDTO(usersDTO, user);
                    context.Users.Add(user);


                    // user.UserId = usersDTO.UserId;
                    //employee.EmployeeId = usersDTO.EmployeesDTO.EmployeeId;
                    context.SaveChanges();
                    createUserRetval = usersDTO;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return createUserRetval;
        }

        public IList<IEmployeesDTO> SearchEmployee(IEmployeesDTO searchEmployeeDTO, bool checkTerminationDate)
        {
            IList<IEmployeesDTO> retVal = null;

            try
            {
                using (EmployeePortalEntities portal = new EmployeePortalEntities())
                {
                    IList<Employee> employeeList = new List<Employee>();
                    employeeList = portal.SearchEmployee(searchEmployeeDTO.FirstName,
                                                         searchEmployeeDTO.LastName,
                                                         searchEmployeeDTO.Email,
                                                         searchEmployeeDTO.DateOfJoining,
                                                         searchEmployeeDTO.TerminationDate,
                                                         searchEmployeeDTO.DepartmentId,
                                                         checkTerminationDate).ToList();

                    if (employeeList.Count > 0)
                    {
                        retVal = new List<IEmployeesDTO>();
                        foreach (var employee in employeeList)
                        {
                            IEmployeesDTO employeeDTO = (IEmployeesDTO)DTOFactory.Instance.Create(DTOType.EmployeeDTO);
                            EntityConverter.FillDTOFromEntity(employee, employeeDTO);
                            retVal.Add(employeeDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return retVal;
        }

        public IUsersDTO UpdateProfile(IUsersDTO usersDTO)
        {
            throw new NotImplementedException();
        }

    }
}
