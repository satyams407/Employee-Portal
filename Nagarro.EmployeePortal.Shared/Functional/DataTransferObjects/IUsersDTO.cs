using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
   public interface IUsersDTO : IDTO
    {
       int UserId { get; set; }

       string Password { get; set; }

       bool IsAdmin { get; set; }

       IEmployeesDTO Employee { get; set; }
    }
}
