//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//*****
//*****
//*****
//*****
//: 
//N rows

Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());
int val = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
}
Console.WriteLine("");