using CashAdvancePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Repo.Interface
{
    public interface ICashRequestRepo
    {
        Task<List<CashRequest>> GetAllCashRequest();
        Task<List<CashRequest>> GetCashRequestByApproved(bool isApproved);
        Task<bool> AddCashRequest(CashRequest request);
        Task<bool> UpdateCashRequest(CashRequest request);
        Task<bool> DeleteCashRequest(string requestID);
    }
}
