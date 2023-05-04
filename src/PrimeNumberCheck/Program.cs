while (true)
{
    try
    {
        Console.Write("Please enter a number: ");
        var n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{n} is {(IsPrime(n) ? "Prime" : "Not prime")}");
    }
    catch 
    {
        Console.WriteLine("ERROR: Invalid input.");
    }
}

static bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }

    if (n == 2)
    {
        return true;
    }

    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
