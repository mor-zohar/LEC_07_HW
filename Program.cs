// See https://aka.ms/new-console-template for more information

int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
int temp;
Console.WriteLine("FROM SMALL TO BIG:\n-------------------\n");

for(int i = 0; i < intArray.Length; i++)
{
    for(int j = i+1; j < intArray.Length; j++)
    {
        if(intArray[i] > intArray[j])
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }

    }
}
foreach(int value in intArray)
{
    Console.WriteLine(value + " ");
}

Console.WriteLine("\nFROM BIG TO SMALL:\n-------------------\n");
for (int i = 0; i < intArray.Length; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] < intArray[j])
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}
foreach (int value in intArray)
{
    Console.WriteLine(value + " ");
}