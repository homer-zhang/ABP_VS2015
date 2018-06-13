using System.Web.Mvc;

namespace Template.Dev.Web.Controllers
{
    public class AboutController : DevControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}