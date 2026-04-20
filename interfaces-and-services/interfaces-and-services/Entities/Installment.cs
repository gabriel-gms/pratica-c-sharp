using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace interfaces_and_services.Entities
{
    internal class Installment
    {

        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }   
}
