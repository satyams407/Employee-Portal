using Nagarro.EmployeePortal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Data
{
    public class SampleDAC : DACBase, ISampleDAC
    {
        public SampleDAC() : base(DACType.SampleDAC)
        {

        }

        public ISampleDTO SampleMethod(ISampleDTO sampleDTO)
        {
            //Entity Converter
            //Save to DB

            sampleDTO.SampleProperty = "New Value";
            return sampleDTO;
        }
    }

}
