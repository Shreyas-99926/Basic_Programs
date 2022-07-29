//Write the pseudocodes to generate the following series. In all the following cases,
//accept N:
//1, 1, 2, 3, 5, 8, 13, … N 

int prv = 1, pre = 1, trm, i, n;
Console.Write("Enter the number of terms to be display : ");
n = int.Parse(Console.ReadLine());
Console.Write("Fibonacci Series \n", n);
Console.Write("{0}    {1}", prv, pre);
for (i = 3; i <= n; i++)
{
    trm = prv + pre;
    Console.Write("  {0}  ", trm);
    prv = pre;
    pre = trm;
}
Console.Write("\n");