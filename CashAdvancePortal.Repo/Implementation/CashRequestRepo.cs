using CashAdvancePortal.Data;
using CashAdvancePortal.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAdvancePortal.Repo.Implementation
{
    public class CashRequestRepo: ICashRequestRepo
    {
        private readonly CashAdvancePortalContext _context;

        public CashRequestRepo(CashAdvancePortalContext context)
        {
            _context = context;
        }

        public async Task<List<CashRequest>> GetAllCashRequest()
        {
            return  _context.CashRequests.ToList();
        }
        public async Task<List<CashRequest>> GetCashRequestByApproved(bool isApproved)
        {
            return _context.CashRequests.Where(c => c.IsApproved == isApproved).ToList();
        }
        public async Task<bool> AddCashRequest(CashRequest request)
        {
            await _context.CashRequests.AddAsync(request);
          
            return (_context.SaveChanges()) > 0;
        }
        public async Task<bool> UpdateCashRequest(CashRequest request)
        {
            var contextUpdate = _context.CashRequests.Where(c => c.RequestID == request.RequestID).FirstOrDefault();
            contextUpdate.IsApproved = request.IsApproved;
            contextUpdate.NameOfEmployee = request.NameOfEmployee;
            contextUpdate.RequestID = request.RequestID;
            contextUpdate.SupervisorName = request.SupervisorName;
            
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<bool> DeleteCashRequest(string requestID)
        {
            var cashReq = _context.CashRequests.Where(c => c.RequestID == requestID).FirstOrDefault();
            _context.CashRequests.Remove(cashReq);

            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
