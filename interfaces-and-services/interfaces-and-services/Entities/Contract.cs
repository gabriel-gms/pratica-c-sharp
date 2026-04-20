using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_and_services.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Double TotalValue { get; set; }

        public List<Installment> Installment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }
    }
}
