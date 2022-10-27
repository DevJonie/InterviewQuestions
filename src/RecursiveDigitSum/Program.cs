/*
    We define super digit of an integer

using the following rules:

Given an integer, we need to find the super digit of the integer.

    If 

has only digit, then its super digit is
.
Otherwise, the super digit of
is equal to the super digit of the sum of the digits of

    .

For example, the super digit of 9875

will be calculated as:

	super_digit(9875)   	9+8+7+5 = 29 
	super_digit(29) 	2 + 9 = 11
	super_digit(11)		1 + 1 = 2
	super_digit(2)		= 2  

 */

Console.WriteLine(SuperDigit("9875", 5));

static int SuperDigit(string n, int k)
{
	var digArr = n.ToCharArray()
		.Select(d => ulong.Parse(d.ToString()) * (ulong)k);

    ulong sum = 0;
    foreach (var d in digArr)
    {
        sum += d;
    }

    return int.Parse(SuperLongDigit(sum).ToString());
}


static ulong SuperLongDigit(ulong value)
{
	var numStr = value.ToString();
	if (numStr.Length == 1)
	{
		return value;
	}

	var digArr = numStr.ToCharArray()
		.Select(d => ulong.Parse(d.ToString()));

	ulong sum = 0;
	foreach (var d in digArr)
	{
		sum += d;
	}

	return SuperLongDigit(sum);
}