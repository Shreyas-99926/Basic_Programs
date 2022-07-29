//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//   * 
//  ***
// *****
//*******
//: 
//N rows 

int numberoflayer = 0, Space, Number;
Console.WriteLine("Enter the Number of layers");
numberoflayer = int.Parse(Console.ReadLine());
Console.WriteLine("Print paramid");
for (int i = 1; i <= numberoflayer; i++)
{
    for (Space = 1; Space <= (numberoflayer - i); Space++)
        Console.Write(" ");
    for (Number = 1; Number <= i; Number++)
        Console.Write('*');
    for (Number = (i - 1); Number >= 1; Number--)
        Console.Write('*');
    Console.WriteLine();
}