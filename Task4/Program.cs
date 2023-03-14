// See https://aka.ms/new-console-template for more information
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];

FillArray(array);

PrintArray(array);

int min = array[0,0];
int indexI = 0;
int indexJ = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if(min > array[i,j]) 
        {
            min = array[i,j];
            indexI = i;
            indexJ = j;
        }
    }
}

Console.WriteLine(min);

int[,] newArray = new int[3,3];
int indexa = 0;
int indexb = 0;

for (int i = 0; i < 4; i++)
{
    if (i == indexI) continue;

    for (int j = 0; j < 4; j++)
    {
        if (j == indexJ) continue;

        newArray[indexa,indexb] = array[i,j];
        indexb++;
    }

    indexa++;
    indexb = 0;
}

PrintArray(newArray);
