using CashAdvancePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Repo.Interface
{
    public interface IUsers
    {
        Task<bool> AddUser(User users);
        Task<User> GetUsers(string username,string password);
        Task<bool> DeleteUsers(string username);
        Task<bool> UpdateUsers(User user);
    }
}
