using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Therapy.Models
{
    public class Bag
    {
        public int Id { get; set; }
        public string Type { get; set; } //Glucose //Nutrineal
        public float Concentration { get; set; }
        public int Volume { get; set; }
    }
}
