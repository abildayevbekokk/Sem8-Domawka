// See https://aka.ms/new-console-template for more information
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int countRow = Prompt("Введите количество: ");
int[][] superArray = new int[countRow][];
Console.WriteLine(new string(' ',countRow)+"1");
superArray[1] = new int[] {1,1};
Console.WriteLine(new string(' ',countRow-1)+"1 1");


int row = 2;

while(row < countRow)
{
    superArray[row] = new int[row+1];
    superArray[row][0] = 1;
    superArray[row][row] = 1;

    for (int i = 1; i <= row-1; i++)
    {
        superArray[row][i] = superArray[row-1][i-1]+superArray[row-1][i];
    }

    Console.Write(new string(' ',countRow-row));

    for (int j = 0; j < row+1; j++)
    {
        Console.Write(superArray[row][j] + " ");
    }

    Console.WriteLine();
       
    row++;
} 

