//Write a pseudocode to find the sum of all odd numbers from 1 to N. Accept N. Display the sum.

int sum = 0;
Console.WriteLine("Enter value of N");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i = i + 2)
{
    sum += i;
}
Console.WriteLine($"sum is {sum}");