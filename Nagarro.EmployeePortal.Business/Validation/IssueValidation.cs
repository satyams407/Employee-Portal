using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Business
{
   public class IssueValidation : AbstractValidator<IIssuesDTO>
    {
       public IssueValidation()
       {

       }
    }
}
