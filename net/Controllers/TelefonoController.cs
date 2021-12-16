
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net.Models;
using net.Models.Repositorios;

namespace net.Controllers;

    public class TelefonoController: Controller
{
    private readonly ILogger<TelefonoController> _logger;

    public TelefonoController(ILogger<TelefonoController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()

    {
        ViewBag.ListaTelefonos = TelefonoRepositorio.BuscarTodos();
        return View();
    }

    public IActionResult Insertar(Telefono telefono)
      //yo inserto y despues de insertar
      //vuelvo a mostraar el listado
        {TelefonoRepositorio.Insertar(telefono);
        ViewBag.ListaTelefonos=TelefonoRepositorio.BuscarTodos();

        return RedirectToAction("Index","Telefono");

        }   

        public IActionResult Formulario()
    {
        return View();
    }
    

        public IActionResult Detalle(int numero)
    { 
          ViewBag.Telefono =TelefonoRepositorio.BuscarUna(numero);
        /*
        ViewBag.concepto = factura.Concepto;
        ViewBag.importe = factura.Importe;
        ViewBag.tipoIVA = factura.TipoIVA;
        ViewBag.pagada = factura.Pagada;
            */
        return View();
    }
           
        public IActionResult Borrar(int numero)
    { 
        TelefonoRepositorio.Borrar(numero);
        
        ViewBag.ListaTelefonos =TelefonoRepositorio.BuscarTodos();
        
        return RedirectToAction("Index","Telefono");


    }

}