using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Business
{
    public class UsersValidation : AbstractValidator<IUsersDTO> 
    {
        public UsersValidation()
        {
            RuleSet("Common", () =>
                {
                    RuleFor(employee => employee.Employee.FirstName).NotEmpty().WithMessage("First Name should not be empty.").Length(1, 50).WithMessage("First Name should be less than 50 characters").WithName("FirstName");
                    RuleFor(employee => employee.Employee.LastName).NotEmpty().WithMessage("Last Name should not be empty.").Length(1, 50).WithMessage("Last Name should be less than 50 characters").WithName("LastName");
                    RuleFor(employee => employee.Employee.Email).NotEmpty().WithMessage("Email should not be empty.").Length(1, 100).WithMessage("email should be less than 50 characters").WithName("Email");
                });
        }
    }
}
