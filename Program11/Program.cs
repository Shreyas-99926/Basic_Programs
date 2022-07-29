//Write a pseudocode to display a number in words. 
//Ex. 270176 
//Output: Two Seven Zero One Seven Six 

int number;
int nextDigit;
int numDigits;
int[] n = new int[20];
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
Console.WriteLine("Enter the number");
number = int.Parse(Console.ReadLine());
Console.WriteLine("Number: " + number);
Console.Write("Number in words: ");
nextDigit = 0;
numDigits = 0;
do
{
    nextDigit = number % 10;
    n[numDigits] = nextDigit;
    numDigits++;
    number = number / 10;
} while (number > 0);
numDigits--;
for (; numDigits >= 0; numDigits--)
    Console.Write(digits[n[numDigits]] + " ");