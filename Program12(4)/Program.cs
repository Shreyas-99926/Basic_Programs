// Write as many pseudocodes to generate the following series. In all the following cases, accept N: 
//1, 4, 7, 12, 23, 42, 77, … N

int i = 4;
int value = 1;
int f1 = 3;
int f2 = 3;
int f3 = 5;
int temp;
Console.Write("Enter N value:");
int n = int.Parse(Console.ReadLine());
Console.Write($"{value} ");
value = value + f1;
Console.Write($"{value} ");
value = value + f2;
Console.Write($"{value} ");
value = value + f3;
Console.Write($"{value} ");

while (i <= n)
{
    temp = f3;
    value = value + f1 + f2 + f3;
    Console.Write($"{value} ");
    f3 = f1 + f2 + f3;
    f1 = f2;
    f2 = temp;
    i++;
}