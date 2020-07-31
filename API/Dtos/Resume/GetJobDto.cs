using System;
using System.Collections.Generic;
using dotnetResume.Models;

namespace dotnetResume.Dtos.Resume
{
    public class GetJobDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}