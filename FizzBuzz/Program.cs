int[] arr = new int[] { -1, 0, 1, 2 ,3, 4, 5, 30, 45, 90};

foreach (int i in arr) 
{
    if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
	else if (i % 3 == 0)
	{
		Console.WriteLine("Fizz");
	}
	else if (i % 5 == 0)
	{
		Console.WriteLine("Buzz");
	}
	else {
		Console.WriteLine(i);
	}
}
