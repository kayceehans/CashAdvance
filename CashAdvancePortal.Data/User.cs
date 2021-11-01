using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Data
{
    public class User
    {
        public int Id { get; set; }
        public string EmployeesName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public DateTime DateOfEnrolment { get; set; }
    }
}
