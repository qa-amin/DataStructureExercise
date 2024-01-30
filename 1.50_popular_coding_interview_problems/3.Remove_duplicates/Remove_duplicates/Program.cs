namespace Remove_duplicates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Solution 1 : Time O(nlogn) Space O(n)

			FirstSolution();

			Console.WriteLine("**********************************************************");

			// Solution 2 : Time O(n) Space O(n)

			SecondSolution();

		}

		public static void FirstSolution()
		{
			int[] arr = { 6, 6, 4, 3, 2, 7, 11, 1, 0, 2, 5, 4, 2 };

			int[] arr2 = new int[arr.Length];

			int j = 1; // arr2 index

			Array.Sort(arr);

			arr2[0] = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] != arr[i - 1])
				{
					arr2[j] = arr[i];
					j++;
				}
			}

			Console.WriteLine("Array without duplication:");
			for (int i = 0; i < j; i++)
			{
				Console.WriteLine(arr2[i]);
			}
		}

		public static void SecondSolution()
		{
			int[] arr = { 6, 6, 4, 3, 2, 7, 11, 1, 0, 2, 5, 4, 2 };

			var dic = new Dictionary<int, bool>();

			for (int i = 0; i < arr.Length; i++)
			{
				dic[arr[i]] = true;
			}

			foreach (var item in dic.Keys.ToArray())
			{
				Console.WriteLine(item);
			}
		}
	}
}
