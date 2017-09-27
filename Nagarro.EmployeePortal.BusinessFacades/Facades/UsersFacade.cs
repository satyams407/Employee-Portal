using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.EmployeePortal.Shared;

namespace Nagarro.EmployeePortal.BusinessFacades
{
    public class UsersFacade : FacadeBase, IUsersFacades
    {
        public UsersFacade() : base(FacadeType.UsersFacade) { }

        public OperationResult<IUsersDTO> CreateUser(IUsersDTO usersDTO)
        {
            IUsersBDC userBDC = (IUsersBDC)BDCFactory.Instance.Create(BDCType.UsersBDC);
            return userBDC.CreateUser(usersDTO);
        }


    }
}
