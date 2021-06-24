using AlienspaceBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlienspaceAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _CategoriasBL;

        public CategoriasController()
        {
            _CategoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _CategoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }

        //[HttpGet]
        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();

            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria peliculas)
        {
            _CategoriasBL.GuardarCategoria(peliculas);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var peliculas = _CategoriasBL.ObtenerCategorias(id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Categoria peliculas)
        {
            _CategoriasBL.GuardarCategoria(peliculas);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var peliculas = _CategoriasBL.ObtenerCategorias(id);

            return View(peliculas);
        }

        public ActionResult Delete(int id)
        {
            var peliculas = _CategoriasBL.ObtenerCategorias(id);

            return View(peliculas);
        }

        [HttpPost]
        public ActionResult Delete(Categoria peliculas)
        {
            _CategoriasBL.EliminarCategorias(peliculas.Id);

            return RedirectToAction("Index");
        }
    }
}