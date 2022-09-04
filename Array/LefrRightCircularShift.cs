using System.Collections.Generic;
using System;
public static class LefrRightCircularShift
{
    public static void PeformArrayOperations(int[] arr, List<List<int>> queries)
    {
        var n_arr = arr;
        for (int i = 0; i < queries.Count; i++)
        {
            var q = queries[i];
            if (q[0] == 1) n_arr = RotateArray(n_arr, q[1], 1);
            if (q[0] == 2) n_arr = RotateArray(n_arr, q[1], 2);
            if (q[0] == 3)
            {
                //Check Boundries
                var sum = 0;
                for (int j = q[1]; j <= q[2]; j++)
                {
                    sum += n_arr[j];
                }
                Console.WriteLine(sum);
            }
        }
    }

    public static int[] RotateArray(int[] arr, int d, int t)
    {
        if (t == 1)
        {
            int[] tarr = new int[arr.Length];
            for (int i = d; i > 0; i--)
            {
                tarr[d -  i] = arr[arr.Length - i];
            }
            for (int i = d; i < arr.Length; i++)
            {
                tarr[i] = arr[i - d];
            }
            arr = tarr;
        }
        else if (t == 2)
        {
            int[] tarr = new int[arr.Length];
            for (int i = 0; i < d; i++)
            {
                tarr[arr.Length - 1 - i] = arr[d - i - 1];
            }
            for (int i = d; i < arr.Length; i++)
            {
                tarr[i - d] = arr[i];
            }
            arr = tarr;
        }
        return arr;
    }

    public static void Main(string[] strings)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        List<int> query1 = new List<int>() { 2, 1 };
        List<int> query2 = new List<int>() { 3, 0, 2 };
        List<int> query3 = new List<int>() { 1, 3 };
        List<int> query4 = new List<int>() { 3, 1, 4 };
        var queries = new List<List<int>>();
        queries.Add(query1);
        queries.Add(query2);
        queries.Add(query3);
        queries.Add(query4);

        PeformArrayOperations(arr, queries);

    }
}
