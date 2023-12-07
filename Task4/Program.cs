int n = 4;
int m = 10;
int[,] arr = new int[n,m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i,j] = random.Next(-99,100);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

int minelement = int.MaxValue;
int minrow = -1;
int mincol = -1;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (arr[i,j] < minelement) 
        {
            minelement = arr[i,j];
            minrow = i;
            mincol = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент = {minelement} в строке {minrow}, колоке {mincol}");
int[,] newarr = new int[n-1, m-1];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i < minrow)
        {
            if (j < mincol)
            {
                newarr[i,j] = arr[i,j];
            }
            else if (j > mincol)
            {
                newarr[i, j-1] = arr[i,j];
            }
        }
        else if (i > minrow)
        {
            if (j < mincol)
            {
                newarr[i-1,j] = arr[i,j];
            }
            else if (j > mincol)
            {
                newarr[i-1, j-1] = arr[i,j];
            }
        }
    }
}

for (int i = 0; i < n-1; i++)
{
    for (int j = 0; j < m-1; j++)
    {
        Console.Write($"{newarr[i,j]} ");
    }
    Console.WriteLine();
}
