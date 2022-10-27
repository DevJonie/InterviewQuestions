/*
 * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
 * Then print the respective minimum and maximum values as a single line of two space-separated long integers. 
 * 
 */



MiniMaxSum(new List<int> { 1,3,5,7,9});

static void MiniMaxSum(List<int> arr)
{
    arr.Sort();
    long min = 0;
    long max = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        if (i > 0)
            max += arr[i];

        if (i < arr.Count - 1)
            min += arr[i];
    }
    Console.WriteLine("{0} {1}", min, max);
}