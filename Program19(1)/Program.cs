//Write the pseudocodes to generate the following series. In all the following cases,accept N: 
//1, -2, 6, -15, 31, -56, … N

int n;
Console.Write("Enter the value of n:");
n = int.Parse(Console.ReadLine());

Console.WriteLine();
double val = 1;
for (int i = 0; i < n; i++)
{
    val = val + Math.Pow(i, 2);
    if (i % 2 == 0)
        Console.Write($"{val} ");
    else
        Console.Write($"-{val} ");
}