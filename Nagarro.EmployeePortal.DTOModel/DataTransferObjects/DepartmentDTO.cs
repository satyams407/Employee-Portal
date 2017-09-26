using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.Departments", MappingType.TotalExplicit)]
    public class DepartmentDTO : DTOBase , IDepartmentDTO
    {

        public DepartmentDTO() : base(DTOType.DepartmentDTO)
        {

        }

        [EntityPropertyMapping(MappingDirectionType.Both, "DepartmentId")]
        public int DepartmentId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "DepartmentName")]
        public string DepartmentName { get; set; }
        
    }
}
