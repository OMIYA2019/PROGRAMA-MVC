using ProgramaModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramaModelBinder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente()
            {
                cliId = 23,
                cliNome = "Gizcreuza",
                cliEnd = "Rua Tá Difícil, 00",
                cliNasc = "23/05/1996 00:00:00"
            };
            return View(cliente);
        }

        public ActionResult Produto()
        {
            Produto produto = new Produto()
            {
                prodId = 1,
                prodNome = "Bom",
                prodValor = 149.99m,
                prodQtd = 100
            };
            return View(produto);
        }

        public ActionResult Venda()
        {
            Venda venda = new Venda()
            {
                vendaId = 100,
                vendaData = "28/02/2019 00:00:00",
                vendaTotal = 500m
            };
            return View(venda);
        }

       

    }
}