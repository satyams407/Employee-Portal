using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.GetAllIssuesByEmployeeId_Result", MappingType.TotalExplicit)]
    public class ComplexIssueDTO : DTOBase, IComplexIssueDTO
    {
        public ComplexIssueDTO() : base(DTOType.ComplexIssueDTO) { }

        [EntityPropertyMapping(MappingDirectionType.Both, "IssueId")]
        public int IssueId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Title")]
        public string Title { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Description ")]
        public string Description { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "PostedBy")]
        public int PostedBy { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Priority ")]
        public int Priority { get; set; }
        
        [EntityPropertyMapping(MappingDirectionType.Both, "AssignedTo")]
        public Nullable<int> AssignedTo { get; set; }
        
        [EntityPropertyMapping(MappingDirectionType.Both, "status")]
        public int status { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public bool IsActive { get; set; }
        
        [EntityPropertyMapping(MappingDirectionType.Both, "PostedByName")]
        public string PostedByName { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "AssignedToName")]
        public string AssignedToName { get; set; }
    }
}
