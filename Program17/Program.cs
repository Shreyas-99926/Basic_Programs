﻿//Write a pseudocode to display the 1st , 2nd , and 4th multiple of 7 which gives the 
//remainder 1 when divided by 2,3,4,5 and 6 
//Aproach - 1
int val, i;
int j = 1;
int k = 1;
int x = 1;
int flag;
int count = 0;
while (x <= 4)
{
    k = j * 7;
    flag = 0;
    for (i = 2; i <= 6; i++)
    {
        val = k % i;
        if (val == 1)
        {
            flag = flag + 1;
            if (flag == 5)
            {
                if (x == 1 || x == 2 || x == 4)
                    Console.WriteLine(k);
                x++;
            }
        }
        count++;
    }
    j++;
}
Console.WriteLine($"Loop count:{count}");
Console.WriteLine();

//Aproach - 2
i = 7;
count = 1;
int loopcount = 0;

while (count <= 4)
{
    loopcount++;
    if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
    {
        if (count != 3)
            Console.WriteLine(i);
        count++;
    }
    i = i + 7;
}
Console.WriteLine($"Loop count:{loopcount}");
Console.WriteLine();


//Aproach - 3
i = 7;
count = 1;
loopcount = 0;

while (count <= 4)
{
    loopcount++;
    if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
    {
        if (count != 3)
            Console.WriteLine(i);
        count++;
    }
    i = i + 14;
}
Console.WriteLine($"Loop count:{loopcount}");
Console.WriteLine();

//Aproach - 4
i = 7;
count = 1;
loopcount = 0;
while (count <= 4)
{
    loopcount++;
    if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
    {
        if (count != 3)
            Console.WriteLine(i);
        count++;
    }
    i = i + 21;
}
Console.WriteLine($"Loop count:{loopcount}");
Console.WriteLine();

//Aproach - 5
i = 7;
count = 1;
loopcount = 0;
while (count <= 4)
{
    loopcount++;
    if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
    {
        if (count != 3)
            Console.WriteLine(i);
        count++;
    }
    i = i + 42;
}
Console.WriteLine($"Loop count:{loopcount}");
Console.WriteLine();