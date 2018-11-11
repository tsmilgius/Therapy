using System;

namespace Therapy.Models
{
    public class Programme
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int TherapyDuration { get; set; }
        public int DwellDuration { get; set; }
        public int DwellCount { get; set; }
    }
}
