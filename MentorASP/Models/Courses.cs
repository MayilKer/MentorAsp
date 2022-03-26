using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorASP.Models
{
    public class Courses
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Img { get; set; }
        public double Price { get; set; }
        public int AvailableSeats { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
        public Nullable<int> TrainerId { get; set; }
        public Nullable<int> CategoryId { get; set; }

        public Category Category { get; set; }

        public Trainers Trainer { get; set; }
    }
}
