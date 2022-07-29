//Write a pseudocode to store elements into a N * N matrix of integer. Display 
//whether it is a symmetric matrix or not.


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
int[,] transpose = new int[m, n];
for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		transpose[j, i] = array[i, j];
	}
}
Console.WriteLine();
Console.WriteLine("Martix elements are:");
for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write($"{array[i, j]} ");
	}
	Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Transpose martix elements are:");
for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write($"{transpose[i, j]} ");
	}
	Console.WriteLine();
}
if (m == n)
{
	int i, j;
	for (i = 0; i < m; i++)
	{
		for (j = 0; j < m; j++)
		{
			if (array[i, j] != transpose[i, j])
				break;
		}
		if (j != m)
			break;
	}

	if (i == m)
	{
		Console.WriteLine("It is an Symmetric matrix\n");
	}
	else
	{
		Console.WriteLine("It is not an Symmetric matrix\n");
	}
}
else
{
	Console.WriteLine("It is not an Symmetric matrix\n");
}
