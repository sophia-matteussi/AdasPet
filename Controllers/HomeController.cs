using AdasPet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Controllers
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
            // Checa se o usuario tem seu cadastro completo
            // Se nao tiver ele vai ser redirecionado para completar
            //if (string.IsNullOrEmpty(HttpContext.Session.GetString("CadastroCompleto")))
            //{
            //    return Redirect("~/Identity/Account/CadastroCompleto");
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cachorros()
        {
            return View();
        }
        public IActionResult Gatos()
        {
            return View();
        }
        public IActionResult Passaros()
        {
            return View();
        }
        public IActionResult Peixes()
        {
            return View();
        }
        public IActionResult Coelhos()
        {
            return View();
        }
        public IActionResult Roedores()
        {
            return View();
        }
        public IActionResult Repteis()
        {
            return View();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////CACHORROS///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoCachorro()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosCachorros()
        {
            return View();
        }
        public IActionResult BrinquedosCachorros()
        {
            return View();
        }
        public IActionResult FarmaciaCachorros()
        {
            return View();
        }
        public IActionResult HigieneCachorros()
        {
            return View();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////GATOS///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoGatos()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosGatos()
        {
            return View();
        }
        public IActionResult BrinquedosGatos()
        {
            return View();
        }
        public IActionResult FarmaciaGatos()
        {
            return View();
        }
        public IActionResult HigieneGatos()
        {
            return View();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////PASSAROS///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoPassaros()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosPassaros()
        {
            return View();
        }
        public IActionResult BrinquedosPassaros()
        {
            return View();
        }
        public IActionResult FarmaciaPassaros()
        {
            return View();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////PEIXES///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoPeixes()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosPeixes()
        {
            return View();
        }
        public IActionResult FarmaciaPeixes()
        {
            return View();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////COELHOS///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoCoelhos()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosCoelhos()
        {
            return View();
        }
        public IActionResult BrinquedosCoelhos()
        {
            return View();
        }
        public IActionResult FarmaciaCoelhos()
        {
            return View();
        }
        public IActionResult HigieneCoelhos()
        {
            return View();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////ROEDORES///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoRoedores()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosRoedores()
        {
            return View();
        }
        public IActionResult BrinquedosRoedores()
        {
            return View();
        }
        public IActionResult FarmaciaRoedores()
        {
            return View();
        }
        public IActionResult HigieneRoedores()
        {
            return View();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////REPTEIS///////////////////////////////////////////////////
        ///
        public IActionResult AlimentacaoRepteis()
        {
            return View();
        }
        public IActionResult AcessoriosEquipamentosRepteis()
        {
            return View();
        }
      
        public IActionResult FarmaciaRepteis()
        {
            return View();
        }
        public IActionResult HigieneRepteis()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
