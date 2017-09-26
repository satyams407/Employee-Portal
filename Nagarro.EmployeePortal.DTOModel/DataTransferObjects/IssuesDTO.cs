using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.Issue", MappingType.TotalExplicit)]
    public class IssuesDTO : DTOBase, IIssuesDTO
    {
        public IssuesDTO() : base(DTOType.IssuesDTO) { }

        [EntityPropertyMapping(MappingDirectionType.Both, "IssueId")]
        public int IssueId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Title")]
        public string Title { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Description")]
        public string Description { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "PostedBy")]
        public int PostedBy { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Priority")]
        public int Priority { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public bool IsActive { get; set; }

        
        public string PostedByName { get; set; }
        public IList<IComplexIssueHistoryDTO> IssueHistories { get; set; }

        public IIssueHistoriesDTO IssueHistoriesDTO  { get; set; }
    }
}
