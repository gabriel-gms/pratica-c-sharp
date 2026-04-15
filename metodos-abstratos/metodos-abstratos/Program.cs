/*
    Fazer um programa para ler os dados de N figuras (N fornecido
pelo usuário), e depois mostrar as áreas destas figuras na
mesma ordem em que foram digitadas.
*/

using metodos_abstratos.Entities;
using metodos_abstratos.Entities.Enums;

string format_shape;
Color color;

Console.Write("Quantos shapes?: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

List<Shape> list = new List<Shape>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Shape "+i);
    Console.WriteLine();
    Console.Write("Retangulo ou circulo (r/c): ");
    format_shape = Console.ReadLine();
    Console.Write("cor (black, blue, red): ");
    color = Enum.Parse<Color>(Console.ReadLine());

    if(format_shape == "r")
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Heigth: ");
        double height = double.Parse(Console.ReadLine());
        list.Add(new Rectangule(width, height, color));
    } else if (format_shape == "c")
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        list.Add(new Circle(radius, color));
    }
    Console.WriteLine();

}
    
Console.WriteLine("SHAPE AREAS:");
foreach(Shape shape in list)
{
    Console.WriteLine(shape.Area());
}