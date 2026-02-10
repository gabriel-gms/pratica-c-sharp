using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_practice.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValueToHour { get; set; }
        public int Hours { get; set; }

        public Double TotalValue()
        {
            return ValueToHour * Hours; 
        }
    }
}
