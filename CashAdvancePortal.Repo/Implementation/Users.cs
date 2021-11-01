using CashAdvancePortal.Data;
using CashAdvancePortal.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Repo.Implementation
{
    public class Users: IUsers
    {
        private readonly CashAdvancePortalContext _context;
        public Users(CashAdvancePortalContext context)
        {
            _context = context;
        }
        public async Task<bool> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            return (_context.SaveChanges() > 0);
        }
        public async Task<User> GetUsers(string username, string password)
        {
          return  _context.Users.Where(c => c.Username == username && c.Password == password).FirstOrDefault();
        }
        public async Task<bool> DeleteUsers(string username)
        {
            var getUser = _context.Users.Where(c => c.Username == username).FirstOrDefault();
            _context.Users.Remove(getUser);
            return (_context.SaveChanges() > 0 );
        }
        public async Task<bool> UpdateUsers(User user)
        {
            var userContext = _context.Users.Where(c => c.Username == user.Username).FirstOrDefault();
            userContext.Username = user.Username;
            userContext.Password = user.Password;
            userContext.Role = user.Role;
            userContext.DateOfEnrolment = user.DateOfEnrolment;
            userContext.Department = user.Department;
            userContext.EmployeesName = user.EmployeesName;
            return (_context.SaveChanges() > 0 );
        }
    }
}
