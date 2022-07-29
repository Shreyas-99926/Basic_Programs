//Write a pseudocode to find the reverse of a number. Store the reverse value
//in a different variable. Display the reverse.

int rev = 0;
int rem;
int i = 0;
Console.WriteLine("enter a number");
int num = int.Parse(Console.ReadLine());
while (num != 0)
{
    rem = num % 10;
    rev = rev * 10 + rem;
    num = num / 10;
}
Console.WriteLine("Reverse of the given number is" + rev);