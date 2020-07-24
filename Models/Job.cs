using System;
using System.Collections.Generic;

namespace dotnetResume.Models{
    class Job{
        public int Id {get; set;}
        public string Title{get; set;}
        public string Company{get; set;}
        public DateTime Start{get; set;}
        public DateTime End {get; set;}
        public string Location{get; set;}
        public ICollection<Responsibility> Responsibilities { get; set; } = new List<Responsibility>();
    }
}