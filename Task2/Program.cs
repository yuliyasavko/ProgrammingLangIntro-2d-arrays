int n = 10;
int m = 10;
int[,] arr = new int[n,m];
Random random = new Random();
Console.WriteLine("До: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i,j] = random.Next(10,100);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

for (int k = 0; k < m; k++)
{
    int temp = arr[0,k];
    arr[0,k] = arr[n - 1,k];
    arr[n -1,k] = temp;
}

Console.WriteLine("После: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}