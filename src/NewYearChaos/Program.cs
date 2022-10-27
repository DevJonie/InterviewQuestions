/*
 It is New Year's Day and people are in line for the Wonderland rollercoaster ride.
Each person wears a sticker indicating their initial position in the queue from to

. Any person can bribe the person directly in front of them to swap positions, but they still wear their original sticker.
One person can bribe at most two others.

Determine the minimum number of bribes that took place to get to a given queue order.
Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic.

*/


MinimumBrides(new List<int> { 2, 1, 5, 3, 4 });

static void MinimumBrides(List<int> q)
{
    int bribeCount = 0;
	for (int i = q.Count-1; i >= 0; i--)
	{
		if (q[i] != i+1)
		{
			if (q[i - 1] == i + 1)
			{
				bribeCount += 1;
				int temp = q[i];
				q[i] = q[i - 1];
				q[i] = temp;
			}
			else if (q[i - 2] == i + 1)
			{
				bribeCount += 2;
				int temp = q[i - 2];
				q[i - 2] = q[i];
				q[i] = q[i - 1];
				q[i - 1] = temp;
			}
			else 
			{
				Console.WriteLine("Too Chaotic");
				return;
			}
		}
	}
	Console.WriteLine(bribeCount);
}

