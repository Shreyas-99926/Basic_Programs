//Write a pseudocode to accept a student’s name and scores in three subject. Display the average and total.
//Display whether the student has secured 1st, 2nd, pass class or hasfailed. 1st class is for a score of 60
//and above,2nd is for a score of 50 and above, while pass class is for a score of 35 and above.
//If the score is less than 35, then the student fails.


Console.WriteLine("Enter name of student");
string name = Console.ReadLine();
Console.WriteLine("Enter subject 1 score");
int sub1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter subject 2 score");
int sub2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter subject 3 score");
int sub3 = int.Parse(Console.ReadLine());
int total = sub1 + sub2 + sub3;
Console.WriteLine($"The total Marks obtained is: {total}");
float avg = total / 3;
Console.WriteLine($"The Average is: {avg}");
if (sub1 >= 35 && sub2 >= 35 & sub3 >= 35 && avg >= 60)
{
    Console.WriteLine($"{name} has obtained first class");
}
else if (sub1 >= 35 && sub2 >= 35 & sub3 >= 35 && avg >= 50 && avg < 60)
{
    Console.WriteLine($"{name} has obtained second class");
}
else if (sub1 >= 35 && sub2 >= 35 & sub3 >= 35 && avg >= 35 && avg < 50)
{
    Console.WriteLine($"{name} has obtained third class");
}
else
{
    Console.WriteLine($"{name} has failed");
}