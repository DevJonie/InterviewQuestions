int[] arr = new int[] { -1, 0, 1, 2, 3, 120, 4, 5, 30, 45, 90, 90, -1 };

//Check if Collection Has Duplicates
//Complexity = O(n^2)
bool hasDuplicates = false;
for (int i = 0; i < arr.Length; i++) 
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (i == j) continue;

        if (arr[i] == arr[j])
        {
            hasDuplicates = true;
            break;
        }
    }
}
Console.WriteLine(hasDuplicates ? "Array has duplicates" : "Array has no duplicates");

//Get duplicate items
//Complexity = O(n^2)
var item_indexList_dict = new Dictionary<int, List<int>>();
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (i == j) continue;

        if (arr[i] == arr[j])
        {
            List<int>? list;
            if (item_indexList_dict.TryGetValue(arr[i], out list))
            {
                list.Add(i);
            }
            else 
            {
                item_indexList_dict.Add(arr[i], new List<int> { i });
            }
        }
    }
}
foreach (var item in item_indexList_dict)
{
    Console.Write(item.Key + " : ");
    foreach (var index in item.Value)
    {
        Console.Write(index + ", ");
    }
    Console.WriteLine();
}
//You may print duplicate Items here




//Using HashSet
//check if Collections has duplicates
var hashset = new HashSet<int>(arr);
Console.WriteLine(hashset.Count < arr.Length ? "Array has duplicates" : "Array has no duplicates");

var newHashSet = new HashSet<int>();
var newDuplicateItems = new List<int>();
foreach (int i in arr) 
{
    
}




