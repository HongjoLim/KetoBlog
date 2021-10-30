using KetoBlog.Models;
using KetoBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Controllers
{
    public class PostingsController : Controller
    {
        private readonly IRepository<Posting> _postingsRepo;

        private readonly IRepository<Like> _likesRepo;

        private readonly IRepository<Comment> _commentsRepo;

        public PostingsController(IRepository<Posting> postingsRepo, IRepository<Like> likesRepo, IRepository<Comment> commentsRepo)
        {
            _postingsRepo = postingsRepo;
            _likesRepo = likesRepo;
            _commentsRepo = commentsRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var postings = _postingsRepo.GetAll();
            return View(postings);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Posting posting)
        {
            if (ModelState.IsValid)
            {
                posting.UserId = User.Identity.Name;
                posting.CreatedDateTime = DateTime.Now;
                posting.LastModifiedDateTime = posting.CreatedDateTime;
                _postingsRepo.Add(posting);
                _postingsRepo.SaveChanges();

                return RedirectToAction("Index");
            }
            else 
            {
                return View();
            }
        }
    }
}
