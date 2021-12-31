using Microsoft.AspNetCore.Mvc;
using System.Linq;
using HolaMundoMVC.Models;

namespace HolaMundoMVC.Controllers;

public class EscuelaController : Controller
{
    private EscuelaContext _context;
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.AñoDeCreación=2005;
        escuela.UniqueId = "123";
        escuela.Nombre = "Platzi School";
        escuela.Pais = "Perù";
        escuela.Ciudad = "Lima";
        escuela.Dirección = "Jr. Los Jacintos 1334";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
                
        ViewBag.CosaDinamica = "La Monja";
        
        // var escuela = _context.Escuelas.FirstOrDefault();

        return View(escuela);
    }

    // public EscuelaController(EscuelaContext context){
    //     _context = context;
    // }
}