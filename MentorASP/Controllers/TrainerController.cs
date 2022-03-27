using MentorASP.DAL;
using MentorASP.Models;
using MentorASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorASP.Controllers
{
    public class TrainerController : Controller
    {
        private readonly MentorDb _contex;

        public TrainerController(MentorDb contex)
        {
            _contex = contex;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Trainers> trainers = await _contex.Trainers.Include(c => c.Category).OrderByDescending(i => i.Id).Take(6).ToListAsync();
            if (trainers == null) return BadRequest();
            return View(trainers);
        }

        public async Task<IActionResult> Load()
        {
            IEnumerable<TrainerVM> trainers = await _contex.Trainers.Include(c => c.Category).OrderByDescending(i => i.Id).Take(6)
                .Select(x => new TrainerVM 
                {
                    Id = x.Id,
                    Img = x.Img,
                    Facebook = x.Facebook,
                    Instagram = x.Instagram,
                    Twitter = x.Twitter,
                    LinkedIn =x.LinkedIn,
                    Info = x.Info,
                    Name = x.Name,
                    Surname = x.Surname,
                    Category = new CategoryVM
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name
                    }
                }).ToListAsync();
            return Json(trainers);
        }
    }
}
