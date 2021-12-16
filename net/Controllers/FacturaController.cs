using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net.Models;
using net.Models.Repositorios;
namespace net.Controllers;

public class FacturaController : Controller
{
    private readonly ILogger<FacturaController> _logger;

    public FacturaController(ILogger<FacturaController> logger)
    {
        _logger = logger;
    }
      public IActionResult Index()

    {
        ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
        return View();
    }
    
    
    public IActionResult Insertar(Factura factura)
      //yo inserto y despues de insertar
      //vuelvo a mostraar el listado
        {FacturaRepositorio.Insertar(factura);
        ViewBag.ListaFacturas=FacturaRepositorio.BuscarTodos();

        return RedirectToAction("Index","Factura");

        }
    public IActionResult Detalle(int numero)
    { 
        ViewBag.Factura =FacturaRepositorio.BuscarUna(numero);
        /*
        ViewBag.concepto = factura.Concepto;
        ViewBag.importe = factura.Importe;
        ViewBag.tipoIVA = factura.TipoIVA;
        ViewBag.pagada = factura.Pagada;
            */
        return View();
    }
    public IActionResult Formulario()
    {
        return View();
    }
   public IActionResult Borrar(int numero)
    { 
        FacturaRepositorio.Borrar(numero);
        
        ViewBag.ListaFacturas =FacturaRepositorio.BuscarTodos();
        
        return RedirectToAction("Index","Factura");


    }
        public IActionResult Privacy()
    {
        return View();
    }


}


