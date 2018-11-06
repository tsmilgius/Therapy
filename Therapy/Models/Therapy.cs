using System;

namespace Therapy.Models
{
    public class TherapyEntity
    {
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public int TherapyDuration { get; set; }
        public int DwellDuration { get; set; }
        public int DwellCount { get; set; }

    }
}
