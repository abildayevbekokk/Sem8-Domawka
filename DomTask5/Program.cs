// See https://aka.ms/new-console-template for more information\
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            int sum = massive[i,j];
            if(sum<10) Console.Write($"0{sum} ");
            else Console.Write(sum + " ");
        }
        Console.WriteLine();
    }
}

void FillArraySpiral(int startCord, int count, int[,] array, int row, int col)
{
    if(row==0||col==0) return;

    
    for(int j = startCord; j < col; j++)
    {
        if(array[startCord,j] != 0) return;

        array[startCord,j] = count+1;
        count++;

        if (j==col-1)
        {
            for(int k = startCord+1; k < row; k++)
            {
                array[k,j] = count+1;
                count++;
            }
        }
    }   

    for(int j = col-2; j>=startCord; j--)
    {
        if(array[row-1,j] != 0) return;

        array[row-1, j] = count + 1;
        count++;
        
        if(j==startCord)
        {
            for(int k = row-2; k>startCord; k--)
            {
                array[k,j] = count+1;
                count++;
            }
        }
    }
    FillArraySpiral(startCord+1, count, array, row-1, col-1);
}

int row = Prompt("Количество строк: ");
int col = Prompt("Количество столбцов: ");
int [,] array = new int[row,col];

FillArraySpiral(startCord: 0, count: 0, array, row, col);

PrintArray(array);
