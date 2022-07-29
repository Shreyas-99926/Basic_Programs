// Write a pseudocode to accept two numbers. Display the two numbers. Swap the
// two numbers and display them again. (2ways)

int c = 0;
Console.Write("Enter the First Number:");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter the Second Number:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Before swap a= " + a + " b= " + b);
c = a;
a = b;
b = c;
Console.Write("After swap a= " + a + " b= " + b);