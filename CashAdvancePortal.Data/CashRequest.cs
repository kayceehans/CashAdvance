using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Data
{
    public class CashRequest
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string NameOfEmployee { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfApproval { get; set; }
        public bool IsApproved { get; set; }
        public string SupervisorName { get; set; }
        public string RequestID { get; set; }
        public string CashAdvancePurpose { get; set; }
    }
}
         