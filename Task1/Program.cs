int n = 10;
int m = 10;
int[,] arr = new int[n,m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i,j] = random.Next(0,100);
    }
}
Console.WriteLine($"Введите номер сторки (от 0 до {n}): ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите номер столбца (от 0 до {m}): ");
int col = int.Parse(Console.ReadLine());
if (row >= 0 && row < n && col >= 0 && col < m)
{
    Console.WriteLine($"Элемент в позиции ({row}, {col}) = {arr[row,col]}");
}
else
{
    Console.WriteLine("Такого элемента не существует");
} 
