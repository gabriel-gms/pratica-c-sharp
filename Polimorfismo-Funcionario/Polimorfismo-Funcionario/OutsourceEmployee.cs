using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_Funcionario
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge * 1.1;
        }

        public override double Payment() 
        {
            return base.Payment() + AdditionalCharge;
        }
    }
}
