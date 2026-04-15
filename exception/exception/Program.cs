/*
     Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta.
*/

using exception.Entities;
using exception.Execptions;

try
{
    Console.WriteLine("----ENTER ACCOUNT DATA----");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit =  double.Parse(Console.ReadLine());
    Console.WriteLine();

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("New balance:");
    account.WithDraw(amount);
    Console.WriteLine(account.Balance);
} 
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
