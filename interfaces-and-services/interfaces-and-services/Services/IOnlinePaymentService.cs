using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_and_services.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
