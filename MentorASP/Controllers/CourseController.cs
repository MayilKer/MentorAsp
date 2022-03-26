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
    public class CourseController : Controller
    {
        private readonly MentorDb _contex;

        public CourseController(MentorDb contex)
        {
            _contex = contex;
        }
        public IActionResult Index()
        {
            CourseVM courseVM = new CourseVM
            {
                Courses = _contex.Courses.Include(c => c.Category).Include(t => t.Trainer).OrderByDescending(i=>i.Id).ToList()
            };
            if (courseVM == null) return BadRequest();
            return View(courseVM);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();
            if (!_contex.Courses.Any(c => c.Id == id)) return BadRequest();
            CourseVM courseVM = new CourseVM
            {
                Courses = await _contex.Courses.Where(c => c.Id == id).Include(ca => ca.Category).Include(t => t.Trainer).ToListAsync()
            };
            return View(courseVM);
        }
    }
}
