//Write a pseudocode to store elements into a N * N matrix of integer. Display 
//whether it is an identity matrix or not. 
int i = 0;
int j = 0;
int order = 0;
int isIdentity = 0;
int[,] Matrix = new int[5, 5];
Console.Write("Enter the order for matrix: ");
order = int.Parse(Console.ReadLine());
Console.Write("Enter the elements of matrix: ");
for (i = 0; i < order; i++)
{
    for (j = 0; j < order; j++)
    {
        Matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("\nMatrix: ");
for (i = 0; i < order; i++)
{
    for (j = 0; j < order; j++)
    {
        Console.Write(Matrix[i, j] + "\t");

    }
    Console.WriteLine();
}
for (i = 0; i < order; i++)
{
    for (j = 0; j < order; j++)
    {
        if ((i == j && Matrix[i, j] != 1) || (i != j && Matrix[i, j] != 0))
        {
            isIdentity = 1;
            break;
        }
    }
}
if (isIdentity == 1)
    Console.WriteLine("Matrix is not an identity matrix");
else
    Console.WriteLine("Matrix is an identity matrix");