//Write a pseudocode to find the largest and second largest of 3 numbers.

int a;
int[] arr = { 54, 45, 65, 10, 25 };
int cnt = arr.Length;
for (int i = 0; i < cnt; i++)
{
    for (int j = i + 1; j < cnt; j++)
    {
        if (arr[i] > arr[j])
        {
            a = arr[i];
            arr[i] = arr[j];
            arr[j] = a;
        }
    }
}
Console.WriteLine("Largest: " + arr[cnt - 1]);
Console.WriteLine("Second Largest: " + arr[cnt - 2]);