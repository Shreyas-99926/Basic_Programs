//A vendor offers software services to a client. Each resource is billed at some dollar rate 
//per hour.The total cost of the project for the client is therefore, the total number of
//hours contributed by all the vendor resources* the dollar rate / hour.

int cost = 0;
Console.Write("Enter the rate per hour:");
int rate = int.Parse(Console.ReadLine());
Console.Write("Enter the number of hours:");
int hours = int.Parse(Console.ReadLine());
Console.Write("Enter the Cost of hardware:");
int hardware = int.Parse(Console.ReadLine());
Console.Write("Enter the Cost of software:");
int software = int.Parse(Console.ReadLine());
Console.Write("Enter the hours of external consultant:");
int ext_consultant = int.Parse(Console.ReadLine());
Console.Write("Vendor goes loss for hardware (yes/no || 1/0):");
int client_hardware = int.Parse(Console.ReadLine());
Console.Write("Vendor goes loss for software (yes/no || 1/0):");
int client_software = int.Parse(Console.ReadLine());

int ip = (rate * hours) + hardware + software + (ext_consultant * hours);

if (client_hardware == 0 && client_software == 0)
    cost = (rate * hours) + hardware + software + (ext_consultant * hours);
else if (client_software == 0 && client_software == 1)
    cost = (rate * hours) + hardware * (3 / 10) + software + (ext_consultant * hours);
else if (client_software == 1 && client_software == 0)
    cost = (rate * hours) + hardware + software / 2 + (ext_consultant * hours);
else if (client_software == 1 && client_software == 1)
    cost = (rate * hours) + hardware * (3 / 10) + software / 2 + (ext_consultant * hours);

Console.WriteLine($"Cost: {cost}");

if (cost > ip)
    Console.WriteLine("Loss");
else
    Console.WriteLine("Profit");