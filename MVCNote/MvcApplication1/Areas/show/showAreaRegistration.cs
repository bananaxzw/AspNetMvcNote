using System.Web.Mvc;

namespace MvcApplication1.Areas.show
{
    public class showAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "show";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "show_default",
                "show/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
