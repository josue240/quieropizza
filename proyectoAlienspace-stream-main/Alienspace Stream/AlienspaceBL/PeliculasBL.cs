using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienspaceBL
{
    public class PeliculasBL
    {
        Contexto contexto_global;
        public List<Peliculas> ListadePeliculas { get; set; }

        public PeliculasBL()
        {
            contexto_global = new Contexto();
            ListadePeliculas = new List<Peliculas>();
        }


        public List<Peliculas> ObtenerPeliculas()
        {

            // contexto_global.Peliculas.ToList();

            /* var pelicula1 = new Peliculas();
             pelicula1.Id = 1;
             pelicula1.Pelicula = "Transformes: Revenge of the Fallen";

             var pelicula2 = new Peliculas();
             pelicula2.Id = 2;
             pelicula2.Pelicula = "Avengers: Infiniy War";

             var pelicula3 = new Peliculas();
             pelicula3.Id = 3;
             pelicula3.Pelicula = "Castlevania";

             var pelicula4 = new Peliculas();
             pelicula4.Id = 4;
             pelicula4.Pelicula = "Godzilla: King of the Monsters";

             var pelicula5 = new Peliculas();
             pelicula5.Id = 5;
             pelicula5.Pelicula = "Kimetsu no Yaiba";

             var pelicula6 = new Peliculas();
             pelicula6.Id = 6;
             pelicula6.Pelicula = "Al filo del mañana";

             var ListaPeliculas = new List<Peliculas>();
             ListaPeliculas.Add(pelicula1);
             ListaPeliculas.Add(pelicula2);
             ListaPeliculas.Add(pelicula3);
             ListaPeliculas.Add(pelicula4);
             ListaPeliculas.Add(pelicula5);
             ListaPeliculas.Add(pelicula6);*/

            ListadePeliculas = contexto_global.Peliculas.ToList();
            return ListadePeliculas; //ListaPeliculas;
        }
    }
 }

