using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Infrastructure.Filters {

    public class OrAuthorizationAttribute : AuthorizeAttribute {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
    }
}