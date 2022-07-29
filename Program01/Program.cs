// Write a pseudocode to accept principle, rate of interest and time. Calculate
//simple interest and display the same.


int year;
double principle, rate, interest, total_amt;
Console.Write("Enter The Loan Amount : ");
principle = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the Rate Of Interest : ");
rate = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter The Number of Years : ");
year = Convert.ToInt16(Console.ReadLine());
interest = principle * year * rate / 100;
total_amt = principle + interest;
Console.WriteLine("Total Amount : {0}", total_amt);
Console.ReadLine();