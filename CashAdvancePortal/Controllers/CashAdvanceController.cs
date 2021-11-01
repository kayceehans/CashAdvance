using CashAdvancePortal.ApplicationServices.Interface;
using CashAdvancePortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashAdvancePortal.Controllers
{
    [Route("api/cashadvance/[action]")]
    [ApiController]
    public class CashAdvanceController : ControllerBase
    {
        private readonly ICashRequestServices _cashReq;
        private readonly IUserServices _users;
        public CashAdvanceController(ICashRequestServices cashReq, IUserServices users)
        {
            _cashReq = cashReq;
            _users = users;
        }
        [HttpPost]
        public async Task<IActionResult> RequestCash([FromForm]CashRequest request)
        {
            try
            {                
                if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionName")))
                {
                    return Ok(false);
                }
                request.RequestID = (new Random().Next(1,1000)).ToString();
                request.DateOfRequest = DateTime.Now;
                var cashReq = await _cashReq.AddCashRequest(request);
                return Ok(cashReq);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet]
        public async Task<IActionResult> CashRequest()
        {
            try
            {
                var cashReq = await _cashReq.GetAllCashAdvance();
                return Ok(cashReq);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        public async Task<IActionResult> ApprovedCashRequest()
        {
            try
            {
                var cashReq = await _cashReq.GetApprovedCashRequest();
                return Ok(cashReq);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromForm]string username, [FromForm]string password)
        {
            try
            {
                var user = username.Replace("@cybernalytix.com", "");
                var getUser = await _users.GetUsers(user, password);
                if (getUser == null)
                {
                    var resp = new { result = "Username/Password Incorrect", status = "01" };
                    return Ok(resp);
                }
                HttpContext.Session.SetString("SessionName", getUser.Username);
                HttpContext.Session.SetString("Department", getUser.Department);
                var response = new { result = getUser, status = "00" };
                return Ok(response);
            }
            catch (Exception ex)
            {
              return  BadRequest(ex.Message);
            }
        }
    }
}
