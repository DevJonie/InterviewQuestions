int[] arr = new int[] { -1, 0, 1, 2, 3, 120, 4, 5, 30, 45, 90, 90, -1 };
Array.Sort(arr);
PrintArray(arr);
int item = 120;
var index = BinarySearch(arr, item);
Console.WriteLine("Index of {0} = {1}",item,index);

int BinarySearch(int[] arr, int item)
{
    int low = 0;
    int high = arr.Length - 1;
    while (low <= high)
	{
		int mid = (low + high) / 2;
		if (arr[mid] == item)
			return mid;
		else if (arr[mid] < item)
			low = mid + 1;
		else
			high = mid - 1;
	}
	return -1;
}

void PrintArray(int[] arr) 
{
	foreach (var item in arr)
	{
		Console.Write(item + ", ");
	}
	Console.WriteLine();
}



