//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1 1 1 1 1
//2 2 2 2 2
//3 3 3 3 3
//4 4 4 4 4
//: 
//N rows 
Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());
int val = 0;
for (int i = 1; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        Console.Write(i);
    }
}