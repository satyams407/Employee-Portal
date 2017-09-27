using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IUsersDAC : IDataAccessComponent
    {
       IUsersDTO CreateUser(IUsersDTO usersDTO);

       IList<IEmployeesDTO> SearchEmployee(IEmployeesDTO searchEmployeeDTO, bool checkTerminationDate);

       IUsersDTO UpdateProfile(IUsersDTO usersDTO);

       bool GetEmailIdOfUser(string emailId);
    }
}
