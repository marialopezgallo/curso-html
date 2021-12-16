﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net.Models;

namespace net.Controllers;

public class PersonaController : Controller
{
    private readonly ILogger<PersonaController> _logger;

    public PersonaController(ILogger<PersonaController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RecibirDatosPersona(Persona persona)
    {   ViewBag.nombre=persona.Nombre;
        ViewBag.edad=persona.Edad;
        ViewBag.jubilado=persona.Jubilado;

        return View();
    }
    
    public IActionResult Privacy()
    {
        return View();
    }    
    

}


