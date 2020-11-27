using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    public class CatalogController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}