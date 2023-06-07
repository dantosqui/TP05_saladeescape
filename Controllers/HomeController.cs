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
        ViewBag.incorrecto="";
        escape.InicializarJuego();
        return View("habitacion0");
    }
    public IActionResult Habitacion(int sala, string clave) {
        if(escape.ResolverSala(sala, clave)){
            ViewBag.incorrecto="";
            if (escape.GetEstadoJuego()<4)
                return View("habitacion"+escape.GetEstadoJuego());
            else return View("victoria");    
        }
        else{
            ViewBag.incorrecto="INCORRECTOO";
            return View("habitacion"+escape.GetEstadoJuego());
        }
    }
    public IActionResult Carta()
    {
        return View();
    }
    public IActionResult VolverCarta(){
        ViewBag.incorrecto="";
        return View("habitacion0");
    }
    public IActionResult Creditos()
    {
        return View();
    }
}
