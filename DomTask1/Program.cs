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

int[] ArraySortOneDimension(int[] massive)
{
    for (int j = 0; j < massive.Length-1; j++)
    {
        for (int i = 0; i < massive.Length-1; i++)
        {
            if (massive[i]<massive[i+1])
            {
                int temp = massive[i+1];  
                massive[i+1] = massive[i];
                massive[i] = temp;          
            }   
            }   
        }

    return massive;
}

int[,] array = new int[5,6];

FillArray(array);

PrintArray(array);

Console.WriteLine(new string('-', 11));

for (int i = 0; i < array.GetLength(0); i++)
{
    int[] odMassive = new int[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        odMassive[j] = array[i,j];
    }

    ArraySortOneDimension(odMassive);

    for (int k = 0; k < array.GetLength(1); k++)
    {
         array[i,k] = odMassive[k];
    }
}

PrintArray(array);

