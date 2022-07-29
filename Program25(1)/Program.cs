//Write the pseudocodes to generate the following outputs. In all the following 
//cases, accept N: 
//1
//- 4 9
//- 16 25 - 36
//: 
//: 
//N rows 

int i, j, k, l;
int n;
Console.Write("Enter the value of n:");
n = int.Parse(Console.ReadLine());
Console.WriteLine();
l = 0;
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        l++;
        if (l % 2 == 0)
            Console.Write("-");
        Console.Write($"{Math.Pow(l, 2)} ");
    }
    Console.WriteLine();
}