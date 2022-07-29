//Write as many pseudocodes to generate the following series. In all the following cases,
//accept N:
//1, -2, 3, -4, 5, -6, … N 

int i, n;
Console.Write("Enter the number of terms : ");
n = int.Parse(Console.ReadLine());
for (i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("{0}  ", -i);
    }
    else
    {
        Console.Write("{0}  ", i);
    }
}