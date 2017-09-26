using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.Employee", MappingType.TotalExplicit)]
    public class EmployeesDTO : DTOBase, IEmployeesDTO
    {
        public EmployeesDTO() : base(DTOType.EmployeeDTO){ }

        [EntityPropertyMapping(MappingDirectionType.Both, "EmployeeId")]
        public int EmployeeId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "FirstName")]
        public string FirstName { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "LastName")]
        public string LastName { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Email")]
        public string Email { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "DateOfJoining")]
        public System.DateTime DateOfJoining { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "TerminationDate")]
        public Nullable<System.DateTime> TerminationDate { get; set; }
        
        [EntityPropertyMapping(MappingDirectionType.Both, "DepartmentId")]
        public int DepartmentId { get; set; }
    }
}
