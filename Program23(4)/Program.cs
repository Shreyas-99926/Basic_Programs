//Write the pseudocodes to generate the following outputs. In all the following cases, accept N:
//*
//**
//***
//****
//:
//N rows

Console.WriteLine("Enter number of rows :");
int rows = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= rows; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n");
}
Console.ReadLine();