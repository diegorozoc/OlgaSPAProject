

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "OlgaSpaModule/Treatments", typeof(OlgaSpaWebSite.OlgaSpaModule.Pages.TreatmentsController))]

namespace OlgaSpaWebSite.OlgaSpaModule.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("OlgaSpaModule/Treatments"), Route("{action=index}")]
    public class TreatmentsController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/OlgaSpaModule/Treatments/TreatmentsIndex.cshtml");
        }
    }
}