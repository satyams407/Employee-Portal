using Nagarro.EmployeePortal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.DTOModel
{
    [EntityMapping("Nagarro.EmployeePortal.EntityDataModel.EntityModel.Sample", MappingType.TotalExplicit)]
    public class SampleDTO : DTOBase, ISampleDTO
    {
        public SampleDTO() : base(DTOType.SampleDTO)
        {

        }

        [EntityPropertyMapping(MappingDirectionType.Both, "SampleProperty")]
        public string SampleProperty { get; set; }
    }
         
}
