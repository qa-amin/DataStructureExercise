namespace Peak_finding
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 3, 9, 10, 5, 2, 6, 7, 4 };

			int left = 0;
			int right = arr.Length - 1;
			int mid;

			while (left < right)
			{
				mid = (left + right) / 2;
				if (arr[mid] < arr[mid + 1])
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}

				
			}

			Console.WriteLine($"Peak is {arr[left]} and Index of Peak is {left}");
		}
	}
}
