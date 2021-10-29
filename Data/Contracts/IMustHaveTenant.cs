using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Data.Contracts
{
    public interface IMustHaveTenant
    {
        public string TenantId { get; set; }
    }
}
