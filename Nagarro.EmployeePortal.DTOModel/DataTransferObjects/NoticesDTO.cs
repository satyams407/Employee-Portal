using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.Notice", MappingType.TotalExplicit)]
    public class NoticesDTO : DTOBase, INoticesDTO
    {
        public NoticesDTO() : base(DTOType.NoticesDTO){ }

        [EntityPropertyMapping(MappingDirectionType.Both, "NoticeId")]
        public int NoticeId { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "PostedBy")]
        public int PostedBy { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Title")]
        public string Title { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "Description")]
        public string Description { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "StartDate")]
        public DateTime StartDate{ get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "ExpirationDate")]
        public DateTime ExpirationDate { get; set; }

        [EntityPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public bool IsActive{ get; set; }

    }
}
