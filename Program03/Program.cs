//Write a pseudocode to accept a number and display whether it is an even or
//odd number

Console.WriteLine("Enter a Number");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"{a}  is even");
}
else
{
    Console.WriteLine($"{a}  is odd");
}