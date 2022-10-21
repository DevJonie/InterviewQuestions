int[] arr = new int[] { -1, 0, 1, 2, 3, 120, 4, 5, 30, 45, 90 };

//Max of Collection
//Complexity = O(n)
int max = int.MinValue;
foreach (var i in arr)
    if (i > max) max = i;
Console.WriteLine("Max: {0}", max);

//Min of Collection
//Complexity = O(n)
int min = int.MaxValue;
foreach (var i in arr)
    if (i < min) min = i;
Console.WriteLine("Min: {0}", min);

