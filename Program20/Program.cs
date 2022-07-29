// Write a pseudocode to find Xn (x to the power of n). Accept X and n. Display the result.

int temp, pow = 1;
Console.WriteLine("Enter the value of X(base) and n(power):");
int x = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
temp = n;
while (temp != 0)
{
    pow = pow * x;
    temp--;
}
Console.WriteLine($"{x} to the power of {n} is: {pow}");