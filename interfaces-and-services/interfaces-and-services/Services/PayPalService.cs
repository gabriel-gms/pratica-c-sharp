using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_and_services.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
