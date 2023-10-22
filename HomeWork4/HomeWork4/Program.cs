using System.ComponentModel.Design;

public class PlayWithArrays
{
    public static void Main()
    {
        int quantity, count = 0;
        bool filledValue;
        Console.WriteLine("Write down the quantity of array elements.");
        do
        {
            filledValue = Int32.TryParse(Console.ReadLine(), out quantity);
        } while (!filledValue);
        Console.Write("\n");
        int[] parentArray = FilleArray(quantity);
        int[] evenNumbersArray = new int[quantity];
        int[] oddNumbersArray = new int[quantity];
        foreach (int item in parentArray)
        {
            switch (item % 2)
            {
                case 0:
                    evenNumbersArray[count] = item;
                    break;
                case > 0 or < 0:
                    oddNumbersArray[count] = item;
                    break;
            }
            count++;
        }
        evenNumbersArray = RemovZeroFromArray(evenNumbersArray);
        oddNumbersArray  = RemovZeroFromArray(oddNumbersArray);

        char[] evenArrayChar = ConvertIntArrayInToChar(evenNumbersArray);
        char[] oddArrayChar = ConvertIntArrayInToChar(oddNumbersArray);
        int upperInEvenArray = evenArrayChar.Count(element => char.IsUpper(element));
        int upperInOddArray = oddArrayChar.Count(element => char.IsUpper(element));
        if (upperInEvenArray > upperInOddArray)
        {
            Console.WriteLine($"Even array has:\t{upperInEvenArray} uppercase letters, " +
                              $"\nOdd array has:\t{upperInOddArray} uppercase letters, " +
                              $"it`s less then Even array has.\n");
        }
        else if (upperInEvenArray < upperInOddArray)
        {
            Console.WriteLine($"Even array has:\t{upperInEvenArray} uppercase letters, " +
                              $"\nOdd array has:\t{upperInOddArray} uppercase letters, " +
                              $"it`s more then Even array has.\n");
        }
        else
        {
            Console.WriteLine($"Even array has:\t{upperInEvenArray} uppercase letters, " +
                              $"\nOdd array has:\t{upperInOddArray} uppercase letters, " +
                              $"both arrays have same amount of uppercase letters.\n");
        }
        Console.WriteLine($"Even array:\n{String.Join(",", evenArrayChar)}\n");
        Console.WriteLine($"Odd array: \n{ String.Join(",", oddArrayChar)}");
    }
    public static int[] FilleArray(int arrayQuantity, int min = 1, int max = 26)
    {
        int[] arrayOfElements = new int[arrayQuantity];
        for (int i = 0; i < arrayQuantity; i++)
        {
            arrayOfElements[i] = new Random().Next(min, max);
        }
        return arrayOfElements;
    }

    public static int[] RemovZeroFromArray(IEnumerable<int> array) 
    {
        return array.Where(element => element != 0).ToArray();
    }

    public static char[] ConvertIntArrayInToChar(int[] array) 
    {
        string alphabet  = "AbcDEfgHIJklmnopqrstuvwxyz";
        char[] charArray = new char[array.Length];
        int count = 0;
        foreach (int element in array)
        {
            charArray[count] = alphabet[element-1];
            count++;
        }
        return charArray;
    }
}