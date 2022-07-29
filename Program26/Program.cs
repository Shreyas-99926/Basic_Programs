//Write a pseudocode to store N elements in an array of integer. Display the 
//elements.Accept a number to be searched. Display whether the number is found 
//or not in the array (LINEAR SEARCH). 
int[] a = new int[100];
Console.WriteLine("Enter number of elements you want to store:");
string s = Console.ReadLine();
int x = int.Parse(s);
Console.WriteLine("\n Enter array elements ");
for (int i = 0; i < x; i++)
{
    string s1 = Console.ReadLine();
    a[i] = int.Parse(s1);
}
Console.WriteLine("Enter Search element:");
string s3 = Console.ReadLine();
int x2 = int.Parse(s3);
for (int i = 0; i < x; i++)
{
    if (a[i] == x2)
    {
        Console.WriteLine("Search successful");
        Console.WriteLine("Element {0} found at location {1}\n", x2, i + 1);
        return;
    }
}
Console.WriteLine("Search unsuccessful");