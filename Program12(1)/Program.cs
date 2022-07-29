//Write as many pseudocodes to generate the following series. In all the following cases,
//accept N: 
//4, 16, 36, 64, … N
Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i < number; i = i + 2)
{
    Console.WriteLine((i * i) + " ");
}
Console.WriteLine(" ");