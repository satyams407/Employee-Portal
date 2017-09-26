using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.User", MappingType.TotalExplicit)]
    public class UsersDTO : DTOBase, IUsersDTO
    {

        public UsersDTO() : base(DTOType.UsersDTO){ }

        [EntityPropertyMapping(MappingDirectionType.Both, "UserId")]
        public int UserId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Password")]
        public string Password { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "IsAdmin")]
        public bool IsAdmin { get; set; }

     
        public IEmployeesDTO Employee { get; set; }

    }
}
