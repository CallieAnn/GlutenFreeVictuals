using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public abstract class Measurement
    {
        public int MeasurementId { get; set; }
        public string Type { get; set; }
        abstract public void GetConversions(double amount, string type);
        
    }
}
