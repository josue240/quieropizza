using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienspaceBL
{
   public class Peliculas
    {
        public int Id { get; set; }
        public string Pelicula { get; set; }
        public  Categoria Categoria { get; set; }
        //public int CategoriaId { get; set; }
    }
}
