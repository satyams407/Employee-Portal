using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
   public  interface IUsersFacades :IFacade
    {
       OperationResult<IUsersDTO> CreateUser(IUsersDTO usersDTO);
    }
}
