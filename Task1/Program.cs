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

int[,] array = new int[5,6];

FillArray(array);

PrintArray(array);

for (int i = 0; i < array.GetLength(0); i+=array.GetLength(0)-1)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = 0;
        temp = array[i,j];
        array[i,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
}

Console.WriteLine(new string('-', 11));

PrintArray(array);