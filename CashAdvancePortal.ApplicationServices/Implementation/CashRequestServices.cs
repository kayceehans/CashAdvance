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
    public class CashRequestServices: ICashRequestServices
    {
        private readonly ICashRequestRepo _cashRequestRepo;
        public CashRequestServices(ICashRequestRepo cashRequestRepo)
        {
            _cashRequestRepo = cashRequestRepo;
        }
        public async Task<bool> AddCashRequest(CashRequest request)
        {
            var addCashReq = await _cashRequestRepo.AddCashRequest(request);
            return addCashReq;
        }

        public async Task<IList<CashRequest>> GetAllCashAdvance()
        {
            var cash = await _cashRequestRepo.GetAllCashRequest();
            return cash;
        }

        public async Task<IList<CashRequest>> GetApprovedCashRequest()
        {
            return await _cashRequestRepo.GetCashRequestByApproved(true);
        }

        public async Task<bool> UpdateCashRequest(CashRequest request)
        {
            return await _cashRequestRepo.UpdateCashRequest(request);
        }
    }
}
