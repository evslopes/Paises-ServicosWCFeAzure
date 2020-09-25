using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Consumir.ApiServices;
using MVC.Consumir.Models;

namespace MVC.Consumir.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPaisApi PaisApi;
        private readonly IEstadoApi EstadoApi;

        public HomeController(ILogger<HomeController> logger, IEstadoApi estadoApi, IPaisApi paisApi)
        {
            _logger = logger;
            EstadoApi = estadoApi;
            PaisApi = paisApi;
        }

        public async Task<IActionResult> Index()
        {
            var paginaInicial = new PaginaInicialViewModel();

            var paises = await PaisApi.GetPaises();
            paginaInicial.QuantidadeDePaises = paises.Count;

            var estados = await EstadoApi.GetEstados();
            paginaInicial.QuantidadeDeEstados = estados.Count;

            return View(paginaInicial);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
