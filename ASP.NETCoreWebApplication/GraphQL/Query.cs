using Microsoft.AspNetCore.Authorization;

namespace ASP.NETCoreWebApplication.GraphQL
{
    public class Query
    {
        public string HelloNoAuth()
        {
            return "no auth";
        }
        
        
        [Authorize]
        public string HelloWithAuth()
        {
            return "with auth";
        }
    }
}