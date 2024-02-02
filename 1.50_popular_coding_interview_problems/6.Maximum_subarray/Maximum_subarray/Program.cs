namespace Maximum_subarray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2, 3, -8, 4, 5 };

			int localSum = 0;
			int globalSum = arr[0];

			for (int i = 0; i < arr.Length; i++)
			{
				localSum = Math.Max(arr[i], arr[i] + localSum);
				globalSum = Math.Max(globalSum,localSum);
			}

			Console.WriteLine($"Max Sub array is : {globalSum}");
		}
	}
}
