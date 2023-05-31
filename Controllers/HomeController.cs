using Microsoft.AspNetCore.Mvc;

namespace TPsaladeescape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Inicio()
    {
        return View();
    }
    public IActionResult Habitacion(int sala, string clave) {
        if(escape.ResolverSala(sala, clave)){
            return View("habitacion"+clave);
        }
        else{
            ViewBag.incorrecto="incorrecto";
            return View("habitacion"+escape.GetEstadoJuego);
        }
    }
}
