using ContactForm.Core.Models;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ContactForm.Core.Controllers
{
    public class CookeController : RenderMvcController
    {
        // GET
        public override ActionResult Index(ContentModel model)
        {
            var cookieModel = new CookeViewModel(model.Content);
            //return CurrentTemplate(cookieModel);
            return PartialView("Cookie/cookieSettings", cookieModel);
        }
    }
}
