namespace long_palindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Time : O(n)  Space : O(1)

			string str = "abdccdceeebebc";

			int length = LongestPalindrome(str);

			Console.WriteLine($"Longest Possible Palindrome is {length}");
		}

		public static int LongestPalindrome(string str)
		{
			int[] arr = new int[128];

			foreach (var chr in str)
			{
				var asci = Convert.ToByte(chr);
				arr[asci] += 1;
			}

			var length = 0;

			foreach (var item in arr)
			{
				if (item % 2 == 0)
				{
					length += item;
				}
				else
				{
					length += (item - 1);
				}
			}

			if (length < str.Length)
			{
				length += 1;
			}

			return length;

		}
	}
}
