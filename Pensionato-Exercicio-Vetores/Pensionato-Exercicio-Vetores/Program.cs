/*
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.
*/

using Pensionato_Exercicio_Vetores;

int op = 0;
int numeroEstudantesParaCadastrar = 0;
int numeroDeQuartos = 10;
Reserva[] reservas = new Reserva[numeroDeQuartos];

while (op != 3)
{
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1 - consultar");
    Console.WriteLine("2 - registrar");
    Console.WriteLine("3 - sair do sistema");
    Console.Write("escolha uma opcao: ");
    op = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------------------------------");

    switch (op)
    {
        case 1:
            functionConsulta();
            break;
        case 2:
            functionRegister();
            break;
        case 3:
            break;
        default:
            Console.WriteLine("opcao inexistente");
            break;
    }
}

void functionConsulta()
{
    Console.WriteLine("Listagem dos registrados");
    for (int i = 0; i < numeroDeQuartos; i++)
    {
        if (reservas[i] != null)
        {
            Console.WriteLine(reservas[i].ToString());
        }
    }
}

void functionRegister()
{
    Console.WriteLine("Preencha o formulario");
    Console.WriteLine();
    Console.WriteLine("Quantos estudantes: ");
    numeroEstudantesParaCadastrar = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < numeroEstudantesParaCadastrar; i++)
    {
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Email:");
        string email = Console.ReadLine();
        
        Console.WriteLine("Quarto:");
        int numeroQuarto = int.Parse(Console.ReadLine());
        while (reservas[numeroQuarto] != null)
        {
            Console.WriteLine("Esse quarto ja esta reservado, escolha outro");
            Console.WriteLine("Quarto:");
            numeroQuarto = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        reservas[numeroQuarto] = new Reserva
        {
            Nome = nome,
            Email = email,
            NumeroQuarto = numeroQuarto
        };
    }

    Console.WriteLine("Quartos cadastrados: ");
    for(int i = 0; i<numeroDeQuartos; i++)
    {
        if (reservas[i] != null)
        {
            Console.WriteLine(reservas[i].ToString());
        }
    }
}