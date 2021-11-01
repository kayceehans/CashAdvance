using CashAdvancePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.ApplicationServices.Interface
{
    public interface IUserServices
    {
        Task<User> GetUsers(string username, string password);
    }
}
