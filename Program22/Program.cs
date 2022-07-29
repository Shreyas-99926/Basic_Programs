//Write a pseudocode to check if the string is a palindrome

Console.Write("Enter a String: ");
string name = Console.ReadLine();
string reverse = string.Empty;
for (int i = name.Length - 1; i >= 0; i--)
{
    reverse += name[i];
}
if (name == reverse)
{
    Console.WriteLine($"{name} is Palindrome.");
}
else
{
    Console.WriteLine($"{name} is not Palindrome");
}
Console.ReadLine();