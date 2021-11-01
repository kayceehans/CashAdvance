using CashAdvancePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.ApplicationServices.Interface
{
    public interface ICashRequestServices
    {
        Task<bool> AddCashRequest(CashRequest request);
        Task<IList<CashRequest>> GetAllCashAdvance();

        Task<IList<CashRequest>> GetApprovedCashRequest();

        Task<bool> UpdateCashRequest(CashRequest request);
        
    }
}
