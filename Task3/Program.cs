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
void PrintArray1(int[] massive)
{
        for (int i = 0; i < massive.Length; i++)
        {
            Console.Write(massive[i] + " ");
        }
        Console.WriteLine();
}
int m = 3;
int n = 4;
int[,] massive = new int[m,n];
FillArray(massive);
PrintArray(massive);

int[] newMassive = new int[m*n];
int index = 0;
foreach(int element in massive)
{
    newMassive[index] = element;
    index++;
}

PrintArray1(newMassive);

for (int j = 0; j < newMassive.Length-1; j++)
{
    for (int i = 0; i < newMassive.Length-1; i++)
    {
    if (newMassive[i]>newMassive[i+1])
    {
        int temp = newMassive[i+1];  
        newMassive[i+1] = newMassive[i];
        newMassive[i] = temp;          
    }
    }
}

PrintArray1(newMassive);
int count = 1;
int elem = newMassive[0];
for (int i = 1; i < newMassive.Length; i++)
{
    if (elem == newMassive[i])
        count++;
    else
    {
        Console.WriteLine($"Число {elem} встречается в массиве {count} раз");
        elem = newMassive[i];
        count = 1;
    } 
}
Console.WriteLine($"Число {elem} встречается в массиве {count} раз");