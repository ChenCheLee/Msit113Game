using System.Web.Mvc;

namespace GameMVC.Areas.Gamewiki
{
    public class GamewikiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Gamewiki";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Gamewiki_default",
                "Gamewiki/{controller}/{action}/{id}",
                new {Controller="Wiki", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}