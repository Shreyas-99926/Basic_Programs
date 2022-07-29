//Write as many pseudocodes to generate the following series. In all the following cases,accept N: 
//1, 5, 13, 29, 49, 77, … N
double val;
int i, j;
Console.Write("Enter the value of N:");
int n = int.Parse(Console.ReadLine());
i = 1;
val = 1;
while (i <= n)
{

    if (i % 3 != 0)
    {
        Console.Write($"{val} ");
        val = val + i * 4;
    }
    i++;
}