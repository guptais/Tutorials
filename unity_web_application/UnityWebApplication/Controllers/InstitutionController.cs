using Services;
using System.Web.Mvc;

namespace UnityWebApplication.Controllers
{
    public class InstitutionController : Controller
    {
        private IInstitutionService institutionService;

        public InstitutionController(IInstitutionService institutionService)
        {
            this.institutionService = institutionService;
        }

        // GET: Institution
        public ActionResult Index()
        {
            return View(this.institutionService.GetInstitutionByID(1));
        }
    }
}