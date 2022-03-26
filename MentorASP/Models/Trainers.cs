using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MentorASP.Models
{
    public class Trainers
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Img { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(1000)]
        public string Info { get; set; }
        public int CategoryId { get; set; }
        [StringLength(1000)]
        public string Twitter { get; set; }
        [StringLength(1000)]
        public string Facebook { get; set; }
        [StringLength(1000)]
        public string Instagram { get; set; }
        [StringLength(1000)]
        public string LinkedIn { get; set; }
        public IEnumerable<Courses> Courses { get; set; }


        public Category Category { get; set; }

    }
}
