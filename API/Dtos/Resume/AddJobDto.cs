using System;

namespace dotnetResume.Dtos.Resume
{
    public class AddJobDto
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}