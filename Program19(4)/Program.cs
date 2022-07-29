//Write the pseudocodes to generate the following series. In all the following cases, accept N: 
//1, 5, 8, 14, 27, 49, … N 

Console.Write("Enter the value of n:");
int n = int.Parse(Console.ReadLine());
int first = 1, second = 5;
int temp;
int third = 8;
Console.Write($"{first} ");
for (int i = 0; i < n; i++)
{
    temp = third;
    Console.Write($"{second} ");
    third = first + second + third;
    first = second;
    second = temp;
}
Console.WriteLine();