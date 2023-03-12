using System;

namespace PruebaTravel.Models
{
    public class DetalleLibros
    {
        public DetalleLibros() { }

        public Int16 IdLibro { get; set; }
        public string Autor { get; set; }
        public string Sinopsis { get; set; }
        public string Editorial { get; set; }
        public string SedeEditorial { get; set; }
        public string Titulo { get; set; }
        public string Npaginas { get; set; }

    }
}
