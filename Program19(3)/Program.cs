//Write the pseudocodes to generate the following series. In all the following cases, accept N:
//1, -2, 4, -6, 7,-10, 10,-14… N

int n;
Console.Write("Enter the value of n:");
n = int.Parse(Console.ReadLine());
int first = 1;
int second = 2;
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{first} ");
        first = first + 3;
    }
    else
    {
        Console.Write($"-{second} ");
        second = second + 4;
    }
}