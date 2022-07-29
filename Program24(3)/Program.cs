//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1
//2 3
//4 5 6
//7 8 9 10
//: 
//N rows 

int i, j, rows, k = 1;
Console.Write("Enter number of rows : ");
rows = int.Parse(Console.ReadLine());
for (i = 1; i <= rows; i++)
{
	for (j = 1; j <= i; j++)
		Console.Write("{0} ", k++);
	Console.Write("\n");
}