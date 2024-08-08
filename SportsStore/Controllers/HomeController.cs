using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index() => View();
    }
}
