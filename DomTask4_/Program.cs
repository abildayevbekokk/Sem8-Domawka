// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(array[j,k,i]);
                Console.Write($"({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        
    }
}

int m = Prompt("Количество строк: ");
int n = Prompt("Количество столбцов: ");
int p = Prompt("Количество таблиц: ");
int[,,] array = new int[m,n,p];

for (int i = 0; i < array.GetLength(2); i++)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        for(int k = 0; k < array.GetLength(1); k++)
        {
            array[j,k,i] = new Random().Next(11, 100);
        }
    }
}

Loop:

for (int i = 0; i < array.GetLength(2); i++)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        for(int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[j,k,i] == array[j,k+1,i])
            {
                array[j,k+1,i]++;
                goto Loop;
            }
        }
    }
}

PrintArray(array);
