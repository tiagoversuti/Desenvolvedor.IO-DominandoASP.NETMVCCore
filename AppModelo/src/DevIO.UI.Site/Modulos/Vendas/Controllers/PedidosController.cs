using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers
{
    public class PedidosController : Controller
    {
        [Area("Vendas")]
        public IActionResult Index()
        {
            return View();
        }
    }
}