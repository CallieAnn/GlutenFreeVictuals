using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class Volume : Measurement
    {
        public double StartVolume { get; set; }
        public override void GetConversions(double amount, string type)
        {
            throw new NotImplementedException();
        }
    }
}
