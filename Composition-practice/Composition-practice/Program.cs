/*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
(próxima página).
*/

using Composition_practice.Entities;
using Composition_practice.Entities.Enums;

Console.WriteLine("Add departament the worker:");
string departamentWrite = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Add Name:");
string nameWrite =  Console.ReadLine();
Console.WriteLine();

Console.WriteLine("What is the level:");
string levelWrite = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Define the base salary:");
double salaryWrite = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("How many contracts:");
int quantityContract =  int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Clear();

Departament departament = new Departament() { Name = departamentWrite };
Worker worker = new Worker()
{
    Name = nameWrite,
    Level = Enum.Parse<WorkerLevel>(levelWrite.ToUpper()),
    BaseSalary = salaryWrite
};
HourContract[] hourContract = new HourContract[quantityContract];

worker.AddContract(hourContract);

Console.Clear();

Console.WriteLine("Insert the month and year to calculate income:");
DateTime dataIncome = DateTime.Parse(Console.ReadLine());
Console.WriteLine();


