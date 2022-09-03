using System;
public static class BinarySearch
{
    public static int Search_Recursive(int[] arr, int number, int min, int max)
    {
        var mid = (min + max) / 2;
        if (arr[mid] == number)
        {
            return mid;
        }
        else if (arr[mid] < number)
        {
            return Search_Recursive(arr, number, mid + 1, max);
        }
        else if (arr[mid] > number)
        {
            return Search_Recursive(arr, number, min, mid - 1);
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 10, 29, 30, 45, 90 };
        var find = 90;
        Console.WriteLine(Search_Recursive(arr, find, 0, arr.Length));
    }
}
