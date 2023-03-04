using BlogEngineSergioDemarco.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngineSergioDemarco.Controllers
{
    public class RoleViewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireManager)]
        public IActionResult Manager()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireAdmin)]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
