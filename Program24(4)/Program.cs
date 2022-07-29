//Write the pseudocodes to generate the following outputs. In all the following cases, accept N: 
//1
//1 2
//3 5 8
//: 
//: 
//N rows

int prv = 1, pre = 1, trm, i, rows;
Console.Write("Enter the number of rows : ");
rows = int.Parse(Console.ReadLine());
Console.Write("{0}    {1}", prv, pre);
for (i = 1; i <= rows; i++)
{
    trm = prv + pre;
    Console.Write("  {0}  ", trm);
    Console.Write("\n");
    prv = pre;
    pre = trm;
    Console.Write("\n");
}