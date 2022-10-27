/*
 Given a square matrix, calculate the absolute difference between the sums of its diagonals. 

*/


Console.WriteLine(DiagonalDifference(new List<List<int>> 
{
    new List<int>{1,2,3 },
    new List<int>{4,5,6 },
    new List<int>{9,8,9 },
}));

static int DiagonalDifference(List<List<int>> arr)
{
    int ld = 0;
    int rd = 0;
    int size = arr.Count() - 1;

    for (int i = 0; i <= size; i++)
    {
        ld += arr[i][i];
        rd += arr[i][size - i];
    }

    return Math.Abs(ld - rd);
}