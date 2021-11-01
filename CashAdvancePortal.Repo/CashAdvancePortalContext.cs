using CashAdvancePortal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CashAdvancePortal.Repo
{
    public class CashAdvancePortalContext: DbContext
    {

        public CashAdvancePortalContext(DbContextOptions<CashAdvancePortalContext> options) : base(options){}

        public DbSet<User> Users { get; set; }

        public DbSet<CashRequest> CashRequests { get; set; }
    }
}
