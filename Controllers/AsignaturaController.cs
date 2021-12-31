using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;

namespace HolaMundoMVC.Controllers;

public class AsignaturaController : Controller
{

    public IActionResult index()
    {
        var asignatura = new Asignatura();
        asignatura.UniqueId = "123";
        asignatura.Nombre = "Matemàtica";

        return View(asignatura);
    }
    public IActionResult MultiAsignatura()
    {
        var listaAsignaturas = new List<Asignatura> () {
        new Asignatura {
        Nombre = "Matemáticas",
        UniqueId = Guid.NewGuid ().ToString ()
        },
        new Asignatura {
        Nombre = "Educación Física",
        UniqueId = Guid.NewGuid ().ToString ()
        },
        new Asignatura {
        Nombre = "Castellano",
        UniqueId = Guid.NewGuid ().ToString ()
        },
        new Asignatura {
        Nombre = "Ciencias Naturales",
        UniqueId = Guid.NewGuid ().ToString ()
        },
        new Asignatura {
        Nombre = "Programacion",
        UniqueId = Guid.NewGuid ().ToString ()
        }
        };
    
        ViewBag.Fecha = DateTime.Now;

        return View("MultiAsignatura",listaAsignaturas);
        
    }
}
