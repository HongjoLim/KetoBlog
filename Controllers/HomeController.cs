using KetoBlog.Models;
using KetoBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IRepository<Posting> _postingRepo;

        public HomeController(ILogger<HomeController> logger, IRepository<Posting> postingRepo)
        {
            _logger = logger;
            _postingRepo = postingRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var postings = _postingRepo.GetAll();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
