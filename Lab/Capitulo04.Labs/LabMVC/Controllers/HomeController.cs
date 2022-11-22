using LabMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarErro()
        {
            ViewBag.MensagemErro = "Erro interno do servidor";
            return View("_Erro");
        }

        public ActionResult ListarSuppliers()
        {
            var db = new NorthwindEntities();
            return View(db.Suppliers.ToList());
        }

        public ActionResult ListarProdutos()
        {
            var db = new ProdutoContainer();
            return View(db.ProdutosSet.ToList());
        }

        public String CriarCategoria()
        {

            var db = new LojaContext();
            var c = new LabMVC.Models.Categoria() { Nome = "Eletrodomésticos" };
            db.Categorias.Add(c);
            db.SaveChanges();
            return "Salvo com suceso.";
        }
    }
}