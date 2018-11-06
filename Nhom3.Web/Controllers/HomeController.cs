using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Nhom3.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Nhom3ControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}