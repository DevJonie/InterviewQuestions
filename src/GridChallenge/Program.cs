/*
 * Given a square grid of characters in the range ascii[a-z], rearrange elements of each row alphabetically, ascending.
 * Determine if the columns are also in ascending alphabetical order, top to bottom. Return YES if they are or NO if they are not.

Example
grid = ["abc","ade","efg"]

The grid is illustrated below.

a b c
a d e
e f g

The rows are already in alphabetical order. The columns a a e, b d f and c e g are also in alphabetical order, so the answer would be YES.
Only elements within the same row can be rearranged. They cannot be moved to a different row.
 */

Console.WriteLine(GridChallenge(new List<string> 
{
	"abc", "ade", "efg"
}));

static string GridChallenge(List<string> grid)
{
	for (int i = 0; i < grid.Count; i++)
	{
		grid[i] = SortString(grid[i]);
	}

	for (int i = 0; i < grid[0].Length; i++)
	{
		var colArr = new char[grid.Count];
		for (int j = 0; j < grid.Count; j++)
		{
			colArr[j] = grid[j][i];
		}
		var colString = string.Join("", colArr);
		var sortedColString = SortString(colString);
		if (!colString.Equals(sortedColString, StringComparison.OrdinalIgnoreCase))
		{
			return "NO";
		}
	}

	return "YES";
}

static string SortString(string s)
{
	var charArr = s.ToCharArray();
	Array.Sort(charArr);
	return string.Join("", charArr);
}