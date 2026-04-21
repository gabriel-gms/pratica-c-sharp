/*
    Um site de internet registra um log de acessos dos usuários. Um
registro de log consiste no nome de usuário e o instante em que o
usuário acessou o site no padrão ISO 8601, separados por espaço,
conforme exemplo. Fazer um programa que leia o log de acessos a
partir de um arquivo, e daí informe quantos usuários distintos
acessaram o site.
*/

SortedSet<string> logs = new SortedSet<string>();

Console.WriteLine("Enter with a path:");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            logs.Add(line);
        }
    }
} catch (IOException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Total users:");
int count = 0;
foreach(string log in logs)
{
    count++;
}
Console.WriteLine(count);