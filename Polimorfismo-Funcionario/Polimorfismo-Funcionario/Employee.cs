using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_Funcionario
{
    internal class Employee
    {
        public string Name {  get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee(string name, int hours, double valuePerHours) 
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHours;
        }

        public virtual double Payment() 
        { 
            return ValuePerHour * Hours;
        }
    }
}
