namespace Renting.Domain
{
    public class TenantId
    {
        private readonly string _id;

        private TenantId(string id)
        {
            _id = id;
        }

        public static TenantId From(string tenantId)
        {
            return new TenantId(tenantId);
        }

        public override string ToString()
        {
            return _id;
        }
    }
}