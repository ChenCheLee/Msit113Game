using System.Web.Mvc;

namespace MVCgroup2.Areas.揪團
{
    public class 揪團AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "揪團";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "揪團_default",
                "揪團/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}