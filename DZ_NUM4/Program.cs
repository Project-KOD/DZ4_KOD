using System;

class Program
{
    static void Main()

    {
        int[] firstArray = { 1, 2, 3, 4, 5 };
        int[] secondArray = { 6, 7, 8, 9, 10 };

        int[] combinedArray = CombineArrays(firstArray, secondArray);

        Console.WriteLine("Объединенный массив: " + string.Join(", ", combinedArray));



        int[] array = { 1, 2, 3, 4, 5 };
        int positions = 2;

        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        RotateArray(array, positions);

        Console.WriteLine("Массив после ротации: " + string.Join(", ", array));
    }

    static int[] CombineArrays(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];

        Array.Copy(array1, result, array1.Length);

        Array.Copy(array2, 0, result, array1.Length, array2.Length);

        return result;
    }

    static void RotateArray(int[] array, int positions)
    {
        int length = array.Length;

        positions = positions % length;

        if (positions == 0) return;

        int[] temp = new int[length];

        for (int i = 0; i < length; i++)
        {
            temp[(i + positions) % length] = array[i];
        }

        Array.Copy(temp, array, length);
    }
}
