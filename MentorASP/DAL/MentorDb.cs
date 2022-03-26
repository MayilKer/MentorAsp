using MentorASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorASP.DAL
{
    public class MentorDb : DbContext
    {
        public MentorDb(DbContextOptions<MentorDb> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<CourseTab> CourseTabs { get; set; }
    }
}
