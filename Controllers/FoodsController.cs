using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Controllers
{
    public class FoodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
