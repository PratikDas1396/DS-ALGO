using System;

public static class SearchElementInSortedRotatedArray
{
    public static int Search(int[] arr, int number, int min, int max)
    {
        int pivot = findPivot(arr, min, max);
        int leftOutput = BinarySearch(arr, number, min, pivot);
        if (leftOutput == -1)
        {
            return BinarySearch(arr, number, pivot + 1, max);
        }
        return leftOutput;
    }

    public static int findPivot(int[] arr, int min, int max)
    {
        if (max < min) return -1;
        if (min == max) return min;

        int mid = (min + max) / 2;
        Console.WriteLine($"Min:{min} Max:{max} Mid: {mid}");

        if (mid < max && arr[mid] > arr[mid + 1])
            return mid;

        if (mid > min && arr[mid] < arr[mid - 1]) return mid - 1;

        if (arr[min] >= arr[mid])
            return findPivot(arr, min, mid - 1);

        return findPivot(arr, mid + 1, max);

    }

    public static int BinarySearch(int[] arr, int number, int min, int max)
    {
        var mid = (min + max) / 2;
        if (min <= max)
        {
            if (arr[mid] == number)
                return mid;
            if (arr[mid] < number)
                return BinarySearch(arr, number, mid + 1, max);
            return BinarySearch(arr, number, min, mid - 1);
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 60, 70, 80, 90, 100, 20, 40, 50 };
        Console.WriteLine(Search(arr, 40, 0, arr.Length));
        Console.ReadLine();
    }
}
