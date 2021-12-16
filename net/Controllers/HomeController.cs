using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net.Models;

namespace net.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ciennumeros()
    {   
        return View();
    }
    public IActionResult FormularioSuma()
    {   
        return View();
    }

    public IActionResult vernota(int nota)
    {// el ViewBag, como su nombre indica 
    //es una bolsa de intercamboio de informacion entre el controlador y la vista

        ViewBag.nota=nota;
        return View();
    }

public IActionResult Resultadosuma(int numero1 , int numero2  )
    {// el ViewBag, como su nombre indica 
    //es una bolsa de intercamboio de informacion entre el controlador y la vista
        int Suma=numero1+numero2;
        ViewBag.Suma=Suma;
        return View();
    }
    public IActionResult Mensaje()
    {   
        ViewBag.Mensaje="mensaje de Maria";

        return View("mensaje");
    }
}


   