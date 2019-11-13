using ContactForm.Core.Models;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace ContactForm.Core.Controllers
{
    public class PolicySurfaceController : SurfaceController
    {
        // GET
        public ActionResult Index()
        {
            return PartialView("PolicyView", new PolicyViewModel());
        }
        [HttpPost]
        public ActionResult Index(PolicyViewModel model)
        {
            HttpCookie cookie = Request.Cookies.Get("Dibsta");
            if (cookie != null)
            {
                Response.Cookies.Add(new HttpCookie("Dibsta2")
                {
                    Value = "DibstaNewCookie"
                });

            }

            return RedirectToCurrentUmbracoPage();
        }
    }
}
