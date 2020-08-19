using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Responsibility> Responsibilities {get;}
    }
}