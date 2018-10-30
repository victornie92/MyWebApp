using System.Web.Mvc;
using System.Web.UI.WebControls;
using Umbraco.Core;
using Umbraco.Web.Mvc;

namespace MyUmbracoWebApp.Controller
{
    public class AboutController : SurfaceController
    {
        public ActionResult About()
        {
            var test = "";

            return PartialView("About");
        }
    }
}