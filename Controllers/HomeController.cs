using KetoBlog.Models;
using KetoBlog.Models.ViewModels;
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
        private readonly IRepository<Posting> _postingRepo;
        private readonly IRepository<Recipe> _recipeRepo;
        private readonly IRepository<Food> _foodRepo;

        public HomeController(ILogger<HomeController> logger, IRepository<Posting> postingRepo, IRepository<Recipe> recipeRepo, IRepository<Food> foodRepo)
        {
            _logger = logger;
            _postingRepo = postingRepo;
            _recipeRepo = recipeRepo;
            _foodRepo = foodRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModels = new HomeViewModel { Postings = _postingRepo.GetAll().Take(3), Foods = _foodRepo.GetAll().Take(3), Recipes = _recipeRepo.GetAll().Take(3) };
            return View(viewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
