using System.ComponentModel.Design;
using System.Security.Cryptography;

int[] arr = new int[] { -1, 0, 1, 2, 3, 120, 4, 5, 30, 45, 90, 90, -1 };
Array.Sort(arr);
PrintArray(arr);
int item = 120;

Console.WriteLine("(While loop) Index of {0} = {1}",item, BinarySearchWhileLoop(arr, item));

Console.WriteLine("(Recursion) Index of {0} = {1}",item, BinarySearchWithRecursion(arr, item));

//Using While loop
//Complexity O(log n)
int BinarySearchWhileLoop(int[] arr, int item)
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


//Using Recursion
int BinarySearchWithRecursion(int[] arr, int item)
{
    return BinarySearch(arr, item, 0, arr.Length - 1);

    int BinarySearch(int[] arr, int item, int low, int high)
    {
        int mid = (low + high) / 2;

        if (arr[mid] == item)
            return mid;

		if (mid == arr.Length - 1 || mid == 0)
			return -1;

        if (arr[mid] < item)
            return BinarySearch(arr, item, mid + 1, high);
        else
            return BinarySearch(arr, item, low, mid - 1);
    }
}


void PrintArray(int[] arr) 
{
	foreach (var item in arr)
	{
		Console.Write(item + ", ");
	}
	Console.WriteLine();
}



