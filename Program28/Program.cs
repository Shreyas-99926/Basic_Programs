//Write a pseudocode to store elements into a M * N matrix of integer. Display the 
//matrix and its transpose.

Console.Write("Enter number of rows:");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns:");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine($"Enter matrix elements for {m}*{n}:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Martix elements are:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Transpose martix elements are:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[j, i]} ");
    }
    Console.WriteLine();
}