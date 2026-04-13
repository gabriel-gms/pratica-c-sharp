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