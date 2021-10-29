using System;
using System.Collections.Generic;
using System.Text;
using Users.Data.Settings;

namespace Users.Data.Interfaces
{
    public interface ITenantService
    {
        public string GetDatabaseProvider();
        public string GetConnectionString();
        public Tenant GetTenant();
    }
}
