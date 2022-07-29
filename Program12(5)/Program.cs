//Write as many pseudocodes to generate the following series. In all the following cases,
//accept N: 
//1, 4, 9, 25, 36, 49, 81, 100, … N

int i, n;
Console.Write("Enter the number of terms : ");
n = int.Parse(Console.ReadLine());
Console.Write("\nThe square natural upto {0} terms are :", n);
for (i = 1; i <= n; i++)
{
    Console.Write("{0}  ", i * i);
}