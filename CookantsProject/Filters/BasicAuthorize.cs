using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using CookantsEntity.Common;

namespace CoockantsWeb.Filters
{
    public class BasicAuthorizeAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            

        }
    }
}