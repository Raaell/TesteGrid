using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteGrid.Models;

namespace TesteGrid.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (ttt.t.Count == 0)
            {
                for (int i = 0; i < 99; i++)
                {
                    ttt.t.Add(new tt { id = i, banco = i * i, nome = "teste" + i });
                }
            }            

            return PartialView();
        }

        
        public ActionResult AtualizaGrid(string pesquisa, int pagina, GridView.Grid.range range)
        {
            var grid = new GridView.Grid { Pagina = pagina, Range = range, Registros = ttt.t.Where(x=>x.nome.Contains(pesquisa)).Select(x => new { ID = x.id, Banco = x.banco, Nome = x.nome }), urlRetorno = "/Home/AtualizaGrid/" };

            return PartialView(grid);
        }

        [HttpPost]
        public ActionResult t()
        {
            return Json(new { t = "tt" });
        }
    }

    public static class ttt
    {
        public static List<tt> t = new List<tt>();
    }
}