//Write the pseudocodes to generate the following outputs. In all the following cases, accept N:
//    *
//   **
//  ***
// ****
//:
//N rows

Console.WriteLine("Enter number of Rows :");
int rows = int.Parse(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = rows - i; j >= 1; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n");
}
Console.ReadLine();