using AlienspaceBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlienspaceAdmin.Controllers
{
    public class MisPeliculasController : Controller
    {

        PeliculasBL _PeliculasBL;
        CategoriasBL _CategoriasBL;

        public MisPeliculasController()
        {
            _PeliculasBL = new PeliculasBL();
            _CategoriasBL = new CategoriasBL();
        }
        // GET: MisPeliculas
        public ActionResult Index()
        {
            var ListadePeliculas = _PeliculasBL.ObtenerPeliculas();

            return View(ListadePeliculas);
        }

        //[HttpGet]
        public ActionResult Crear()
        {
            var nuevaPelicula = new Peliculas();
            var categorias = _CategoriasBL.ObtenerCategorias();

            ViewBag.ListaCategorias = new SelectList(categorias, "Id", "Pelicula");
            return View(nuevaPelicula);
        }

        [HttpPost]
        public ActionResult Crear(Peliculas peliculas)
        {
            _PeliculasBL.GuardarPeliculas(peliculas);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var peliculas = _PeliculasBL.ObtenerPeliculas(id);
           // var categorias = _CategoriasBL.ObtenerCategorias();

           // ViewBag.CategoriaId = new SelectList(categorias, "Id", "Pelicula", peliculas.CategoriaId);

            return View(peliculas);
        }

        [HttpPost]
        public ActionResult Edit(Peliculas peliculas)
        {
            _PeliculasBL.GuardarPeliculas(peliculas);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var peliculas = _PeliculasBL.ObtenerPeliculas(id);

            return View(peliculas);
        }

        public ActionResult Delete(int id)
        {
            var peliculas = _PeliculasBL.ObtenerPeliculas(id);

            return View(peliculas);
        }

        [HttpPost]
        public ActionResult Delete(Peliculas peliculas)
        {
            _PeliculasBL.EliminarPeliculas(peliculas.Id);

            return RedirectToAction("Index");
        }
    }
}