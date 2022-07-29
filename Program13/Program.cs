//Write a pseudocode to find the sum of all the prime numbers in the range n to m. 
//Display each prime number and also the final sum.
int sum = 0;
int flag, l = 0;

Console.WriteLine("Enter the Starting range of prime numbers:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Ending range of prime numbers:");
int m = int.Parse(Console.ReadLine());
Console.Write("Prime Numbers are: ");
for (int j = n; j <= m; j++)
{
    flag = 0;
    l = j / 2;
    for (int i = 2; i <= l; i++)
    {
        if ((j % i) == 0)
        {
            flag = 1;
            break;
        }
    }
    if (flag == 0)
    {
        Console.Write($"{j} ");
        sum = sum + j;
    }
}
Console.Write($"\nThe Sum of all the Prime Numbers in the range {n} to {m} is: {sum} ");