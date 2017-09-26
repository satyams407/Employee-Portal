using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.Business
{
    class UsersBDC : BDCBase, IUsersBDC
    {

        public UsersBDC() : base(BDCType.UsersBDC) { }

        public OperationResult<IUsersDTO> CreateUser(IUsersDTO usersDTO)
        {
            OperationResult<IUsersDTO> createUsersRetValue = null;
            try
            {
                IUsersDAC userDAC = (IUsersDAC)DACFactory.Instance.Create(DACType.UsersDAC);
                IUsersDTO returnedUserDTO = userDAC.CreateUser(usersDTO);
                if (returnedUserDTO != null)
                {
                    createUsersRetValue = OperationResult<IUsersDTO>.CreateSuccessResult(returnedUserDTO, "users created successfully");
                }
                else
                {
                    createUsersRetValue = OperationResult<IUsersDTO>.CreateFailureResult("Insertion failed!");
                }
            }
            catch (DACException dacEx)
            {
                createUsersRetValue = OperationResult<IUsersDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                createUsersRetValue = OperationResult<IUsersDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }

            return createUsersRetValue;
        }


    }
}
