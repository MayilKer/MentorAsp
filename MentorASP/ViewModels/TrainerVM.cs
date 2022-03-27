using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorASP.ViewModels
{
    public class TrainerVM
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Info { get; set; }
        public int CategoryId { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }



        public CategoryVM Category { get; set; }
    }
}
