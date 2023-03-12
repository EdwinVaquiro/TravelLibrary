using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using PruebaTravel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTravel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Models.LibraryContext _db;
        public HomeController(ILogger<HomeController> logger, Models.LibraryContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
         
            try
            {
               var lst = _db.Libros.Join(_db.AutoresHasLibros, libro => libro.Isbn, autor_libro => autor_libro.LibrosIsbn, (libro, autor_libro) =>
                 new LibrosAutores
                 {
                     IdLibro = Convert.ToInt16(libro.Isbn),
                     Titulo = libro.Titulo,
                     Autor = autor_libro.Autores.Nombre + " " + autor_libro.Autores.Apellidos,
                     Npaginas = libro.NPaginas
                 }
                 ).ToList();
                 
                return View(lst);

            } catch (Exception error)
            {
             
                return View();
            }
            
         
        }

        public IActionResult Details(int? libro) // Action para la vista Details que son los detalles de los libros disponibles
        {
            try
            {

                if (!libro.HasValue || libro == 0) // preguntando si llega algun parametro por medio del url
                {
                    // creando el objeto que va a obtener la lista de la consulta sql por medio del context entity framework
                    var lst = _db.Libros.Join(_db.AutoresHasLibros, libro => libro.Isbn, autor_libro => autor_libro.LibrosIsbn, (libro, autor_libro) =>
                       new DetalleLibros
                       {
                           Titulo = libro.Titulo,
                           Autor = autor_libro.Autores.Nombre + " " + autor_libro.Autores.Apellidos,
                           Npaginas = libro.NPaginas,
                           Sinopsis = libro.Sinopsis,
                           Editorial = libro.Editoriales.Nombre,
                           SedeEditorial = libro.Editoriales.Sede
                       }
                       ).ToList();

                    return View(lst);
                }
                else // en caso de llegar parametro de busqueda
                {
                    Int16 idlibro = (Int16) libro; // haciendo el id
                    var lst = _db.Libros.Where(id => id.Isbn == idlibro).Join(_db.AutoresHasLibros, libro => libro.Isbn, autor_libro => autor_libro.LibrosIsbn, (libro, autor_libro) =>
                           new DetalleLibros
                           {
                               Titulo = libro.Titulo,
                               Autor = autor_libro.Autores.Nombre + " " + autor_libro.Autores.Apellidos,
                               Npaginas = libro.NPaginas,
                               Sinopsis = libro.Sinopsis,
                               Editorial = libro.Editoriales.Nombre,
                               SedeEditorial = libro.Editoriales.Sede
                           }
                       ).ToList();

                    return View(lst);
                }
            
            }
            catch (Exception em) // excepcion de error en dado caso que pase
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
