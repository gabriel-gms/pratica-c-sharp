using System;
using System.Collections.Generic;
using System.Text;
using exception.Execptions;

namespace exception.Entities
{
    internal class Account
    {
        public int Number;
        public string Holder;
        public double Balance;
        public double WithdrawLimit;

        public Account(int number, string holder, double balance, double withdrawLimit) 
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(Balance <= 0)
            {
                throw new DomainException("saldo da conta igual a zero, não é possivel fazer o saque.");
            }

            if(amount > WithdrawLimit)
            {
                throw new DomainException("O saque requisitado é maior que o limite de saque disponivel");
            }

            if(amount > Balance)
            {
                throw new DomainException("Não é possivel tirar essa quantia pois ela é maior que seu saldo");
            }

            Balance -= amount;
        }
    }
}
