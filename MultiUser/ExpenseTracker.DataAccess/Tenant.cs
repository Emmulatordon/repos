using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DataAccess
{
    public class Tenant
    {
        public string? TenantName { get; set; }
        public string? ConnectionString { get; set; }
    }
}
