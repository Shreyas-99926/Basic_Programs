//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1 
//1 2
//6 24 120
//: 
//: 
//N rows 

int i, j, k, l;
l = 0;
int fact;
Console.Write("Enter the value of:");
int n = int.Parse(Console.ReadLine());
for (i = 0; i < n; i++)
{
    for (j = 0; j <= i; j++)
    {
        fact = 1;
        for (k = 1; k <= l; k++)
            fact = fact * k;
        Console.Write($"{fact} ");
        l++;
    }
    Console.WriteLine();
}