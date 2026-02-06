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

Console.WriteLine(matriz);