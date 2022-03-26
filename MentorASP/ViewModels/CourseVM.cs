using MentorASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorASP.ViewModels
{
    public class CourseVM
    {
        public List<Courses> Courses { get; set; }
        public List<Category> Categories { get; set; }
        public List<Trainers> Trainers { get; set; }
    }
}
