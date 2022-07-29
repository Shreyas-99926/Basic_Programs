//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1 2 3 4 5
//1 2 3 4 5
//1 2 3 4 5
//1 2 3 4 5
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
        val += 1;
        Console.Write(val);
    }
    val = 0;
}