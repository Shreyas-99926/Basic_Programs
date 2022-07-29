//Write as many pseudocodes to generate the following series. In all the following cases,
//accept N: 
//1, 4, 27, 256, 3125, … N
double val;
Console.Write("Enter N value:");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    val = Math.Pow(i, i);
    Console.Write($"{val} ");
    i++;
}