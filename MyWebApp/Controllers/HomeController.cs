using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.DataAccess;

namespace MyWebApp.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Home")]
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }


        public IActionResult Index()
        {
            return View(_produtoRepository.List());
        }
    }
}