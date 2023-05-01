int[] arr = new int[] { 5, 1, 4, 2, 8 };

Console.WriteLine($"Unsorted array: {string.Join(", ", arr)}");

for (int i = 0; i < arr.Length; i++)
{
    bool swaped = false;
    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
            swaped = true;
        }
    }

    if (!swaped)
    {
        break;
    }
}

Console.WriteLine($"Sorted array: {string.Join(", ", arr)}");
