using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class Weight : Measurement
    {
        public double StartWeight { get; set; }

        public override void GetConversions(double amount, string type)
        {
            throw new NotImplementedException();
        }
    }
}
