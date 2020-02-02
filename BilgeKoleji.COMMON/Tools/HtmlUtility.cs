using System.Web.Mvc;

namespace BilgeKoleji.COMMON.Tools
{
    public static class HtmlUtility
    {
        public static string IsActive(this HtmlHelper html, string action, string control)
        {
            var routeDate = html.ViewContext.RouteData;
            var routeAction = (string)routeDate.Values["action"];
            var routeControl = (string)routeDate.Values["controller"];

            var returnActive = control == routeControl && action == routeAction;
            return returnActive ? "active" : "";
        }
        public static string IsActive(this HtmlHelper html,string control)
        {
            var routeDate = html.ViewContext.RouteData;
            var routeControl = (string)routeDate.Values["controller"];

            return control == routeControl ? "active" : "";
        }
    }
}
