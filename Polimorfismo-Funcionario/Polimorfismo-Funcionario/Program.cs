/*
    Uma empresa possui funcionários próprios e terceirizados.
Para cada funcionário, deseja-se registrar nome, horas
trabalhadas e valor por hora. Funcionários terceirizados
possuem ainda uma despesa adicional.
O pagamento dos funcionários corresponde ao valor da hora
multiplicado pelas horas trabalhadas, sendo que os
funcionários terceirizados ainda recebem um bônus
correspondente a 110% de sua despesa adicional.
Fazer um programa para ler os dados de N funcionários (N
fornecido pelo usuário) e armazená-los em uma lista. Depois
de ler todos os dados, mostrar nome e pagamento de cada
funcionário na mesma ordem em que foram digitados.
*/

using Polimorfismo_Funcionario;

string name;
int hours;
double valuePerHour;
double additionalCharge;
List<Employee> listEmployeers = new List<Employee>();

Console.WriteLine("Quantos funcionarios voce vai cadastrar?:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.Write("Outsourced? (y/n): ");
    char resp = char.Parse(Console.ReadLine());
    Console.WriteLine();
    
    if(resp == 'y')
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Hours: ");
        hours = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Value per hour: ");
        valuePerHour = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Aditional charge: ");
        additionalCharge = int.Parse(Console.ReadLine());
        Console.WriteLine();

        listEmployeers.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
    }

    if(resp == 'n')
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Hours: ");
        hours = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Value per hour: ");
        valuePerHour = int.Parse(Console.ReadLine());
        Console.WriteLine();

        listEmployeers.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine("PAYMENTS:");
foreach(Employee employee in listEmployeers)
{
    Console.WriteLine(employee.Name+" - "+employee.Payment());
}