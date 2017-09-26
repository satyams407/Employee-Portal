using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.GetIssueHistoryByIssueId_Result", MappingType.TotalExplicit)]
    public class ComplexIssueHistoryDTO : DTOBase , IComplexIssueHistoryDTO
    {
        public ComplexIssueHistoryDTO() : base(DTOType.ComplexIssueHistoryDTO) { }

        [EntityPropertyMapping(MappingDirectionType.Both, "IssueHistoryId")]
        public int IssueHistoryId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "IssueId")]
        public int IssueId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Comments")]
        public string Comments { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "ModifiedBy")]
        public int ModifiedBy { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "ModifiedOn ")]
        public System.DateTime ModifiedOn { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "AssignedTo")]
        public Nullable<int> AssignedTo { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Status")]
        public int Status { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "AssignedToName")]
        public string AssignedToName { get; set; }
    }
}
