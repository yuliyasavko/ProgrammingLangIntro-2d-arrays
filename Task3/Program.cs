int n = 4;
int m = 10;
int[,] arr = new int[n,m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i,j] = random.Next(10,100);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

int minsum = -1;
int minrow = -1;
for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
       sum = sum + arr[i,j];
    }
    Console.WriteLine($"Сумма строки {i} = {sum}");

    if (minsum == -1 || sum < minsum) 
    {
        minsum = sum;
        minrow = i;
    }
}
Console.WriteLine($"Минимальная сумма = {minsum} в строке {minrow}");
Console.WriteLine($"Строка с минимальной суммой : ");
for (int k = 0; k < m; k++)
{
    Console.Write($"{arr[minrow, k]} ");

}
Console.WriteLine();
