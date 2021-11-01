using CashAdvancePortal.ApplicationServices.Interface;
using CashAdvancePortal.Data;
using CashAdvancePortal.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.ApplicationServices.Implementation
{
    public class UserServices: IUserServices
    {
        private readonly IUsers _user;
        public UserServices(IUsers user)
        {
            _user = user;
        }
        public Task<User> GetUsers(string username, string password)
        {
            return _user.GetUsers(username, password);
        }
    }
}
