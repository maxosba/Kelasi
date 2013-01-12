using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kelasi.Model
{
    public class Plan
    {
        public int PlanId {get; set;}
        public PlanTitle Title {get; set;}
        public string Description {get; set;}
        public Decimal Price {get; set;} 
    }
}
