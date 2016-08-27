namespace OlgaSpaWebSite.OlgaSpaModule.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("OlgaSpaModule/Appoinments"), Route("{action=index}")]
    public class AppoinmentsController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/OlgaSpaModule/Appoinments/AppoinmentsIndex.cshtml");
        }
    }
}