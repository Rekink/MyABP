using System.Web.Mvc;

namespace MyABP.Web.Controllers
{
    public class AboutController : MyABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}