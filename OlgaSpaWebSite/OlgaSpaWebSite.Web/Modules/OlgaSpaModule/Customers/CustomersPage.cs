

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "OlgaSpaModule/Customers", typeof(OlgaSpaWebSite.OlgaSpaModule.Pages.CustomersController))]

namespace OlgaSpaWebSite.OlgaSpaModule.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("OlgaSpaModule/Customers"), Route("{action=index}")]
    public class CustomersController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/OlgaSpaModule/Customers/CustomersIndex.cshtml");
        }
    }
}