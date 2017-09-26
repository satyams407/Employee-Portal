using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Business
{
    public class NoticeValidator : AbstractValidator<INoticesDTO>
    {
        public NoticeValidator()
        {
            RuleSet("Common", () =>
            {
             RuleFor(notice => notice.Title).NotEmpty().WithMessage("Title should not be empty.").Length(1, 100).WithMessage("Title should be less than 100 characters").WithName("Title");
            });

            RuleSet("RulesetName", () =>
            {

                RuleFor(notice => notice.StartDate).GreaterThanOrEqualTo(DateTime.Now.Date).WithName("StartDate");

            });

        }
    }
}
