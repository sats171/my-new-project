// C# program to find missing Number

using System;

class MissingNo
 {
	// Function to find missing number
	static int getMissingNo(int[] a, int n)
	{
		int total = (n + 1) * (n + 2) / 2;

		for (int i = 0; i < n; i++)
			total -= a[i];

		return total;
	}

	/* program to test above function */
	public static void Main()
	{
		int[] a = { 1, 2, 4, 5, 6 };
		int miss = getMissingNo(a, 5);
		Console.Write(miss);
	}
}

