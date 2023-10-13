using System;

Console.Write("Write down array`s count:\t");
int ElementCount = int.Parse(Console.ReadLine());
int NumberOfElements =0;

int finedNumbers(Array randomarray)
{
    foreach( int element in randomarray)
    {
        if (element > -100 && element < 100)
        {
            NumberOfElements++;
        }
    } 
    return NumberOfElements;
}

int[] Narray = new int[ElementCount];
for (int i = 0; i < Narray.Length; i++)
{
    Console.Write($"Write down {i+1} array`s element:\t");
    Narray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Number of elements from -100 to 100 is:\t{NumberOfElements = finedNumbers(Narray)}");
