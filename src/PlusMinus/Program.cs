/* Plus Minus
**************
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to
are acceptable.

*/

PlusMinus(new List<int> { 1, 1, 0, -1, -1 });

static void PlusMinus(List<int> arr)
{
    int pos = 0;
    int negs = 0;
    int zeros = 0;
    foreach (var item in arr)
    {
        if (item < 0) negs++;
        if (item == 0) zeros++;
        if (item > 0) pos++;
    }
    Console.WriteLine("{0:F6}", pos / (double)arr.Count());
    Console.WriteLine("{0:F6}", negs / (double)arr.Count());
    Console.WriteLine("{0:F6}", zeros / (double)arr.Count());
}