// See https://aka.ms/new-console-template for more information
int[,] FillArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = new Random().Next(0, 10);
        }
    }
    return massive;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int row1 = Prompt("Количество строк первой матрицы: ");
int col1 = Prompt("Количество столбцов первой матрицы: ");
int row2 = Prompt("Количество строк второй матрицы: ");
int col2 = Prompt("Количество столбцов второй матрицы: ");

int[,] array1 = new int[row1, col1];
int[,] array2 = new int[row2, col2];

FillArray(array1);

PrintArray(array1);

Console.WriteLine(new string('-', 5));

FillArray(array2);

PrintArray(array2);

int[,] mulArray = new int[row1, col2];

for (int indexI = 0; indexI < mulArray.GetLength(0); indexI++)
{
    for(int indexJ = 0; indexJ < mulArray.GetLength(1); indexJ++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            mulArray[indexI,indexJ] += array1[indexI,j]*array2[j,indexJ];
        }
    }
}

Console.WriteLine(new string('-', 9));

PrintArray(mulArray);
