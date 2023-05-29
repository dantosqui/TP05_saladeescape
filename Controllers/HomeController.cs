using Microsoft.AspNetCore.Mvc;

namespace TPsaladeescape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
