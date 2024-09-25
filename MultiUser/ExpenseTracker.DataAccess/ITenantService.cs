namespace ExpenseTracker.DataAccess
{
    public interface ITenantService
    {
        public string GetConnectionString();
        public Tenant GetTenant();
    }
}
