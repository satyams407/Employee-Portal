using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;
using FluentValidation;

namespace Nagarro.EmployeePortal.Business
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T1"></typeparam>
    public static class Validator<T, T1> where T : AbstractValidator<T1>, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static EmployeePortalValidationResult Validate(T1 dto)
        {
            T validator = new T();
            return validator.Validate(dto).ToValidationResult();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="ruleSet"></param>
        /// <returns></returns>
        public static EmployeePortalValidationResult Validate(T1 dto, string ruleSet)
        {
            T validator = new T();
            return validator.Validate(dto, ruleSet: ruleSet).ToValidationResult();
        }
    }
}
