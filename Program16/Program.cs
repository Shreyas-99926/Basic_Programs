// Write a pseudocode to accept a binary number and display it in the decimal form.

string answer;
string result;
Console.Write("Enter a Number To Convert: ");
answer = Console.ReadLine();
int num = int.Parse(answer);
result = "";
while (num > 1)
{
    int remainder = num % 2;
    result = Convert.ToString(remainder) + result;
    num /= 2;
}
result = Convert.ToString(num) + result;
Console.WriteLine("Binary: {0}", result);