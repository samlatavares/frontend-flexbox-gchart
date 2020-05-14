using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioFrontEnd.Models;

namespace DesafioFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View("Atendimento");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Dados> RetornaDados()
        {
            int contador = 0;
            List<Dados> dados = new List<Dados>();
            Random random = new Random();

            while (contador < 10)
            {
                Dados dado = new Dados();
                dado.Id = contador;
                dado.Data = DateTime.Now.AddDays(contador);
                dado.Demanda = "Atendimento " + contador;
                dado.Desvio = random.Next(100);
                dado.Capacidade = random.Next(100);
                dado.AtendimentoPlanejado = random.Next(100);
                dado.AtendimentoRealizado = random.Next(100);
                dados.Add(dado);
                contador++;
            }
            return dados;
        }
    }
}
