//Write a pseudocode to accept name, empId, basic, special allowances, percentage of 
//bonus and monthly tax saving investments. The gross monthly salary is basic + special 
//allowances. Compute the annual salary. The gross annual salary also includes the bonus. 
//Compute the annual net salary, by deducting taxes as suggested. 
//Income upto 1 lac – exempted 
//Income from 1 to 1.5 lac – 20% 
//Income from 1.5 lac onwards – 30% 
//However if there is any tax saving investment, then there is further exemption of upto 1 
//lac annually.This would mean that by having tax saving investments of about 1 lac, an
//income of 2 lacs is non-taxable.Display the annual gross, annual net and tax payable.

int monthly_tax;
double net_annual_salary;
double tax;

Console.Write("Enter Your Name:");
string name = Console.ReadLine();
Console.Write("Enter Your Employee ID:");
string empid = Console.ReadLine();
Console.Write("Enter Your Basic Salary:");
int basic = int.Parse(Console.ReadLine());
Console.Write("Enter Your Special Allowances:");
int special_allowances = int.Parse(Console.ReadLine());
Console.Write("Enter Your Percentage of bonus:");
int percentage = int.Parse(Console.ReadLine());
Console.Write("Enter Your Saving Investment(Y/N):");
char saving_investment = char.Parse(Console.ReadLine());
int monthly_salary = basic + special_allowances;
int annual_salary = monthly_salary * 12;
int bonus = (annual_salary * percentage) / 100;
int gross_annual_salary = annual_salary + bonus;

Console.WriteLine();
Console.WriteLine($"Name:{name}");
Console.WriteLine($"Employee ID:{empid}");
Console.WriteLine($"Basic Salary:{basic}");
Console.WriteLine($"Special Allowances:{special_allowances}");
Console.WriteLine($"Bonus Percentage:{percentage}");
Console.WriteLine($"Saving Investment:{saving_investment}");
Console.WriteLine($"Monthly Salary:{monthly_salary}");
Console.WriteLine($"Annual Salary:{annual_salary}");
Console.WriteLine($"Bonus for {percentage}% for annual:{bonus}");
Console.WriteLine($"Gross Annual Salary:{gross_annual_salary}");

if (saving_investment == 'y' || saving_investment == 'Y')
{
    if (annual_salary <= 200000)
    {
        monthly_tax = 0;
        net_annual_salary = gross_annual_salary;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
    }
    else
    {
        monthly_tax = 20;
        net_annual_salary = gross_annual_salary - (annual_salary * 20) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");

    }
}
else
{
    if (annual_salary <= 100000)
    {
        monthly_tax = 0;
        net_annual_salary = gross_annual_salary;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");

    }
    else if (annual_salary > 100000 && annual_salary < 150000)
    {
        monthly_tax = 20;
        net_annual_salary = gross_annual_salary - (annual_salary * 20) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
    }
    else if (annual_salary > 150000)
    {
        monthly_tax = 30;
        net_annual_salary = gross_annual_salary - (annual_salary * 30) / 100;
        tax = gross_annual_salary - net_annual_salary;
        Console.WriteLine($"Tax Payable({monthly_tax}%):{tax}");
        Console.WriteLine($"Net Annual Salary:{net_annual_salary}");
    }
}