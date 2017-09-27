using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    public interface IEmployeesDTO : IDTO
    {
        int EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        System.DateTime DateOfJoining { get; set; }
        Nullable<System.DateTime> TerminationDate { get; set; }
        int DepartmentId { get; set; }
    }
}
