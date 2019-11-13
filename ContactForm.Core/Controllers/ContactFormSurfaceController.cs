using ContactForm.Core.Models;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace ContactForm.Core.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactFormViewModel());
        }
    }
}
