/*
Fazer um programa para ler um número inteiro N e uma matriz de
ordem N contendo números inteiros. Em seguida, mostrar a diagonal
principal e a quantidade de valores negativos da matriz.
*/

Console.WriteLine("Defina o numero de linhas:");
int linha = int.Parse(Console.ReadLine());

Console.WriteLine("Defina o numero de colunas:");
int coluna = int.Parse(Console.ReadLine());

int[,] matriz = new int[linha, coluna];

for(int i = 0; i < linha; i++)
{
    for(int j = 0; j < coluna; j++)
    {
        Console.WriteLine("Define o numero da linha "+i+" e coluna "+j+":");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
for(int i =0; i < linha; i++)
{
    for(int j =0; j < coluna; j++)
    {
        Console.Write(matriz[i,j]+" ");
    }
    Console.WriteLine();
}

//DIAGONAL
Console.WriteLine();
Console.WriteLine("Diagonal:");

for(int i =0; i < linha; i++)
{
    Console.Write(matriz[i,i]+" ");
}

//NUMEROS NEGATIVOS
int qtNegativos = 0;
Console.WriteLine();
Console.WriteLine("Numeros negativos dentro da matriz:");

for( int i =0; i < linha; i++)
{
    for(int j =0; j < coluna; j++)
    {
        if (matriz[i,j] < 0)
        {
            qtNegativos += 1;
        }
    }
}

Console.WriteLine(qtNegativos);