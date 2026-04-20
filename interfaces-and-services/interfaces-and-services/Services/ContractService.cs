using System;
using System.Collections.Generic;
using System.Text;
using interfaces_and_services.Entities;

namespace interfaces_and_services.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) 
        {
            double baseValuePerInstallment = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double firstTax = _onlinePaymentService.Interest(baseValuePerInstallment, i) + baseValuePerInstallment;
                double totalPayment = _onlinePaymentService.PaymentFee(firstTax) + firstTax;
                contract.Installment.Add(new Installment(date, totalPayment));
            }
        }
    }
}
