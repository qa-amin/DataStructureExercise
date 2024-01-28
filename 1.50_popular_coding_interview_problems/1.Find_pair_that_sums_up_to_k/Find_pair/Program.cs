using Microsoft.VisualBasic;

namespace Find_pair
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Solution 1 : Time : O(nlogn) Space : O(1)
			FirstSolution();

			Console.WriteLine("******************************************************");

			// Solution 2 : Time : O(n) Space : O(n)
			SecondSolution();
		}

		public static void FirstSolution()
		{
			int[] arr = { 1, 1, 0, -2, 3, 5, 2 };

			int k = 7;

			

			Array.Sort(arr);

			int right = arr.Length - 1;
			int left = 0;

			int firstNumber = 0, secondNumber = 0;

			while (left < right)
			{
				if (arr[left] + arr[right] == k)
				{
					firstNumber = arr[left];
					secondNumber = arr[right];
					break;
				}
				else if (arr[left] + arr[right] > k)
				{
					right--;
				}
				else if (arr[left] + arr[right] < k)
				{
					left++;
				}
			}

			if (firstNumber == 0 && secondNumber == 0)
			{
				Console.WriteLine("There is not any pair that sums up to k");
			}
			else
			{
				Console.WriteLine($"First Number is {firstNumber}\nSecond Number is {secondNumber}");
			}
		}

		public static void SecondSolution()
		{
			int[] arr = { 1, 1, 0, -2, 3, 5, 2 };

			int k = 7;



			
			var dic = new Dictionary<int, bool>();

			int firstNumber = 0, secondNumber = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				int key = k - arr[i];
				if (dic.ContainsKey(key))
				{
					firstNumber = key;
					secondNumber = arr[i];
					break;
				}
				else
				{
					dic[arr[i]] = true;
				}

			}

			
			if (firstNumber == 0 && secondNumber == 0)
			{
				Console.WriteLine("There is not any pair that sums up to k");
			}
			else
			{
				Console.WriteLine($"First Number is {firstNumber}\nSecond Number is {secondNumber}");
			}

		}
	}
}
