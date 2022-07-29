// Write a pseudocode to do the following: 
//Accept the item code, description, qty and price of an item. Compute the total for the item.
//Accept the user’s choice. If the choice is ‘y’ then accept the next set of inputs for 
//a new item and compute the total. In this manner, compute the grand total for all 
//the items purchased by the customer. 
//If the grand total is more than Rs. 10,000/- then, the customer is allowed a discount of 10%.
//If the grand total is less than Rs. 1,000/- and the customer chooses to pay by card, 
//then a surcharge of 2.5% is levied on the grand total. 
//Display the grand total for the customer. 

int item_code;
string description;
int quantity;
int price;
char choice;
int no_of_items = 0;
int total_price = 0;
double Grand_price;
char choice1;
do
{
    Console.Write("Enter the item code:");
    item_code = int.Parse(Console.ReadLine());

    Console.Write("Enter the Description:");
    description = Console.ReadLine();

    Console.Write("Enter the Quantity:");
    quantity = int.Parse(Console.ReadLine());

    Console.Write("Enter the Price:");
    price = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine($"Item code:{item_code}");
    Console.WriteLine($"Description:{description}");
    Console.WriteLine($"Quantity:{quantity}");
    Console.WriteLine($"Price:{price}");

    total_price = total_price + price;
    no_of_items++;

    Console.WriteLine($"No of Items:{no_of_items}");
    Console.WriteLine($"Total Price:{total_price}");
    Console.WriteLine();

    Console.Write("Enter y/n for add item:");
    choice = char.Parse(Console.ReadLine());
    Console.WriteLine();

} while (choice == 'y' || choice == 'Y');

if (total_price > 10000)
{
    Console.WriteLine("Discount:10%");
    Grand_price = total_price - (total_price * 0.1);
    Console.WriteLine($"Grand Price: {Grand_price}");
}
else if (total_price < 1000)
{
    Console.Write("Enter y/n for pay by card:");
    choice1 = char.Parse(Console.ReadLine());
    if (choice1 == 'y' || choice1 == 'Y')
    {
        Console.WriteLine("Surcharge(Extra):2.5%");
        Grand_price = total_price + (total_price * 0.025);
        Console.WriteLine($"Grand Price: {Grand_price}");
    }
    else
        Console.WriteLine($"Grand Price: {total_price}");
}
else
    Console.WriteLine($"Grand Price: {total_price}");