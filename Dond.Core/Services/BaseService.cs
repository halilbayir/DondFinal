using Dond.Models;

namespace Dond.Core.Services
{
    public class BaseService
    {
        public DondDBContext Context { get; set; }
   
        public BaseService(DondDBContext ctx)
    {
        Context= ctx;
    }
    }
}
