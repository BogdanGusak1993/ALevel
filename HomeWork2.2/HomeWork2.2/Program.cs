using System;

int[] aArray = new int[20];
int[] bArray = new int[20];
int min, max, count;
count = 0;
Console.Write("Write down Min value for number range:\t");
min = Convert.ToInt32(Console.ReadLine());
//Int32.TryParse(Console.ReadLine(), out min);
Console.Write("Write down Max value for number range:\t");
max = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 20; i++)
{
    switch (i)//Використав switch для практики 
    {
        case 0:
            aArray[i] = new Random().Next(min, max);
            Console.WriteLine("Array A[20]:");
            Console.WriteLine($"Element number{i + 1}:\t{aArray[i]}");
            break;
        case > 0 and < 19:
            aArray[i] = new Random().Next(min, max);
            Console.WriteLine($"Element number{i + 1}:\t{aArray[i]}");
            break;
        case 19:
            aArray[i] = new Random().Next(min, max);
            Console.WriteLine($"Element number{i + 1}:\t{aArray[i]}");
            Console.WriteLine("Next array is array B[20], sorted in descending order:");
            break;
    }


}
foreach (int element in aArray)
{
    if (element <= 888)
    {
        bArray[count] = element;
        count++;
    }
}
Array.Sort(bArray, (x,y)=>y.CompareTo(x));//Сортування массиву B[20]
Console.WriteLine(String.Join(", ", bArray));//Вивід массиву одним рядком через кому