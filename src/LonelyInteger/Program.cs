/*
 Given an array of integers, where all elements but one occur twice, find the unique element.

Example
a =[1,2,3,4,3,2,1]
The unique element is . 

*/


Console.WriteLine(Lonelyinteger(new List<int> { 0,0,1,2,1}));


static int Lonelyinteger(List<int> a)
{
    int lonelyIndex = -1;

    for (int i = 0; i < a.Count; i++)
    {
        bool isLonley = true;
        for (int j = 0; j < a.Count; j++)
        {
            if (i == j)
                continue;

            if (a[i] == a[j])
            {
                isLonley = false;
                break;
            }
        }

        if (isLonley)
            return a[i];
    }

    return -1;
}


