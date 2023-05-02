List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < 6; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ')
        .ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp))
        .ToList());
}

int maxhourGlass = int.MinValue;

for (int i = 0; i < arr.Count - 2; i++)
{
    for (int j = 0; j < arr[i].Count - 2; j++)
    {
        var hourGlass = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1] + 
                    arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

        if (hourGlass > maxhourGlass)
        {
            maxhourGlass = hourGlass;
        }
    }
}

Console.WriteLine(maxhourGlass);
