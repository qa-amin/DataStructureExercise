namespace _4.Find_the_duplicate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// solution 1  Time : O(nlogn) Space : (1)

			FirstSolution();

			Console.WriteLine("**********************************************************");

			// solution 2 Time : O(n) Space : O(n)

			SecondSolution();

			Console.WriteLine("**********************************************************");

			// solution 3 Time : O(n)  Space : O(1)  if length of array is  n value must be between 1 to n-1

			ThirdSolution();
		}

		public static void FirstSolution()
		{
			int[] arr = { 1, 4, 2, 5, 0, 4, };

			int? duplicate = null;

			Array.Sort(arr);

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == arr[i + 1])
				{
					duplicate = arr[i];
					break;
				}
			}

			if (duplicate != null)
			{
				Console.WriteLine($"Duplicate Number is : {duplicate}");
			}
			else
			{
				Console.WriteLine("There is No Duplicate Number");
			}
		}

		public static void SecondSolution()
		{
			int[] arr = { 1, 4, 2, 5, 0, 4, };

			var dic = new Dictionary<int, bool>();

			int? duplicate = null;

			for (int i = 0; i < arr.Length; i++)
			{
				if (dic.ContainsKey(arr[i]))
				{
					duplicate = arr[i];
					break;
				}
				else
				{
					dic[arr[i]] = true;
				}
			}
			if (duplicate != null)
			{
				Console.WriteLine($"Duplicate Number is : {duplicate}");
			}
			else
			{
				Console.WriteLine("There is No Duplicate Number");
			}
		}

		public static void ThirdSolution()
		{
			int[] arr = { 1, 4, 2, 5, 3, 4, };

			int? duplicate = null;

			int tortoise = arr[0];
			int hare = arr[arr[0]];

			while (tortoise != hare)
			{
				tortoise = arr[tortoise];
				hare = arr[arr[hare]];
			}

			tortoise = 0;

			while (tortoise != hare )
			{
				tortoise = arr[tortoise];
				hare = arr[hare];
			}

			duplicate = tortoise;


			if (duplicate != null)
			{
				Console.WriteLine($"Duplicate Number is : {duplicate}");
			}
			else
			{
				Console.WriteLine("There is No Duplicate Number");
			}
		}

	}
}
