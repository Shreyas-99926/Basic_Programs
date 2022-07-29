//. Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1 
//2 2
//3 3 3
//4 4 4 4
//: 
//N rows

int i, j, rows;
Console.Write("Enter number of rows : ");
rows = int.Parse(Console.ReadLine());
for (i = 1; i <= rows; i++)
{
	for (j = 1; j <= i; j++)
		Console.Write("{0}", i);
	Console.Write("\n");
}