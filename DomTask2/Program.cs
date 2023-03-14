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

int m = Prompt("Количество строк: ");
int n = Prompt("Количество столбцов: ");
int[,] array = new int[m,n];

FillArray(array);

PrintArray(array);

int[] arrayOfSums = new int[m];

for(int i = 0; i < array.GetLength(0); i++)
{
    int sumOfRow = 0;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumOfRow+=array[i,j];
    }

    arrayOfSums[i] = sumOfRow;
}

int min = arrayOfSums[0];
int cord = 0;

for(int i = 1; i < arrayOfSums.Length; i++)
{
    if(min > arrayOfSums[i]) 
    {
        min = arrayOfSums[i];
        cord = i;
    }
}

Console.WriteLine($"Наименьшая сумма элементов на строке {cord+1}");

