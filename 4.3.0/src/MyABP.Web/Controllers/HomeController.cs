using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}